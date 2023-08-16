using HotelH2.DataAccessLayer;
using HotelH2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelH2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RoomsDB roomsDB = new();
            List<Room> rooms = roomsDB.getRooms();
            rooms.Sort((a, b) => a.price.CompareTo(b.price));

            return View(rooms);
        }

        public IActionResult OnPostA()
        {
            String id = Request.Form["id"];
            Console.WriteLine("amkmono");
            return RedirectToAction("Privacy");
        }

        public IActionResult test()
        {
            Console.WriteLine("hello");

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        { 
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}