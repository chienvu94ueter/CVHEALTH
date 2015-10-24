using System;
using System.Diagnostics.Eventing.Reader;
using System.Web.Mvc;
using CV.Entity.Table;
using CV.Service;

namespace CV.Admin.Controllers
{
    public class NewCategoryController : BaseController
    {
        // GET: NewCategory
        public ActionResult Index()
        {

            return View(NewCategoryService.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(string categoryName, string metaTitle, string description, string categoryImage, DateTime categoryCreateDate)
        {
            var category = new NewCategory()
            {
                Name = categoryName,
                MetaTittle = metaTitle,
                Description = description,
                Image = categoryImage,
                CreatedDate = categoryCreateDate,
               Status = true
            };
          
            var create = NewCategoryService.Add(category);
            if (create != null)
                return RedirectToAction("Index", "NewCategory");
            return View();
        }

        public ActionResult Detail(long id)
        {
            var model = NewCategoryService.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var model = NewCategoryService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(long categoryId,string categoryName, string metaTitle, string description, string categoryImage, DateTime categoryCreateDate, bool? categoryStatus)
        {
            var category = NewCategoryService.GetById(categoryId);
            //var category = new NewCategory()
            //{
            category.Name = categoryName;
            category.MetaTittle = metaTitle;
            category.Description = description;
            category.Image = categoryImage;
            category.CreatedDate = categoryCreateDate;
            if (categoryStatus.HasValue)
            {
                category.Status = true;
            }
            else
            {
                category.Status = false;
            }
            
           
           // };

            var edit = NewCategoryService.Update(category);
            if (edit != null)
                return RedirectToAction("Index", "NewCategory");
            return View();
        }
    }
}