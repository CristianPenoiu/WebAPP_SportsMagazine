using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;

namespace WebApplication1.Services.Interfaces
{
    public class RecenzieService : IRecenzii
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RecenzieService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void CreateRecenzie(Recenzie recenzie)
        {
            _repositoryWrapper.RecenziiRepository.Create(recenzie);
            _repositoryWrapper.RecenziiRepository.Save();
        }

        public List<Recenzie> GetAllRecenzii()
        {
            var allRecenzii = _repositoryWrapper.RecenziiRepository.FindAll().ToList();
            return allRecenzii;
        }

    }
}