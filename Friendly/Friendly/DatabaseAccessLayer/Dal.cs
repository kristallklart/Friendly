using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using Friendly.Model;
using Friendly.Utilities;
using System.Data.Entity.Infrastructure;
using Sodium;
using Sodium.Exceptions;

namespace Friendly.DatabaseAccessLayer
{
    public static class Dal
    {
        public static void AddNewUser(User user)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw ex.GetBaseException();
                }
            }
        }
        public static bool CheckUserExists(string username)
        {
            bool userExists;
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                try
                {
                    userExists = context.Users.Any(user => user.Username.Equals(username, StringComparison.Ordinal));                   
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (ArgumentNullException)
                {
                    throw;
                }
                return userExists;
            }
        }
        public static bool CheckUsernameAndPassword(string username, string password)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                bool userExists = context.Users.Any(user => user.Username.Equals(username, StringComparison.Ordinal));
                if (!userExists)
                {
                    throw new InvalidUserOrPasswordException("Couldn't find user with username: " + username);
                }
                else
                {
                    User tempUser = context.Users.FirstOrDefault(user => user.Username.Equals(username, StringComparison.Ordinal));
                    if (PasswordHash.ScryptHashStringVerify(tempUser.Password, password))
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidUserOrPasswordException("The entered password doesn't match for username: " + username);
                    }
                }
            }
        }
    }
}
