//using Microsoft.EntityFrameworkCore;
//using WebCinema.Entities;
//using WebCinema.Models;

//namespace WebCinema.Repository
//{
//    public class TheLoaiRepository : IRepository<TheloaiModels>
//    {
//        private readonly web_cinema3Context context_;
//        public TheLoaiRepository(web_cinema3Context context)
//        {
//            context_ = context;
//        }
//        public async Task Create(TheloaiModels entity)
//        {
//            var TheLoai = new Theloai
//            {
//                MaTl = entity.MaTl,
//                TenTl = entity.TenTl,
//            };
//            context_.Add(TheLoai);
//            await context_.SaveChangesAsync();
//        }

//        public async Task Delete(string id)
//        {
//            var theloai = (from tl in context_.Theloais where tl.MaTl == id select tl).FirstOrDefault();   
//            if( theloai != null)
//            {
//                context_.Remove(theloai);
//            }    
//             await context_.SaveChangesAsync();
//        }

//        public async Task<IEnumerable<TheloaiModels>> GetAll()
//        {
//            var theloai = await context_.Theloais.ToListAsync();
//            return theloai.Select(tl => new TheloaiModels
//            { 
//                MaTl = tl.MaTl,
//                TenTl = tl.TenTl,
//            });
//        }

//        public async Task<TheloaiModels> GetById(string id)
//        {
//            var theloai = await (from tl in context_.Theloais where tl.MaTl == id select tl).FirstOrDefaultAsync();
//            if(theloai != null)
//            {
//                return  new TheloaiModels
//                {
//                    MaTl = theloai.MaTl,
//                    TenTl = theloai.TenTl,
//                } ;
//            }
//            return null;
//        }

//        public async Task Update(string id, TheloaiModels entity)
//        {
//            var theloai =await (from tl in context_.Theloais where tl.MaTl == id select tl).FirstOrDefaultAsync();
//            if (theloai != null)
//            {
//                theloai.TenTl = entity.TenTl;
//                theloai.MaTl = entity.MaTl;
//            }
//        }
//    }
//}
