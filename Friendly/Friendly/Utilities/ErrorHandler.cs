using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.IO;

namespace Friendly.Utilities
{
    public static class ErrorHandler
    {       
        public static string HandleError(Exception e)
        {
            string message = "";

            if (e is DbUpdateException || e is EntityException)
            {       
                SqlException sqlEx = e.GetBaseException() as SqlException;                
                int errorCode = sqlEx.Number;
                switch (errorCode)
                {
                    case 2627: // Primary key violation
                        if(sqlEx.Message.Contains("PK_User_Location_Purpose"))
                        {
                            message = "A preference with the entered values already exists for your account.";
                        }
                        else if (sqlEx.Message.Contains("PK_Users"))
                        {
                            message = "Username already exists, please try another one";
                        }
                        else if (sqlEx.Message.Contains("PK_Match"))
                        {
                            message = "You have aldready matched with this person.";
                        }
                        break;
                    case 4060: // Couldn't connect to the database
                        message = "Could not connect to the database, please contact support";
                        break;
                }     
            }      
            else if (e is InvalidUserOrPasswordException)
            {
                message = e.Message;
            }
            else if (e is DbEntityValidationException)
            {
                message = "One or more of the values you entered where not valid, please check your details and try again.";
            }
            else if (e is OutOfMemoryException)
            {
                message = "The file you selected was not in a supported file format.";
            }
            else if (e is ArgumentNullException)
            {
                message = "Unfortunately something went wrong, please restart the application and try again.";
            }
            else if (e is ArgumentException)
            {
                message = "The file you selected was not in a supported file format.";
            }
            else if (e is FileNotFoundException)
            {
                message = "The file you selected could not be found, please try again or choose another file.";
            }
            return message;
        }
    }
}
