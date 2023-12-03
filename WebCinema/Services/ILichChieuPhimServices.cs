using WebCinema.Models;

namespace WebCinema.Services
{
    public interface ILichChieuPhimServices
    {
        Task<IEnumerable<LichchieuphimModels>> GetAll();
        Task<LichchieuphimModels> GetById(string id);
        Task Add(LichchieuphimModels ctdatve);
        Task Update(string id, LichchieuphimModels ctdatve);
        Task Delete(string id);
    }
}
