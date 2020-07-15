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
    class BankPerson : IVisitor
    {
        public string Name { get; set; }

        public BankPerson(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Employee employee = (Employee)element;
            Console.WriteLine("BankPerson: " + this.Name + " activated account for the employee: " + employee.employeeName);
        }

    }
}
