using Chat.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Web.Models
{
    public class RoomMessageVM
    {
        public List<RoomMessage> RoomMessages { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string LoggedUserName { get; set; }
        public RoomMessageVM(List<RoomMessage> roomMessages, string roomName, string loggedUser, int roomId)
        {
            RoomId = roomId;
            RoomMessages = roomMessages;
            RoomName = roomName;
            LoggedUserName = loggedUser;

        }
    }
}