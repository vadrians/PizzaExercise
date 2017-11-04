using PizzaExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaExercise.Business
{
    public class PizzaBL
    {
        public PizzaStatisticViewModel GetPizzaStatistics(IEnumerable<Pizza> pizzas)
        {
            var statistics = new PizzaStatisticViewModel();
            var comparer = new PizzaComparer();
            var types = pizzas.GroupBy(p => p, comparer).Select(g => new { Pizza = g.Key, Count = g.Count() }).ToList();
            //pizzas.SelectMany(p => p.Toppings).GroupBy(p => p).Select(p => new { pizza = p.Key, count = p.Count() })

            foreach (var type in types)
            {
                statistics.Orders.Add(new PizzaStatisticViewModel.PizzaOrder()
                {
                    Pizza = type.Pizza,
                    Total = type.Count
                });
            }

            statistics.PizzasCount = pizzas.Count();


            return statistics;
        }
    }
}