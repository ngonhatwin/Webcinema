using System;
using System.Collections.Generic;

namespace WebCinema.Models
{
    public partial class TrangThaiGheModels
    {
        public string Maghe { get; set; } = null!;
        public byte TrangThai { get; set; }
        public string MaPhong { get; set; } = null!;
        public string MaLichChieu { get; set; } = null!;
    }
}
