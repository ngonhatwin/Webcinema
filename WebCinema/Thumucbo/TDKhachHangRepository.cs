//using Microsoft.EntityFrameworkCore;
//using WebCinema.Entities;
//using WebCinema.Models;

//namespace WebCinema.Repository
//{
//    public class TDKhachHangRepository : IRepository<TdKhachHangModels>
//    {
//        private readonly web_cinema3Context context_;
//        public TDKhachHangRepository(web_cinema3Context context)
//        {
//            context_ = context;
//        }
//        public async Task Create(TdKhachHangModels entity)
//        {
//            var TD = new Tdkhachhang
//            {
//                Diemkhachhang = entity.Diemkhachhang,
//                Makhachhang = entity.Makhachhang,
//                //hang. khach' hang`
//                HangKh = entity.HangKh,
//            };
//            context_.Add(TD);
//            await context_.SaveChangesAsync();
//        }

//        public async Task Delete(string id)
//        {
//            var diem = (from d in context_.Tdkhachhangs where d.Makhachhang == id select d).FirstOrDefault();
//            if (diem != null)
//            {
//                context_.Remove(diem);
//            }
//            await context_.SaveChangesAsync();
//        }

//        public async Task<IEnumerable<TdKhachHangModels>> GetAll()
//        {
//            var diem = await context_.Tdkhachhangs.ToListAsync();
//            return diem.Select(tl => new TdKhachHangModels
//            {
//                Makhachhang = tl.Makhachhang,
//                Diemkhachhang = tl.Diemkhachhang,
//                HangKh = tl.HangKh,
//            });
//        }

//        public async Task<TdKhachHangModels> GetById(string id)
//        {
//            var diem = await (from d in context_.Tdkhachhangs where d.Makhachhang == id select d).FirstOrDefaultAsync();
//            if (diem != null)
//            {
//                return new TdKhachHangModels
//                {
//                    Makhachhang = diem.Makhachhang,
//                    Diemkhachhang = diem.Diemkhachhang,
//                    HangKh = diem.HangKh,
//                };
//            }
//            return null;
//        }

//        public async Task Update(string id, TdKhachHangModels entity)
//        {
//            var diem = await (from td in context_.Tdkhachhangs where td.Makhachhang == id select td).FirstOrDefaultAsync();
//            if (diem != null)
//            {
//                diem.Makhachhang = entity.Makhachhang;
//                diem.Diemkhachhang = entity.Diemkhachhang;
//                diem.HangKh = entity.HangKh;
//            }
//        }
//    }
//}
