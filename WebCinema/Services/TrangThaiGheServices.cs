using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class TrangThaiGheServices : MyRepository<Trangthaighe>
    {
        private readonly web_cinema3Context _context;
        public TrangThaiGheServices(web_cinema3Context context) : base(context)
        {
            _context = context;
        }
        public async Task addTTGbyModels(TrangThaiGheModels trangThai)
        {
            var Ttg = new Trangthaighe
            {
                Maghe = trangThai.Maghe,
                MaPhong = trangThai.MaPhong,
                MaLichChieu = trangThai.MaLichChieu,
                TrangThai = trangThai.TrangThai,
            };
            _context.Add(Ttg);
            await _context.SaveChangesAsync();
        }
    }
}
