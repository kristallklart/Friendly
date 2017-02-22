using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Friendly.Oberverpattern;

namespace Friendly.Oberverpattern
{
    class UserT :Observable, IObserver
    {
        private string _name;
        public UserT()
        {
            _name = "MyObserver";
        }
        public UserT(string name)
        {
            _name = name;
        }
        public void Update (Observable o)
        {
            foreach (Message m in messages)
            {
                
            }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
