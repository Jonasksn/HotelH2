using HotelH2.DataAccessLayer;
using HotelH2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelH2.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Details()
        {
            String id = Request.Form["id"].ToString() ?? "0";
            List<Room> rooms = new RoomsDB().getRooms();
            Room room = rooms.Where((element) => element.id == Int32.Parse(id)).ToArray().First();

            return View(room);
        }

        public IActionResult Book()
        {
            return View();
        }
        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}