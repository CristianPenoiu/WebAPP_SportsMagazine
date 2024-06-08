using WebApplication1.Models;

namespace WebApplication1.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IContactInfoRepository ContactInfoRepository { get; }
        IRecenziiRepository RecenziiRepository { get; }
        void Save();
    }
}
