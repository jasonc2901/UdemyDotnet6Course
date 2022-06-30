using Microsoft.AspNetCore.Mvc;
using UdemyCourse_FirstApp.Models;

namespace UdemyCourse_FirstApp.Controllers
{
    public class Assignment1Controller : Controller
    {
        public IActionResult HotelBookingDetails()
        {
            return View(new HotelBooking()
            {
                Id = 1,
                GuestName = "Jason Caughers",
                DateStart = DateTime.Now,
                DateEnd = DateTime.Now.AddDays(1),
            });
        }
    }
}
