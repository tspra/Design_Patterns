﻿using Decorator_Pattern.Participants.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Participants.Decorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
