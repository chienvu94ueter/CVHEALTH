using CV.Data;
using CV.Entity.Table;

namespace CV.Service
{
    public class UserSevice
    {
        public static User Login(string userName, string password)
        {
            using (var uow = new UnitOfWork())
            {
                var user = uow.UserRepository.Find(s => s.UserName.ToLower() == userName.ToLower() && s.Password == password);
                return user ?? null;
            }
        }

        public static User GetUser(string username, string password)
        {
            using (var uow = new UnitOfWork())
            {
                var user = uow.UserRepository.Find(s => s.UserName == username && s.Password == password);
                return user ?? null;
            }
        }
    }
}
