using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Interfaces

{
    public interface IBar
    {
        void Buy(Drink drink);
        void Add(Drink drink);
        IReadOnlyCollection<Drink> GetDrinks(Drink drink);
    }
}
