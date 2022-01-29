using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public abstract class Drink
    {
        public virtual double Volume { get; protected set; }
        
        public virtual decimal Price { get; protected set; }

        protected Drink()
        {

        }

        protected Drink(double volume, decimal price)
        {
            Volume = volume;
            Price = price;
        }
    }
}
