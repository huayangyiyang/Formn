using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class IndexDAL : IIndexDAL
    {
        private MyForumEntities db = new MyForumEntities();
        public IQueryable<BanKuai> GetAll(BanKuai bankuai)
        {
            return db.BanKuai;
        }
    }
}
