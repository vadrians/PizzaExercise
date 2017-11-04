using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaExercise.Models
{
    public class PizzaStatisticViewModel
    {
        public int PizzasCount { get; set; }
        public IList<PizzaOrder> Orders { get; set; } = new List<PizzaOrder>();

        public class PizzaOrder
        {
            public Pizza Pizza { get; set; }
            public int Total { get; set; }
        }
    }
}