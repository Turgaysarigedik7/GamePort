using Gameport.Business.Abstract;
using Gameport.Core.CrossCuttingConcerns.Security.Web;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Controllers
{
    [RequireHttps]
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Account
        [HttpGet]
        public ActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SingIn(string userName,string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if (user!=null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(),
                    user.UserName,
                    user.Email,
                    DateTime.Now.AddDays(15),
                    _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(),
                    false
                  );
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        [HttpGet]
        public ActionResult SingUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SingUp(string email,string userName,string password)
        {
            if (email!=null && userName!=null && password!=null)
            {
                _userService.Add(new User { Email = email, UserName = userName, Password = password });
                return RedirectToAction("SingIn", "Account");
            }
            return View();
        }
    }
}