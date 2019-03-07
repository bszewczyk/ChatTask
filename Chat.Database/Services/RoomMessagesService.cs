using Chat.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Database.Services
{
    public class RoomMessagesService : DbService
    {
        public RoomMessagesService(): base()
        {

        }
        public string GetRoomNameById(int roomId)
        {
            return _dbContext.Messages.Where(x => x.RoomId == roomId).Select(x => x.Room.RoomName).FirstOrDefault();
        }
        public List<RoomMessage> GetRecentMessagesByRoom(int roomId)
        {
            return _dbContext.Messages.Where(x => x.RoomId == roomId)
                             .OrderByDescending(x => x.SendTime).Take(30).ToList();
        }
        public List<RoomMessage> GetNewMessagesByRoom(int roomId, DateTime lastRefresh)
        {
            return _dbContext.Messages.Where(x => x.RoomId == roomId).Where(x=>x.SendTime>lastRefresh)
                             .OrderByDescending(x => x.SendTime).Take(30).ToList();
        }
        public void SaveMessage(string message, string userName, int roomId)
        {
            var roomMessage = new RoomMessage(userName,message,roomId);
            _dbContext.Messages.Add(roomMessage);
            _dbContext.SaveChanges();
        }
    }
}
