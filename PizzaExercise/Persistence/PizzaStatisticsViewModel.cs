using PizzaExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaExercise.Persistence
{
    public class PizzaStatisticsViewModel
    {
        public Dictionary<Pizza, int> TopPizzas { get; set; } = new Dictionary<Pizza, int>();
        public int TotalPizzasCount { get; set; }
    }
}