using NatureTrans.Auth;
using NatureTrans.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatureTrans.Service
{
    internal class LoginService
    {
        private readonly NTContext _context;
        public LoginService(NTContext context)
        {
            _context = context;
        }

        public bool VerifyLogin(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.username == username);

            if (user != null && VerifyPassword(password, user.password))
            {
                Session.UserId = user.id;
                Session.Username = user.username;
                Session.email = user.email;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedPasswordHash);
        }

    }
}
