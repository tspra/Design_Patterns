using Observer_Pattern.Participants.Observer;
using Observer_Pattern.Participants.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Participants.ConcreteSubject
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public string ProductName { get; }
        public int  Price { get; }
        public string Availbility { get; set; }

        public void SetAvailability(string availbility)
        {
            Availbility = availbility;
            Notify();
        }
        public string  GetAvailability()
        {
            return Availbility;
        }
        public Subject(string name, int price, string availbility)
        {
            ProductName = name;
            Price = price;
            Availbility = availbility;
        }
        public void Notify()
        {
           foreach(var observer in observers)
            {
                observer.Update(Availbility);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

       
        public void UnRegister(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
