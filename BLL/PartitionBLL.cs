using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class PartitionBLL : IPartitionBLL
    {
        private IPartitionDAL partDAL ;
        public PartitionBLL()
        {
            partDAL = new PartitionDAL();
        }

        public IQueryable<Partition> GetAll(Partition parttion)
        {
            return partDAL.GetAll(parttion);
        }
    }
}
