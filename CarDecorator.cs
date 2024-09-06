using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;
        

        public CarDecorator(ICar car)
        {
            this._car = car;

        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual int GetSpeed()
        {
            return _car.GetSpeed();
        }
    }
}
