﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly.Oberverpattern
{
    public interface IObserver
    {
        void Update(Observable o);
    }
}