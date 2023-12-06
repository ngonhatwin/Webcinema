using System.Drawing.Text;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class TheLoaiServices : MyRepository<Theloai>
    {
        private readonly web_cinema3Context _context;
        public TheLoaiServices(web_cinema3Context context) : base(context) 
        {
            _context = context;
        }
    }
}
