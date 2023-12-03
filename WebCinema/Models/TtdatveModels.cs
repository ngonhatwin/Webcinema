using System;
using System.Collections.Generic;

namespace WebCinema.Models
{
    public partial class TtdatveModels
    {
        public int MaDatVe { get; set; }
        public string MaLichPhim { get; set; } = null!;
        public DateTime NgayDat { get; set; }

    }
}
