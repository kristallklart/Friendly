using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Utilities
{
    public class InvalidUserOrPasswordException : SystemException
    {
        public InvalidUserOrPasswordException() { }
        public InvalidUserOrPasswordException(string msg) : base(msg) { }
    }
}
