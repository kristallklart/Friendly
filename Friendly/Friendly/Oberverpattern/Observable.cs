using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Oberverpattern
{
    public abstract class Observable
    {
        private ArrayList _obs;
        public Observable() { _obs = new ArrayList(); messages = new ArrayList(); }
        public ArrayList messages;
        
        
        public void Attach(IObserver o)
        {
            if (!_obs.Contains(o))
            {
                lock (this)
                {
                    _obs.Add(o);
                }
            }
        }
        public void Detach(IObserver o)
        {
            lock (this)
            {
                _obs.Remove(o); 
             }
        }
        public void NotifyObservers()
        {
            foreach (IObserver o in _obs)
            {
                o.Update(this);
            }
        }

    }
}
