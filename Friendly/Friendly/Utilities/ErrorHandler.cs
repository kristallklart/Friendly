using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Friendly.Utilities
{
    public static class ErrorHandler
    {       
        public static string HandleError(Exception e)
        {
            string message = "";
            int errorCode;
            if (e is DbUpdateException)
            {
                SqlException sqlEx = e.GetBaseException() as SqlException;
            }
            if (e is SqlException)
            {
                errorCode = (e as SqlException).Number;
                switch (errorCode)
                {
                    case 2627: // Primary key violation
                        message = "Username already exists, please try another one";
                        break;
                    default:
                        break;
                }
            }
            else if (e is ArgumentNullException)
            {
                message = "Du fick ett exception, grattis! Gå och gör lite thé medans smurfarna städar upp efter dig.";
            }
            else if (e is InvalidUserOrPasswordException)
            {
                message = e.Message;
            }
            return message;
        }
    }
}
