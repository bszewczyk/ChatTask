using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Database.DTO
{
    public class RoomMessage
    {
        public int RoomMessageId { get; set; }
        public DateTime SendTime { get; set; }
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public int  RoomId { get; set; }
        public Room Room { get; set; }
        public RoomMessage(string userName, string messegeText, int roomId)
        {
            SendTime = DateTime.Now;
            UserName = userName;
            MessageText = messegeText;
            RoomId = roomId;
        }
        public RoomMessage()
        {

        }
    }
}
