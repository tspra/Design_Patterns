using Observer_Pattern.Participants.Observer;
using Observer_Pattern.Participants.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Participants.ConcreteObserver
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string name, ISubject subject)
        {
            UserName = name;
            subject.Register(this);
        }
        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
