using System;
using System.Collections.Generic;
using WebCinema.Entities;

namespace WebCinema.Models
{
    public partial class ThanhToanModels
    {
        public string MaThanhToan { get; set; } = null!;
        public int MaDatVe { get; set; }
        public string MaNhanVien { get; set; } = null!;
        public DateTime NgayThanhToan { get; set; }
        public string Phuongthucthanhtoan { get; set; } = null!;

        public List<Ttdatve> ttdatves { get; set; } = new List<Ttdatve>();
        public List<Ctdatve> ctdatves { get; set; } = new List<Ctdatve>();
        public List<Thanhtoan> thanhtoan { get; set; } = new List<Thanhtoan>();
        public List<Trangthaighe> trangthaighes { get; set; } = new List<Trangthaighe>();

    }
}
