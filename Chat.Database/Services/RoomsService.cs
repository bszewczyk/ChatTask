using Chat.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Database.Services
{
    public class RoomsService: DbService
    {
        public RoomsService(): base()
        {

        }
        public List<Room> GetAllRooms()
        {
            return _dbContext.Rooms.ToList();
        }
        public void AddRoom(Room room)
        {
            _dbContext.Rooms.Add(room);
            _dbContext.SaveChanges();
        }
    }
}
