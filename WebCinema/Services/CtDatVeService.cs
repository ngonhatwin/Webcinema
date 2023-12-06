using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebCinema.Entities;
using WebCinema.Models;
using WebCinema.Repository;

namespace WebCinema.Services
{
    public class CtdatveService : MyRepository<Ctdatve>
    {
        private readonly web_cinema3Context _context;
        public CtdatveService(web_cinema3Context context) : base(context)
        {
            _context = context;
        }
        public async Task CreatebyModels(CtdatveModels ctdatve)
        {
            var ct = new Ctdatve
            {
                GiaVe = ctdatve.GiaVe,
                MaDatVe = ctdatve.MaDatVe,
                MaGhe = ctdatve.MaGhe
            };
            _context.Ctdatves.Add(ct);
            await _context.SaveChangesAsync();
        }
    }
}
