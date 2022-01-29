using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public abstract class MixedDrink : Drink
    {

        private List<Drink> _additiveDrinks;

        public override double Volume
        {
            get
            {
                double volume = 0;
                foreach (Drink drink in _additiveDrinks);
                return volume;
            }
        }

        public override decimal Price
        {
            get
            {
                decimal price = 0;
                foreach (Drink drink in _additiveDrinks) price += drink.Price;
                return price;
            }
        }

        protected MixedDrink(params Drink[] drinks)
        {
            _additiveDrinks = new List<Drink>();
            for (int i = 0; i< drinks?.Length; ++i)
            {
                _additiveDrinks[i] = drinks[i];
            }
        }
    }
}
