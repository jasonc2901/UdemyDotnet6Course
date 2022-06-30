using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PizzaController : Controller
    {
        public static List<PizzaModel> _fakePizzaDb = new List<PizzaModel>() 
        { 
            new PizzaModel()
            {
                PizzaName = "Pepperoni",
                ImageTitle = "Pepperoni",
                BasePrice = 2,
                FinalPrice = 10,
                Cheese = true,
                TomatoSauce = true,
                Pepperoni = true,
                Mushrooms = false,
                Pineapple = false,
                Tuna = false,
            },
            new PizzaModel()
            {
                PizzaName = "MeatFeast",
                ImageTitle = "MeatFeast",
                BasePrice = 2,
                FinalPrice = 10,
                Cheese = true,
                TomatoSauce = true,
                Pepperoni = true,
                Mushrooms = true,
                Pineapple = false,
                Tuna = false,
            }
        };

        public IActionResult Index()
        {
            return View(_fakePizzaDb);
        }

        public IActionResult Custom()
        {
            return View();
        }

        public IActionResult SaveCustomPizza(PizzaModel pizza)
        {
            pizza.FinalPrice = pizza.BasePrice;

            if (pizza.Cheese) pizza.FinalPrice += 1;
            if (pizza.Tuna) pizza.FinalPrice += 1;
            if (pizza.TomatoSauce) pizza.FinalPrice += 1;
            if (pizza.Mushrooms) pizza.FinalPrice += 1;
            if (pizza.Pineapple) pizza.FinalPrice += 1;
            if (pizza.Pepperoni) pizza.FinalPrice += 1;

            return RedirectToAction("Index", "Checkout", pizza);
        }
    }
}
