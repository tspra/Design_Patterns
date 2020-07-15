using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Partcipants.Element;
using Visitor_Pattern.Partcipants.Visitor;

namespace Visitor_Pattern.Partcipants.ConcreteElement
{
    public class Employee : IElement
    {
        public string employeeName { get; set; }

        public Employee(string name)
        {
            employeeName = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
