using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
  public  interface IIndexBLL
    {
        /// <summary>
        /// 获取所有的板块
        /// </summary>
        /// <param name="bankuai"></param>
        /// <returns></returns>
        IQueryable<BanKuai> GetAll(BanKuai bankuai);
    }
}
