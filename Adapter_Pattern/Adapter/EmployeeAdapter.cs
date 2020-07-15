using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Pattern.Adaptee;
using Adapter_Pattern.Client;
using Adapter_Pattern.Target;

namespace Adapter_Pattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly PayrollSystem payrollSystem;
         public EmployeeAdapter()
          {
             payrollSystem = new PayrollSystem();
          }
        public void ProcessSalary(List<Employee> employees)
        {
            foreach(var employye in employees)
            {
                payrollSystem.ProcessSalary(employye);
            }
        }
    }
}
