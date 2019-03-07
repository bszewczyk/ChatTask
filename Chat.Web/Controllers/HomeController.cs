using Chat.Database;
using Chat.Database.DTO;
using Chat.Database.Services;
using Chat.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chat.Web.Controllers
{

    public class HomeController : Controller
    {
        RoomsService _roomService;
        public HomeController()
        {
            _roomService = new RoomsService();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserVM user)
        {

            Session["UserName"] = user.UserName;
            return RedirectToAction("Index");

        }
        public ActionResult Index()
        {
            var rooms = _roomService.GetAllRooms();
            return View(rooms);
        }
        public JsonResult AddRoom(Room room)
        {

            _roomService.AddRoom(room);
            return Json("ok");

        }


    }
}