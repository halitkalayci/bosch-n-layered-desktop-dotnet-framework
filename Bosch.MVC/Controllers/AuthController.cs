using Business.Abstracts;
using Business.Concretes;
using Business.Request.User;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Bosch.MVC.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private IUserService _userService;

        public AuthController()
        {
            IUserDal userDal = new EfUserDal();
            _userService = new UserManager(userDal);
        }

        public ActionResult Login(string returnUrl, string errorMessage="")
        {
            ViewBag.ErrorMessage = errorMessage;
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(GetCustomerByUsernameAndPasswordRequest request)
        {
            var user = _userService.GetUserByUsernameAndPassword(request);
            if (user == null)
            {
                return RedirectToAction("Login",new {returnUrl=request.ReturnUrl ,errorMessage="Girilen bilgiler hatalıdır lütfen kontrol ediniz."});
            }
            FormsAuthentication.SetAuthCookie(user.Username, false);
            // Authentication
            return Redirect(request.ReturnUrl);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}