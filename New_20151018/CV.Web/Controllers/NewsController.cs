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
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(string MetaTittle)
        {   
            // Lấy ra bài viết      
            var result = NewService.GetNewByMeta(MetaTittle);
            // Lấy ra categoryID của bài viết
            var x = result.CategoryID;

            var cate = NewCategoryService.GetById(x);
            var rs = new NewViewModel
            {
                Image = string.Format("{0}{1}", ConfigurationManager.AppSettings["Image_Host"], result.Image),
                Name = result.Name,
                Details = result.Details,
                MetaTittle = result.MetaTittle,
               
            };

            ViewBag.RelatedNews = NewService.ListNewRelated(result.ID).Select(i => new NewViewModel()
            {
                Image = string.Format("{0}{1}", ConfigurationManager.AppSettings["Image_Host"], i.Image),
                Name = i.Name,
                MetaTittle = i.MetaTittle,
                categoryMetaTitle = cate.MetaTittle
            });
           
            return View(rs);
        }
    }
}