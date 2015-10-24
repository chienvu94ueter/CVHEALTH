using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CV.Entity.Table;

namespace CV.Web.Models.ViewModel
{
    public class CategoryViewModel
    {
        public NewCategory cate { get; set; }
        public List<NewViewModel> news { get; set; }
    }
}