using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friendly.Model;
using Friendly.DatabaseAccessLayer;


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
        public static List<FieldOfProfession> GetFieldOfProfessions()
        {
            return Dal.GetFieldOfProfessions();
        }
        public static List<User_Location_Purpose> GetUsersByCity(string city, User currentuser)
        {
            return Dal.GetUsersByCity(city,currentuser);
        }
            

        public static int GetAge(string username)
       {
           return Dal.GetAge(username);
        }

        public static List<Purpose> GetPurposes()
        {
            return Dal.GetPurposes();
        }
        public static List<Location> GetLocations()
        {
            return Dal.GetLocations();
        }
    }
}
