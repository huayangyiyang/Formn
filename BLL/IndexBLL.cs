using DAL;
using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IndexBLL : IIndexBLL
    {
        private IIndexDAL indexDAL ;
       public IndexBLL()
        {
            indexDAL = new IndexDAL();
        }
        public IQueryable<BanKuai> GetAll(BanKuai bankuai)
        {
            return indexDAL.GetAll(bankuai);
        }
    }
}
