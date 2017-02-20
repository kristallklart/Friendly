using System;
using System.Collections.Generic;
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
            else if (e is InvalidUserOrPasswordException)
            {
                message = e.Message;
            }
            return message;
        }
    }
}
