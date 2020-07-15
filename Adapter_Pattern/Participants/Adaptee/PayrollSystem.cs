using Adapter_Pattern.Participants.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Participants.Adaptee
{
    public class PayrollSystem
    {

        public void ProcessSalary(Employee employee)
        {
            Console.WriteLine("The Amount {0} credited to employee name {1} account", employee.Salary, employee.Name);
        }
    }
}
