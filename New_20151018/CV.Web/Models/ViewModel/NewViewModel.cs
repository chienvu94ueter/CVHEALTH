﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Web.Models.ViewModel
{
    public class NewViewModel
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string categoryMetaTitle { get; set; }

        public string categoryName { get; set; }

        public string MetaTittle { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public long? CategoryID { get; set; }

        public string Details { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }

        public string Tags { get; set; }

        public string Language { set; get; }
    }
}