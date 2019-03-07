using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Database.Services
{
   public class DbService
    {
        protected ChatDBContext _dbContext;
        public DbService()
        {
            _dbContext = new ChatDBContext();
        }

    }
}
