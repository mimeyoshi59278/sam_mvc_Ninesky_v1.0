using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ninesky.Website.Areas.Config.Controllers
{
    /// <summary>
    /// 主界面
    /// <remarks>
    /// 创建：2014.12.13
    /// 修改：2014.12.16
    /// </remarks>
    /// </summary>
    [AdminAuthorize]
    public class HomeController : Controller
    {
        // GET: Config/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}