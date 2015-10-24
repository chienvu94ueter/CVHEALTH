using System.Data.Entity;
using CV.Entity.Mapping;
using CV.Entity.Table;



namespace CV.Entity
{
    public class CVDbContext : DbContext
    {
        static CVDbContext()
        {
            Database.SetInitializer<CVDbContext>(null);
        }

        public CVDbContext() : base("Name=CVDbContext")
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<NewCategory> NewCategorys { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NewMap());
            modelBuilder.Configurations.Add(new NewCategoryMap());
            modelBuilder.Configurations.Add(new UserMap());

        }
    }
}
