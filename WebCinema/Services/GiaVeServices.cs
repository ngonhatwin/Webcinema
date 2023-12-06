using WebCinema.Entities;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class GiaVeServices : MyRepository<Giave>
    {
        private readonly web_cinema3Context _context;
        public GiaVeServices(web_cinema3Context context) : base(context)
        {
            _context = context;
        }
    }
}
