using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Database.DTO
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }

        public List<RoomMessage> Messages { get; set; }
    }
}
