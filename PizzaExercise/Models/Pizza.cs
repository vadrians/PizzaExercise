using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaExercise.Models
{
    public class Pizza 
    {
        public IEnumerable<string> Toppings { get; set; } = new List<string>();       
    }

    public class PizzaComparer : IEqualityComparer<Pizza>
    {
        public  bool Equals(Pizza x, Pizza y)
        {
            return Enumerable.SequenceEqual(x.Toppings.OrderBy(t => t), y.Toppings.OrderBy(t => t));
        }

        public  int GetHashCode(Pizza x)
        {
            unchecked
            {
                int hash = 19;
                foreach (var topping in x.Toppings.OrderBy( t=> t))
                {
                    hash = hash * 31 + topping.GetHashCode();
                }
                return hash;
            }
        }
    }
}