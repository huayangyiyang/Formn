using BLL;
using IBLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class IndexController : Controller
    {
        private IIndexBLL indexBLL = new IndexBLL();
        private IPartitionBLL partBLL = new PartitionBLL();       
        // GET: Index
        /// <summary>
        /// 展示首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //获得板块
            
            Partition part = new Partition();
            //获得板块版主
            

            return View(partBLL.GetAll(part).ToList());
        }

        public ActionResult Detail(int? Id)
        {
            BanKuai bankuai = new BanKuai();
            //indexBLL.
            return View();
        }
    }
}