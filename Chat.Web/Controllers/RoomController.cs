using Chat.Database.Services;
using Chat.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Chat.Web.Controllers
{
    public class RoomController : Controller
    {
        RoomMessagesService _roomService;
        public RoomController()
        {
            _roomService = new RoomMessagesService();

        }
        public ActionResult Index(int roomId)
        {
            var roomMessages = _roomService.GetRecentMessagesByRoom(roomId);
            var roomName = _roomService.GetRoomNameById(roomId);
            var roomVM = new RoomMessageVM(roomMessages, roomName, Session["UserName"].ToString(), roomId);
            return View(roomVM);
        }
        [HttpGet]
        public async Task<ActionResult> GetMessages(int roomId)
        {
            var roomMessages = _roomService.GetRecentMessagesByRoom(roomId);
            return PartialView("_History", roomMessages);
        }
        public JsonResult SaveMessage(string message, int roomId)
        {
            _roomService.SaveMessage(message, Session["UserName"].ToString(), roomId);
            return Json("ok");
        }

    }
}