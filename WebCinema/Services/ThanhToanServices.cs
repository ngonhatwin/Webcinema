using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class ThanhToanServices : MyRepository<Thanhtoan>
    {
        private readonly web_cinema3Context _context;
        public ThanhToanServices(web_cinema3Context context) : base(context)
        {
            _context = context;
        }
        //public async Task AddAll(ThanhToanModels thanhToan )
        //{
        //    var th = new Thanhtoan
        //    { 
        //        MaDatVe = thanhToan.MaDatVe,
        //        MaNhanVien = thanhToan.MaNhanVien,
        //        MaThanhToan = thanhToan.MaThanhToan,
        //        NgayThanhToan = thanhToan.NgayThanhToan,
        //        Phuongthucthanhtoan = thanhToan.Phuongthucthanhtoan,
        //    };
        //    _context.Add(th);

        //    var ttdv = new Ttdatve
        //    {
        //        MaDatVe = thanhToan.MaDatVe,
        //        MaLichPhim = (from lc in _context.Lichchieuphims where);
        //    };

        //}
    }
}
