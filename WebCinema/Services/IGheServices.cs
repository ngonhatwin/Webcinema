using WebCinema.Models;

namespace WebCinema.Services
{
    public interface IGheServices
    {
        Task<IEnumerable<GheModels>> GetAll();
        Task<GheModels> GetById(string id);
        Task Add(GheModels Ghe);
        Task Update(string id, GheModels Ghe);
        Task Delete(string id);
    }
}
