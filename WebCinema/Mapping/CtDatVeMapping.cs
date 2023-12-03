using AutoMapper;
using WebCinema.Entities;
using WebCinema.Models;

namespace sell_movie.Mapping
{
    public class CtDatVeMapping : Profile
    {
        public CtDatVeMapping() {
            CreateMap<Ctdatve, CtdatveModels>();
            CreateMap<CtdatveModels, Ctdatve>();
        }
    }
}
