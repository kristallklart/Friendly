using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity.Core;
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
            if (e is DbUpdateException || e is EntityException)
            {
                if (e.GetBaseException() is SqlException)
                {
                    SqlException sqlEx = e.GetBaseException() as SqlException;                
                    int errorCode = sqlEx.Number;
                    switch (errorCode)
                    {
                        case 2627: // Primary key violation
                            message = "Username already exists, please try another one";
                            break;
                        case 4060: // Couldn't connect to the database
                            message = "Could not connect to the database, please contact support";
                            break;
                        default:
                            break;
                    }      
                }            
            }          
            else if (e is DbEntityValidationException)
            {
                message = "One or more of the values you entered where invalid, please check your details and try again.";
            }
            else if (e is ArgumentNullException)
            {
                message = "Unfortunately something went wrong, please restart the application and try again.";
            }
            else if (e is InvalidUserOrPasswordException)
            {
                message = e.Message;
            }
            return message;
        }
    }
}
