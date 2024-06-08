using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;
namespace WebApplication1.Repositories
{
    public class RecenziiRepository : RepositoryBase<Recenzie>, IRecenziiRepository
    {
        public RecenziiRepository(WebSportsAppDbContext context)
            : base(context)
    {
    }
}
}
