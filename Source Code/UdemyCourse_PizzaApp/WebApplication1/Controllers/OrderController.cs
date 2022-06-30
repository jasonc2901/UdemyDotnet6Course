using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _context.Orders.Select(o => new PizzaOrderModel()
            {
                Id = o.Id,
                FinalPrice = o.FinalPrice,
                PizzaName = o.PizzaName
            }).ToListAsync();

            return View(orders);
        }
    }
}
