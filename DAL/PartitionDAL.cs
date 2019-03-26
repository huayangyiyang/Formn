using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class PartitionDAL : IPartitionDAL
    {
        private MyForumEntities db = new MyForumEntities();
        public IQueryable<Partition> GetAll(Partition parttion)
        {
            return db.Partition;
        }
    }
}
