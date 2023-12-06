using WebCinema.Entities;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class NguoiDungServices : MyRepository<Nguoidung>
    {
        private readonly web_cinema3Context context_;

        public NguoiDungServices(web_cinema3Context context) : base(context)
        {
            context_ = context;
        }
    }
    
}
