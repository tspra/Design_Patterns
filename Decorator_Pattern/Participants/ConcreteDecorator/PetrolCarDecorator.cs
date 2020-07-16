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
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;

        }
        public void AddEngine(ICar car)
        {
            if (car is Bmw)
            {
                Bmw BMWCar = (Bmw)car;
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " );
            }
        }
    }
}
