using CV.Data;
using CV.Entity;
using CV.Entity.Table;

namespace CV.Data
{
    public class NewRepository : Repository<News>
    {
        public NewRepository(CVDbContext context) : base(context)
        {
        }
    }
}
