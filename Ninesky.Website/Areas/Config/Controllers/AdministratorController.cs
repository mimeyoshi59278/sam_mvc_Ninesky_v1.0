using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninesky.User;
using Ninesky.Data.Security;

namespace Ninesky.Website.Areas.Config.Controllers
{
    /// <summary>
    /// 管理员控制器
    /// <remarks>
    /// 创建：2014.12.13
    /// </remarks>
    /// </summary>
    [AdminAuthorize]
    public class AdministratorController : Controller
    {
        private AdministratorService _adminService = new AdministratorService(ContextFactory.GetCurrentContext());



        // 登陆
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken()]
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Models.LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                var _admin = _adminService.Find(a => a.Account == loginVM.Account);
                if (_admin == null) ModelState.AddModelError("Account", "账号不存在");
                else if (Encryption.Sha256(loginVM.Password) != _admin.Password) ModelState.AddModelError("Password", "密码不正确");
                else 
                {
                    _admin.LoginTime = System.DateTime.Now;
                    _admin.LoginIp = Request.UserHostAddress;
                    _adminService.Update(_admin);
                    Session.Add("Account", loginVM.Account);
                    Session.Add("Password", _admin.Password);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(loginVM);
        }
    }
}