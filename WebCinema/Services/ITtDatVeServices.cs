using WebCinema.Models;

namespace WebCinema.Services
{
    public interface ITtDatVeServices
    {
        Task<IEnumerable<TtdatveModels>> GetAll();
        Task<TtdatveModels> GetById(string id);
        Task Add(TtdatveModels ctdatve);
        Task Update(string id, TtdatveModels ctdatve);
        Task Delete(string id);
    }
}