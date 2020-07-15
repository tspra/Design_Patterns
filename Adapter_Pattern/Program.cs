using Adapter_Pattern.Adapter;
using Adapter_Pattern.Client;
using Adapter_Pattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var employess = new List<Employee>
            {
                new Employee("prajeesh",1,100000),
                new Employee("Sanu",1,40000),
                new Employee("Manu",1,70000),

            };

            ITarget target = new EmployeeAdapter();
            target.ProcessSalary(employess);
            Console.ReadLine();
        }
    }
}
