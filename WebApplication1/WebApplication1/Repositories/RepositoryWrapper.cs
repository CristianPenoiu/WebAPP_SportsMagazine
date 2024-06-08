using WebApplication1.Repositories.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private WebSportsAppDbContext _context;
        private IContactInfoRepository? _contactInfoRepository;
        private IRecenziiRepository? _recenziiRepository;
        public IContactInfoRepository ContactInfoRepository
        {
            get
            {
                if (_contactInfoRepository == null)
                {
                    _contactInfoRepository = new ContactInfoRepository(_context);
                }
                return _contactInfoRepository;
            }
        }

        public IRecenziiRepository RecenziiRepository
        {
            get
            {
                if (_recenziiRepository == null)
                {
                    _recenziiRepository = new RecenziiRepository(_context);
                }
                return _recenziiRepository;
            }
        }


        public RepositoryWrapper(WebSportsAppDbContext context)
        {
            this._context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
