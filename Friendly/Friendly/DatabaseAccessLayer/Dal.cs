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
                    context.Users.Add(user);
                    context.SaveChanges();
            }
        }
        public static User CheckUsernameAndPassword(string username, string password)
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
                        return tempUser;
                    }
                    else
                    {
                        throw new InvalidUserOrPasswordException("The entered password doesn't match for username: " + username);
                    }
                }
            }
        }
        public static void UpdateUser (User u)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                User updateUser = context.Users.SingleOrDefault(b => b.Username == u.Username);
                context.Entry(updateUser).CurrentValues.SetValues(u);
                context.SaveChanges();
            }
        }
        public static User GetUser(string username)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                return context.Users.FirstOrDefault(user => user.Username.Equals(username, StringComparison.Ordinal));
            }
        }
        public static List<User_Location_Purpose> GetUserLocations(string username)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<User_Location_Purpose> locations = context.User_Location_Purpose.Where(l => l.Username == username).ToList();           
                return locations; }
        }
        public static List<FieldOfProfession> GetFieldOfProfessions()
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<FieldOfProfession> industries = context.FieldOfProfessions.ToList();
                return industries; 
            }
        }
        public static List<User_Location_Purpose> GetUsersByCity(string city,User currentuser)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<User_Location_Purpose> cities = context.User_Location_Purpose.Where(l => l.City == city).Where(l => l.Username != currentuser.Username).ToList();
                return cities;
            }
        }
        public static int GetAge(string username)
        {
           using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
               int age = 0;
                //kolla med labb
                DateTime dateOfBirth = Convert.ToDateTime(context.Users.Where(u => u.Username == username).Select(u => u.Birthdate).FirstOrDefault());
                age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                   age = age - 1;
               return age;
            }
        }
        public static List<Purpose> GetPurposes()
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<Purpose> purposes = context.Purposes.ToList();
                return purposes;
            }
        }
        public static List<Location> GetLocations()
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<Location> locations = context.Locations.ToList();
                return locations;
            }
        }
        public static void AddUserLocationPurpose(User_Location_Purpose ulp)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                context.User_Location_Purpose.Add(ulp);
                context.SaveChanges();
            }
        }
        public static void DeleteUserLocatioPurpose(User_Location_Purpose ulp)
        {
            using(FriendlyDBEntities context = new FriendlyDBEntities())
            {

                context.User_Location_Purpose.Attach(ulp);
                context.User_Location_Purpose.Remove(ulp);
                context.SaveChanges();
            }
        }
    }
}
