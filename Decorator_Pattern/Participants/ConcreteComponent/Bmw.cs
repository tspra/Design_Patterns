using Decorator_Pattern.Participants.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Participants.ConcreteComponent
{
    public class Bmw : ICar
    {
        public string CarBody { get; set; }
        public string Engine { get; set; }
        public ICar ManufactureCar()
        {
            CarBody = "Carbon fiber material";
            return this;
        }
    }
}
