using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friendly.Model;
using Friendly.DatabaseAccessLayer;
using Friendly.View;

namespace Friendly.ControllerLayer
{
    public static class Controller
    {
        public static void AddNewUser(User user)
        {
            Dal.AddNewUser(user);
        }
        public static User CheckUsernameAndPassword(string username, string password)
        {
            return Dal.CheckUsernameAndPassword(username, password);
        }
        public static void UpdateUser(User u)
        {
            Dal.UpdateUser(u);
        }
        public static User GetUser(string username)
        {
            return Dal.GetUser(username);
        }
        public static List<User_Location_Purpose> GetUserLocations(string username)
        {
            return Dal.GetUserLocations(username);
        }
        public static List<User_Location_Purpose> GetUserOwnLocations(string username)
        {
            return Dal.GetUserOwnLocations(username);
        }
        public static List<FieldOfProfession> GetFieldOfProfessions()
        {
            return Dal.GetFieldOfProfessions();
        }
        public static List<User_Location_Purpose> GetUsersByCity(string city, User currentuser)
        {
            return Dal.GetUsersByCity(city, currentuser);
        }
        public static int GetAge(string username)
        {
            return Dal.GetAge(username);
        }
        public static List<Purpose> GetPurposes()
        {
            return Dal.GetPurposes();
        }
        public static List<Match> GetMatches(User currentuser)
        {
            return Dal.GetMatches(currentuser);
        }
        public static List<Location> GetLocations()
        {
            return Dal.GetLocations();
        }
        public static void AddUserLocationPurpose(User_Location_Purpose ulp)
        {
            Dal.AddUserLocationPurpose(ulp);
        }
        public static void DeleteUserLocatioPurpose(User_Location_Purpose ulp)
        {
            Dal.DeleteUserLocatioPurpose(ulp);
        }
        public static void SaveProfilePicture(string username, byte[] picture)
        {
            Dal.SaveProfilePicture(username, picture);
        }
        public static void AddMatch(User currentuser, string match)
        {
            Dal.AddMatch(currentuser, match);
        }
        public static void AddMessage(string sender, string receiver, string message)
        {
            Dal.AddMessage(sender, receiver, message);
        }
        public static List<Message> GetAllMessages(string sender, string reciever)
        {
           return  Dal.GetAllMessages(sender, reciever);
        }
    }
}
