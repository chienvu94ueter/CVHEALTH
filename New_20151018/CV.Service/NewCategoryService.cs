using System.Collections.Generic;
using System.Linq;
using CV.Entity.Table;
using CV.Data;


namespace CV.Service
{
    public class NewCategoryService
    {
        public static NewCategory Add(NewCategory item)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.Add(item);
            }
        }

        public static List<NewCategory> GetAll()
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.GetAll().ToList();
            }
        }

        public static NewCategory Update(NewCategory item)
        {

            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.Update(item);
            }
        }
        public static bool Delete(NewCategory item)
        {

            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.Delete(item);
            }
        }
        public static NewCategory GetById(long? id)
        {

            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.Find(s => s.ID == id);
            }
        }

        public static NewCategory GetByMeta(string meta)
        {

            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.Find(s => s.MetaTittle == meta);
            }
        }
        public static NewCategory GetByName(string categoryName)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.Find(s => s.Name.Trim().ToLower().Contains(categoryName.Trim().ToLower()));
            }
        }
        public static List<NewCategory> GetCategoryForHomepage(int length)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.NewCategoryRepository.GetAll().OrderByDescending(s => s.CreatedDate).Take(length).ToList();
            }
        }

    }
}
