using System;
using System.Web.Mvc;
using CV.Entity.Table;
using CV.Service;

namespace CV.Admin.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index(int page = 1, int pageSize = 5)
        {
            var model = NewService.GetAllNew(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Category = NewCategoryService.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(string title, string metaTitle, string description, string detail,string categoryName, string categoryImage, DateTime categoryCreateDate)
        {
            var news = new News()
            {
                Name = title,
                Description = description,
                Image = categoryImage,
                Status = true,
                Details = detail,
                CreatedDate = categoryCreateDate,
                MetaTittle = metaTitle,
                CategoryID = NewCategoryService.GetByName(categoryName).ID
            };
            var create = NewService.Add(news);
            if (create != null)
                return RedirectToAction("Index", "New");
            return View();
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.Category = NewCategoryService.GetAll();
            var model = NewService.GetById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(long newsId, string title, string metaTitle, string description,string detail,string categoryName,string Image, DateTime newsCreateDate, bool? newStatus)
        {
            var news = NewService.GetById(newsId);
            //var category = new NewCategory()
            //{
            news.Name = title;
            news.MetaTittle = metaTitle;
            news.Description = description;
            news.Image = Image;
            news.CreatedDate = newsCreateDate;
            news.Details = detail;
            news.CategoryID = NewCategoryService.GetByName(categoryName).ID;
            if (newStatus.HasValue)
            {
                news.Status = true;
            }
            else
            {
                news.Status = false;
            }


            // };

            var edit = NewService.Update(news);
            if (edit != null)
                return RedirectToAction("Index", "New");
            return View();
        }
    }
}
