using System.Data.Entity.ModelConfiguration;
using CV.Entity.Table;


namespace CV.Entity.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(s => s.ID);
            ToTable("User");
        }
    }
}