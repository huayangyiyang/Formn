using BLL;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TieZiController : Controller
    {
        private ITieZiBLL tieziBll = new TieZiBLL();
        /// <summary>
        /// 帖子列表
        /// </summary>
        /// <returns></returns>
        // GET: TieZi
        public ActionResult List(int id)
        {
           // tieziBll.GetAllByBanKuaiId(id);
            return View(tieziBll.GetAllByBanKuaiId(id).ToList());
        }
    }
}