using System;
using CV.Entity;


namespace CV.Data
{
    public class UnitOfWork : IDisposable
    {
        private readonly CVDbContext _context = new CVDbContext();

        private NewRepository _newRepository;
        private NewCategoryRepository _categoryRepository;
        private UserRepository _userRepository;


        public NewRepository NewRepository
        {
            get { return _newRepository ?? (_newRepository = new NewRepository(_context)); }
        }
        public NewCategoryRepository NewCategoryRepository
        {
            get { return _categoryRepository ?? (_categoryRepository = new NewCategoryRepository(_context)); }
        }
        public UserRepository UserRepository
        {
            get { return _userRepository ?? (_userRepository = new UserRepository(_context)); }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
