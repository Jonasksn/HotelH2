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
            rooms.Sort((a, b) => a.roomNum.CompareTo(b.roomNum));

            return View(rooms);
        }
        public IActionResult Login()
        {
            String user = Request.Form["user"]!;
            String pass = Request.Form["pass"]!;
            bool remember = Request.Form["remember"].ToString() == "on" ? true : false;

            /*TODO: login */

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        { 
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}