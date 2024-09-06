using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DecoratorPattern
{
    public class Conditiong : CarDecorator
    {
        public Conditiong(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return _car.GetDescription();
        }
    }
}
