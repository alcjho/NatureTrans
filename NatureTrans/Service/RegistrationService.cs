using Microsoft.EntityFrameworkCore;
using NatureTrans.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace NatureTrans.Service
{
    internal class RegistrationService
    {
        private readonly NTContext _context;
        public RegistrationService(NTContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                // Validate user data (ensure required fields are not null or empty)
                if (string.IsNullOrWhiteSpace(user.username) ||
                    string.IsNullOrWhiteSpace(user.password))
                {
                    throw new ArgumentException("User data must have valid username and password.");
                }

                // Check if user already exists by username
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.username == user.username);
                user.password = hashPasswd(user.password);

                if (existingUser != null)
                {
                    throw new InvalidOperationException("User with that username already exists.");
                }

                // Add the user to the context
                await _context.Users.AddAsync(user);

                // Save changes to the database
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully (log errors, rethrow)
                Console.Error.WriteLine($"Error adding user: {ex.Message}");
                return false; // Error occurred
            }
        }

        private string hashPasswd(string password)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            return hash;
        }

        public async Task<bool> UserExistsAsync(string username)
        {
            try
            {
                // Check if a user with the given username exists
                var user = await _context.Users.FirstOrDefaultAsync(u => u.username == username);

                // Return true if the user exists, false otherwise
                return user != null;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.Error.WriteLine($"Error checking user existence: {ex.Message}");
                return false;
            }
        }
    }
}
