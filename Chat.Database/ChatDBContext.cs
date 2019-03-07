using Chat.Database.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Database
{
    public class ChatDBContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomMessage> Messages { get; set; }
        public ChatDBContext() : base("name=ChatDBContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            System.Data.Entity.Database.SetInitializer<ChatDBContext>(new DropCreateDatabaseIfModelChanges<ChatDBContext>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
