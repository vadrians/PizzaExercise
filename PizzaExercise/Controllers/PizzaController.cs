using PizzaExercise.Business;
using PizzaExercise.Models;
using PizzaExercise.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaExercise.Controllers
{
    public class PizzaController : Controller
    {
        private IPizzaStore store;
        public PizzaController() : this(new PizzaStore()) { }
        public PizzaController(IPizzaStore s)
        {
            store = s;
        }
        public ActionResult Index()
        {
            var pizzaBL = new PizzaBL();
            var model = pizzaBL.GetPizzaStatistics(store.GetPizzas());
            model.Orders = model.Orders.OrderByDescending(p => p.Total).Take(20).ToList();
            return View(model);
        }
    }
}