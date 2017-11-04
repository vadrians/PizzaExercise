using PizzaExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaExercise.Persistence
{
    public interface IPizzaStore
    {
        IEnumerable<Pizza> GetPizzas();
    }
}