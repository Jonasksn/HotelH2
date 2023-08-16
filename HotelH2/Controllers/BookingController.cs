using HotelH2.DataAccessLayer;
using HotelH2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelH2.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}