using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Options
{
    public class SportPackage : CarDecorator
    {
        public SportPackage(ICar car) : base(car) { }
        public override string GetDescription()
        {
            return _car.GetDescription() + " with sport package";
        }
        public override int GetSpeed()
        {
            return _car.GetSpeed() + 60;
        }
    }
}
