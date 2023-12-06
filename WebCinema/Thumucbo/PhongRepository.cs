//using Microsoft.EntityFrameworkCore;
//using WebCinema.Entities;
//using WebCinema.Models;

//namespace WebCinema.Repository
//{
//    public class PhongRepository : MyRepository<PhongModels>
//    {
//        private readonly web_cinema3Context context_;
//        public PhongRepository(web_cinema3Context context)
//        {
//            context_ = context;
//        }
//        public async Task Create(PhongModels entity) 
//        {
//            var Phong = new Phong
//            {
//                TenPhong = entity.TenPhong,
//                MaPhong = entity.MaPhong,
//                SoChoNgoi = entity.SoChoNgoi,
//                SoHang = entity.SoHang,
//                Socot = entity.Socot,
//            };
//            for (int hang = 1; hang <= Phong.SoHang; hang++)
//            {
//                for (int cot = 1; cot <= Phong.Socot; cot++)
//                {
//                    var tenGhe = $"{hang}-{cot}";
//                    var maGhe = $"{Phong.MaPhong}-{hang}-{cot}";
//                    var ghe = new Ghe
//                    {
//                        MaGhe = maGhe,
//                        TenGhe = tenGhe,
//                    };

//                    Phong.Ghes.Add(ghe);
//                }
//            }
//            context_.Add(Phong);
//            await context_.SaveChangesAsync();
//        }

//        public async Task Delete(string id)
//        {
//            var phong = (from ph in context_.Phongs where ph.MaPhong  == id select ph).FirstOrDefault();
//            if (phong != null)
//            {
//                context_.Remove(phong);
//                await context_.SaveChangesAsync();
//            }
//        }

//        public async Task<IEnumerable<PhongModels>> GetAll()
//        {
//            var phong = await context_.Phongs.ToListAsync();
//            return phong.Select(ph => new PhongModels
//            {
//                TenPhong = ph.TenPhong,
//                MaPhong = ph.MaPhong,
//                Socot = ph.Socot,
//                SoChoNgoi = ph.SoChoNgoi,
//                SoHang = ph.SoHang,
//            });
//        }

//        public async Task<PhongModels> GetById(string id)
//        {
//            var Phong =await (from ph in context_.Phongs where ph.MaPhong == id select ph).FirstOrDefaultAsync();
//            if (Phong != null)
//            {
//                return new PhongModels
//                { 
//                    TenPhong = Phong.TenPhong,
//                    MaPhong = Phong.MaPhong,
//                    Socot = Phong.Socot,
//                    SoHang = Phong.SoHang,
//                    SoChoNgoi = Phong.SoChoNgoi,
//                };
//            }
//            return null;
//        }

//        public async Task Update(string id, PhongModels entity)
//        {
//            var Phong =await (from ph in context_.Phongs where ph.MaPhong == id select ph).SingleOrDefaultAsync();
//            if(Phong != null)
//            {
//                Phong.TenPhong = entity.TenPhong;
//                Phong.MaPhong = entity.MaPhong;
//                Phong.SoChoNgoi = entity.SoChoNgoi;
//                Phong.SoHang = entity.SoHang;
//                Phong.Socot = entity.SoHang;
//                await context_.SaveChangesAsync();
//            }    
//        }
//    }
//}
