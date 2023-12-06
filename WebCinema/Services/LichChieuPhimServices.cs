using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class LichChieuPhimServices : MyRepository<Lichchieuphim>
    {
        private readonly web_cinema3Context context_;
        public LichChieuPhimServices(web_cinema3Context context) : base(context) 
        {
            context_ = context;
        }
    }
}
