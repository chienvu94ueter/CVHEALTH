using CV.Data;
using CV.Entity;
using CV.Entity.Table;

namespace CV.Data
{
    public class NewCategoryRepository : Repository<NewCategory>
    {
        public NewCategoryRepository(CVDbContext context) : base(context)
        {
        }
    }
}
