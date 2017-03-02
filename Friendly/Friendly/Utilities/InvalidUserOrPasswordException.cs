using System;

namespace Friendly.Utilities
{
    public class InvalidUserOrPasswordException : SystemException
    {
        public InvalidUserOrPasswordException() { }
        public InvalidUserOrPasswordException(string msg) : base(msg) { }
    }
}
