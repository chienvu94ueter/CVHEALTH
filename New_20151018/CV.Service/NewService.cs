using System.Collections.Generic;
using System.Linq;
using CV.Data;
using CV.Entity.Table;
using PagedList;

namespace CV.Service
{
    public class NewService
    {
        public static News Add(News item)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.Add(item);
            }
        }
        public static News Update(News item)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.Update(item);
            }
        }
        public static bool Delete(News item)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.Delete(item);
            }
        }
        public static News GetById(long newId)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.Find(s => s.ID == newId);
            }
        }
        public static IEnumerable<News> GetAllNew( int page, int pageSize)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.GetAll().OrderBy(x=>x.ID).ToPagedList(page,pageSize);
            }
        }
        public static List<News> GetNewByCategry(long id)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.FindAll(s => s.CategoryID == id).ToList();
            }
        }

        public static News GetNewByMeta(string MetaTittle)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewRepository.Find(s => s.MetaTittle == MetaTittle);
            }
        }

        public static List<News> ListNewRelated(long id)
        {
            using (var uow = new UnitOfWork())
            {
                var news = uow.NewRepository.Find(s => s.ID == id);
                return uow.NewRepository.FindAll(s => s.ID != id && s.CategoryID == news.CategoryID).ToList();
            }
        }
    }
}
