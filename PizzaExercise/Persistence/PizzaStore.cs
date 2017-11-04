using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaExercise.Models;
using System.Net;
using Newtonsoft.Json;

namespace PizzaExercise.Persistence
{
    public class PizzaStore : IPizzaStore
    {
        private const string urlJson = "http://files.olo.com/pizzas.json";
        public IEnumerable<Pizza> GetPizzas()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(urlJson);
                return JsonConvert.DeserializeObject<IEnumerable<Pizza>>(json);
            }
        }
    }
}