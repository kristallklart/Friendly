﻿using System;
using System.Collections.Generic;
using System.Linq;
using Friendly.Model;
using Friendly.Utilities;
using Sodium;

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
                User tempUser = context.Users.FirstOrDefault(user => user.Username.Equals(username, StringComparison.Ordinal));

                if (PasswordHash.ScryptHashStringVerify(tempUser.Password, password))
                {
                    return tempUser;
                }
                throw new InvalidUserOrPasswordException("The entered password doesn't match username: " + username);
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
                return locations;
            }
        }

        public static List<User_Location_Purpose> GetUserOwnLocations(string username)
         {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<User_Location_Purpose> locations = context.User_Location_Purpose.Where(l => l.Username == username).ToList();
                return locations;
            }
         }

        public static List<Message> GetAllMessages (string sender, string reciever)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<Message> messages = context.Messages.Where(s => s.Sender == sender || s.Sender == reciever).Where(r => r.Reciever == reciever || r.Reciever == sender).ToList();
                return messages;
            }
        }

        public static List<FieldOfProfession> GetFieldOfProfessions()
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<FieldOfProfession> industries = context.FieldOfProfessions.ToList();
                return industries;
            }
        }

        public static List<User_Location_Purpose> GetUsersByCity(string city, User currentuser)
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
                DateTime dateOfBirth = Convert.ToDateTime(context.Users.Where(u => u.Username == username).Select(u => u.Birthdate).FirstOrDefault());
                age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                {
                    age = age - 1;
                }
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

        public static List<Match> GetMatches(User currentuser)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                List<Match> matches = context.Match.Where(m => m.Username == currentuser.Username).ToList();
                return matches;
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

        public static void DeleteUserLocationPurpose(User_Location_Purpose ulp)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                context.User_Location_Purpose.Attach(ulp);
                context.User_Location_Purpose.Remove(ulp);
                context.SaveChanges();
            }
        }

        public static void SaveProfilePicture(string username, byte[] picture)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                User user = context.Users.FirstOrDefault(u => u.Username == username);
                user.Picture = picture;
                context.SaveChanges();
            }
        }

        public static void AddMatch( User currentuser, string match)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                
                    Match m = new Match();
                    m.MatchUsername = match;
                    m.User = context.Users.FirstOrDefault(u => u.Username == currentuser.Username);
                    context.Match.Add(m);
                    context.SaveChanges();            
            }
        }

        public static void AddMessage(string sender, string receiver, string message)
        {
            using (FriendlyDBEntities context = new FriendlyDBEntities())
            {
                Message m = new Message();
                m.Sender = sender;
                m.Reciever= receiver;
                m.Content = message;
                context.Messages.Add(m);
                context.SaveChanges();
            }
        }
    }
}
