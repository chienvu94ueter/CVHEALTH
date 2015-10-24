using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Entity.Table;
using CV.Service;
using CV.Web.Models.ViewModel;

namespace CV.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        [ChildActionOnly]
        public PartialViewResult MainContentPartial()
        {
            var cate = NewCategoryService.GetCategoryForHomepage(4);
            var viewModel = new List<CategoryViewModel>();
            
            foreach (var item in cate)
            {
                var lstnews = new List<NewViewModel>();
                var news = NewService.GetNewByCategry(item.ID).ToList().Take(4).Select(i => new NewViewModel()
                {
                    Image = string.Format("{0}{1}", ConfigurationManager.AppSettings["Image_Host"] , i.Image),
                    Description = i.Description,
                    Name = i.Name,
                    MetaTittle = i.MetaTittle,
                    categoryMetaTitle = item.MetaTittle
                });
             
                foreach (var a in news)
                {
                    lstnews.Add(a);
                }
                var x = new CategoryViewModel()
                {
                    cate = item,
                    news = lstnews
                };
                viewModel.Add(x);
            }
            return PartialView(viewModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}