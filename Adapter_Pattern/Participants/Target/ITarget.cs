﻿using Adapter_Pattern.Participants.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Participants.Target
{
    public interface ITarget
    {
        void ProcessSalary(List<Employee> employees);
    }
}
