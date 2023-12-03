using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class LichChieuPhimServices : ILichChieuPhimServices
    {
        private readonly IRepository<LichchieuphimModels> _repository;
        public LichChieuPhimServices(IRepository<LichchieuphimModels> repository)
        {
            _repository = repository;
        }
        public async Task Add(LichchieuphimModels ctdatve)
        {
             await _repository.Create(ctdatve);
        }

        public async Task Delete(string id)
        {
            await _repository.Delete(id);
        }

        public async Task<IEnumerable<LichchieuphimModels>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<LichchieuphimModels> GetById(string id)
        {
            return await _repository.GetById(id);
        }
        public async Task Update(string id, LichchieuphimModels ctdatve)
        {
            await _repository.Update(id, ctdatve);
        }
    }
}
