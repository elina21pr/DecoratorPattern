using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Options
{
    public class HeatedSeats : CarDecorator
    {
        public HeatedSeats(ICar car) : base(car) { }

       
        public override string GetDescription()
        {
            return _car.GetDescription() + " with heated seats";
        }
    }
}
