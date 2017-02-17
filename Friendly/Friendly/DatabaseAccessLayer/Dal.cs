using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using Friendly.Model;
using System.Data.Entity.Infrastructure;

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
    }
}
