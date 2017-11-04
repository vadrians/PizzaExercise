using PizzaExercise.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaExercise.Models;

namespace PizzaExercise.Test.Stores
{
    public class FakePizzaStore : IPizzaStore
    {
        public IEnumerable<Pizza> GetPizzas()
        {
            var pizzas = new List<Pizza>();

            pizzas.Add(new Pizza() { Toppings = new string[] { "pepperoni" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "mozzarela" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "pepperoni" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "pepperoni" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "pepperoni", "ham" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "sausage", "ham" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "sausage", "green pepper" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "mozzarela" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "mozzarela" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "sausage", "green pepper" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "tomato" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "pepperoni" } });

            return pizzas;
        }

        public IEnumerable<Pizza> GetTop3Pizzas()
        {
            var pizzas = new List<Pizza>();

            pizzas.Add(new Pizza() { Toppings = new string[] { "pepperoni" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "mozzarela" } });
            pizzas.Add(new Pizza() { Toppings = new string[] { "sausage", "green pepper" } });

            return pizzas;
        }

    }
}
