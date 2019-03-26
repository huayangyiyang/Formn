using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class TieZiDAL : ITieZiDAL
    {
        private MyForumEntities db = new MyForumEntities();
        public IQueryable<TieZi> GetAllByBanKuaiId(int id)
        {
          return  db.TieZi.Where(t => t.BanKuaiId == id);
        }
    }
}
