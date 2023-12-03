using WebCinema.Entities;
using WebCinema.Models;

namespace WebCinema.Services
{
    public interface IPhongServices
    {
        Task<IEnumerable<PhongModels>> GetAll();
        Task<PhongModels> GetById(string id);
        Task Add(PhongModels Phong);
        Task Update(string id, PhongModels Phong);
        Task Delete(string id);

        //Bonuss
        Task AddGheByPhong(PhongModels phong);
        
    }
}
