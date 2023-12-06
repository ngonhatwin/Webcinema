using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class TtDatVeServices : MyRepository<Ttdatve>
    {
        private readonly web_cinema3Context _context;
        public TtDatVeServices(web_cinema3Context context) : base(context) 
        {
            _context = context;
        }
    }
    
}
