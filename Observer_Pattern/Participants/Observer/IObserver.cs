﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Participants.Observer
{
    public interface IObserver
    {
        void Update(string availabiliy);
    }
}
