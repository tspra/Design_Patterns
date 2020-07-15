using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Partcipants.ConcreteVisitor;
using Visitor_Pattern.Partcipants.ObjectStructure;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Organization();

            var visitor1 = new BankPerson("John");
            org.Execute(visitor1);


            var visitor2 = new Doctor("Smith");
            org.Execute(visitor2);

            Console.Read();
        }
    }
}
