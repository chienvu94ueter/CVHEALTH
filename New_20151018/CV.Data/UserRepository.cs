using CV.Data;
using CV.Entity;
using CV.Entity.Table;

namespace CV.Data
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(CVDbContext context) : base(context)
        {
        }
    }
}
