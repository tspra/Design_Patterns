using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Partcipants.ConcreteElement;
using Visitor_Pattern.Partcipants.Element;
using Visitor_Pattern.Partcipants.Visitor;

namespace Visitor_Pattern.Partcipants.ConcreteVisitor
{
    public class Doctor : IVisitor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;
            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the employee: " + employee.employeeName);
        }
    }
}
