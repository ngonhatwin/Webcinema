using System;
using System.Collections.Generic;

namespace WebCinema.Models
{
    public partial class ThanhToanModels
    {
        public string MaThanhToan { get; set; } = null!;
        public int MaDatVe { get; set; }
        public string MaNhanVien { get; set; } = null!;
        public DateTime NgayThanhToan { get; set; }
        public string Phuongthucthanhtoan { get; set; } = null!;

    }
}
