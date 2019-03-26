using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using DAL;

namespace BLL
{
    public class TieZiBLL : ITieZiBLL
    {
        private ITieZiDAL tieZiDAL;
        public TieZiBLL()
        {
            tieZiDAL = new TieZiDAL();
        }
        public IQueryable<TieZi> GetAllByBanKuaiId(int id)
        {
            return tieZiDAL.GetAllByBanKuaiId(id);
        }
    }
}
