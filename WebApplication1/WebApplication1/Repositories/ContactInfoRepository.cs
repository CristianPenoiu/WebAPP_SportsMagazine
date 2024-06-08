using WebApplication1.Repositories.Interfaces;
using WebApplication1.Models;
using System.Linq;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Repositories
{
    public class ContactInfoRepository : RepositoryBase<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(WebSportsAppDbContext context)
            : base(context)
        { 
        }
    }
}
