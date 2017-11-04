using System;
using NUnit.Framework;
using PizzaExercise.Controllers;
using PizzaExercise.Persistence;
using PizzaExercise.Test.Stores;
using System.Linq;
using PizzaExercise.Models;
using PizzaExercise.Business;

namespace PizzaExercise.Test
{
    [TestFixture]
    public class UnitTest1
    {
        private IPizzaStore store;

        [SetUp]
        public void Initialize()
        {
            store = new FakePizzaStore();
        }

        [Test]
        public void WhenGetPizzasFromUrl_MoreThanZero_Success()
        {
            var repository = new PizzaStore();
            var pizzas = repository.GetPizzas().ToList();

            Assert.Greater(pizzas.Count, 0);
        }

        [Test]
        public void WhenGetTop3Pizzas_Success()
        {
            var pizzas = store.GetPizzas();
            var pizzaBL = new PizzaBL();
            var statistics = pizzaBL.GetPizzaStatistics(pizzas);

            var topPizzas = statistics.Orders.OrderByDescending(p => p.Total).Take(3).ToList();
            var topPizzasRepository = ((FakePizzaStore)store).GetTop3Pizzas().ToList();

            CollectionAssert.AreEqual(topPizzas[0].Pizza.Toppings, topPizzasRepository[0].Toppings);
            CollectionAssert.AreEqual(topPizzas[1].Pizza.Toppings, topPizzasRepository[1].Toppings);
            CollectionAssert.AreEqual(topPizzas[2].Pizza.Toppings, topPizzasRepository[2].Toppings);
        }
    }
}
