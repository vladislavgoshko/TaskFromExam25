using ConsoleApp.Interfaces;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    class Bar : IBar
    {
        private List<Drink> _drinks;

        public Bar() : this(null)
        {

        }

        public Bar(params Drink[] drinks)
        {
            _drinks = new List<Drink>();
            for (int i = 0; i < drinks?.Length; ++i){
                _drinks[i] = drinks[i];
            }
        }
        public void Add(Drink drink)
        {
            _drinks.Add(drink);
        }

        public void Buy(Drink drink)
        {
            _drinks.Remove(drink);
        }

        public IReadOnlyCollection<Drink> GetDrinks(Drink drink)
        {
            return _drinks.AsReadOnly();
        }
    }
}
