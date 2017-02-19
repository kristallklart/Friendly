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
        public static User GetUser(string username)
        {
            return Dal.GetUser(username);
        }
    }
}
