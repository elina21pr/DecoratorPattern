using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Car : ICar
    {
        private string model;
        private int speed;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public virtual string GetDescription()
        {
            return $"Car:{model}";
        }

        public virtual int GetSpeed()
        {
            return speed;
        }
    }
}
