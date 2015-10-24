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
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var lstCate = new List<NewCategory>();
            var model = NewCategoryService.GetAll().ToList().Select(i => new NewCategory()
            {
                Image = string.Format("{0}{1}", ConfigurationManager.AppSettings["Image_Host"], i.Image),
                Name = i.Name,
                MetaTittle = i.MetaTittle,
                ID = i.ID

            });
            foreach (var item in model)
            {
                lstCate.Add(item);
            }
            return View(lstCate);
        }

        public ActionResult Detail(string MetaTittle)
        {
            // Lấy ra danh muc theo metaTitle
            var cate = NewCategoryService.GetByMeta(MetaTittle);
            // Lấy Id danh mục
            var id = cate.ID;

            // Lấy ra tên danh mục 
            var categoryName = cate.Name;

            // Lấy MetaTitle của danh mục
            var categoryMetaTittle = cate.MetaTittle;
            // lấy tất cả các bài viết thuộc danh mục đó
            var newsCate = NewService.GetNewByCategry(id).Select(i => new News
            {
                Image = string.Format("{0}{1}", ConfigurationManager.AppSettings["Image_Host"], i.Image),
                Name = i.Name,
                ID = i.ID,
                Description = i.Description,
                Details = i.Details,
                MetaTittle = i.MetaTittle
            });

          
            
            var lstNews = new List<NewViewModel>();
            
            foreach (var item in newsCate)
            {
                var viewModel = new NewViewModel();
                viewModel.Name = item.Name;
                viewModel.ID = item.ID;
                viewModel.MetaTittle = item.MetaTittle;
                viewModel.Image = item.Image;
                viewModel.categoryMetaTitle = categoryMetaTittle;
                lstNews.Add(viewModel);

            }

            ViewBag.CategoryName = categoryName;
            return View(lstNews);
        }
    }
}