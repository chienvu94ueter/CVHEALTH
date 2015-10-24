using System.Data.Entity.ModelConfiguration;
using CV.Entity.Table;

namespace CV.Entity.Mapping
{
    public class NewMap : EntityTypeConfiguration<News>
    {
        public NewMap()
        {
            HasKey(s => s.ID);
            ToTable("News");
        }
    }
}
