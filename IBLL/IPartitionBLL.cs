using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
  public  interface IPartitionBLL
    {
        /// <summary>
        /// 获取所有的分区
        /// </summary>
        /// <param name="parttion"></param>
        /// <returns></returns>
        IQueryable<Partition> GetAll(Partition parttion);
    }
}
