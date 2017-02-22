using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Oberverpattern
{
    class Message : Observable
    {
        private string _data;

        public Message()
        {
            _data = "default";
        }
        public string Data
        {
            get { return _data; }
            set {
                _data = value;
                    this.NotifyObservers();
                messages.Add(this);
            
            }
        
        }
    }
}
