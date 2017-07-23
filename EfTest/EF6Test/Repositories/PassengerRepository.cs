using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Test.Repositories
{
    public class PassengerRepository
    {
        private readonly ApplicationDbContext dbContext;

        public PassengerRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
