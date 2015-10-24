using System.Web.Mvc;
using CV.Admin.Models;
using CV.Common;
using CV.Service;

namespace CV.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string passWord, bool? remmeberMe)
        {
            var result = UserSevice.Login(userName, Encryptor.MD5Hash(passWord));
            if (result != null)
            {
                var session = new UserLogin();

                session.UserName = result.UserName;
                session.UserId = result.ID;

                Session.Add(Common.Constant.UserSession, session);

                return RedirectToAction("Index", "Home");

            }

            return View();
        }
    }
}