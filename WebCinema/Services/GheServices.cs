using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class GheServices : MyRepository<Ghe> 
    {
        private readonly web_cinema3Context _context;
        public GheServices(web_cinema3Context context) : base(context)
        {
            _context = context;
        }
        public async Task AddGheByID(GheModels ghe)
        {
            var gh = new Ghe{
                MaGhe = ghe.MaGhe,
                TenGhe = ghe.TenGhe,
                MaPhong = ghe.MaPhong,
            };
            _context.Add(gh);
            await _context.SaveChangesAsync();
        }
    }
}
