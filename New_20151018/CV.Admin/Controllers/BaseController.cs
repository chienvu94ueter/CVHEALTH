using System.Web.Mvc;
using System.Web.Routing;
using CV.Admin.Models;

namespace CV.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[Common.Constant.UserSession];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                    new
                    {
                        controller = "Account",
                        action = "Login",

                    }
                ));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}