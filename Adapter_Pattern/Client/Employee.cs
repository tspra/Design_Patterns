using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Client
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            EmpId = id;
            Salary = salary;
        }
    }
}
