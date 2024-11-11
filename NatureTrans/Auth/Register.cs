using System.Linq;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System;
using NatureTrans.Interface;

namespace NatureTrans.Auth
{
    internal class Register
    {
        private object user;
        private SqlConnection connection;
        private string connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ntdb.mdf;Integrated Security=True";
        private SqlCommand command;
        private SqlDataReader dr;
        public Register() 
        {
            //this.connection = new SqlConnection(connectionString);
            //this.connection.Open();
        }

        public bool add_user(UserInterface user) 
        {
            if (!this.user_exists(user.email))
            {
                this.command = new SqlCommand("INSERT INTO User(username, email, password, salt_password, hash_password) VALUES(@username, @email, @password, '', 'SHA512')");
                this.command.Parameters.AddWithValue("username", user.username);
                this.command.Parameters.AddWithValue("email", user.email);
                this.command.Parameters.AddWithValue("password", user.password);
                this.command.Parameters.AddWithValue("salt_password", user.salt_password);
                this.command.Parameters.AddWithValue("sha512", user.hash_password);
                this.command.ExecuteNonQuery();
            }

            return true;
        }

        private bool user_exists(string email)
        {
            this.command = new SqlCommand("SELECT * FROM User WHERE email = @email");
            this.command.Parameters.AddWithValue("email", email);
            this.dr = this.command.ExecuteReader();
            
            return dr.Read();
        }

    }
}
