using System;

namespace CV.Entity.Table
{
    public class NewCategory
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string MetaTittle { get; set; }

        public string Description { set; get; }

        public string Image { set; get; }

        public long? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public string SeoTittle { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public bool? ShowOnHome { get; set; }

        public string Language { get; set; }
    }
}
