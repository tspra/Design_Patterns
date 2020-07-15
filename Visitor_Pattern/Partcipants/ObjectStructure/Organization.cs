using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Partcipants.ConcreteElement;
using Visitor_Pattern.Partcipants.Element;
using Visitor_Pattern.Partcipants.Visitor;

namespace Visitor_Pattern.Partcipants.ObjectStructure
{
    public class Organization
    {
        private static List<IElement> elements;
        static Organization()
        {
            elements = new List<IElement>
            {
                new Employee("John"),
                new Employee("Adam"),
                new Employee("Martin") 
            };
        }

        public void Execute(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

        }
    }
}
