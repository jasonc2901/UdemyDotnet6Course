using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;

namespace WebApplication1.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CheckoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(PizzaModel pizza)
        {
            if(string.IsNullOrWhiteSpace(pizza.PizzaName))
            {
                pizza.PizzaName = "Custom Pizza";
            }

            if (string.IsNullOrWhiteSpace(pizza.ImageTitle))
            {
                pizza.ImageTitle = "Create";
            }
            
            return View(pizza);
        }

        public async Task<IActionResult> ThankYou(PizzaModel pizza)
        {
            //ADD ORDER TO DB
            PizzaOrderModel order = new PizzaOrderModel() { PizzaName = pizza.PizzaName, FinalPrice = pizza.FinalPrice };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            
            return View();
        }
    }
}
