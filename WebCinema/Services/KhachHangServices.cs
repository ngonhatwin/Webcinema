using WebCinema.Entities;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class KhachHangServices : MyRepository<Khachhang>
    {
        private readonly web_cinema3Context _context;
        public KhachHangServices(web_cinema3Context context) : base(context)
        {
            _context = context;
        }
    }
}
