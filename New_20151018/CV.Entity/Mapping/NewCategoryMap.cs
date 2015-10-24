using System.Data.Entity.ModelConfiguration;
using CV.Entity.Table;

namespace CV.Entity.Mapping
{
    public class NewCategoryMap : EntityTypeConfiguration<NewCategory>
    {
        public NewCategoryMap()
        {
            HasKey(s => s.ID);
            ToTable("NewCategory");
        }
    }
}
