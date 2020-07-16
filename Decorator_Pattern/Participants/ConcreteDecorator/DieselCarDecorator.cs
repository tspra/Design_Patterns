using Decorator_Pattern.Participants.Component;
using Decorator_Pattern.Participants.ConcreteComponent;
using Decorator_Pattern.Participants.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Participants.ConcreteDecorator
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            AddEngine(car);
            return car;

        }
        public void AddEngine(ICar car)
        {
            if (car is Bmw)
            {
                Bmw BMWCar = (Bmw)car;
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : ");
            }
        }
    }
}
