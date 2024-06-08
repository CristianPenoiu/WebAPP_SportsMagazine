using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces
{
    public interface IRecenzii
    {
        List<Recenzie> GetAllRecenzii();
        void CreateRecenzie(Recenzie recenzie);
    }
}
