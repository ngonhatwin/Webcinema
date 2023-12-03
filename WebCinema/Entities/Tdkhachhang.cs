using System;
using System.Collections.Generic;

namespace WebCinema.Entities
{
    public partial class Tdkhachhang
    {
        public string Makhachhang { get; set; } = null!;
        public int? Diemkhachhang { get; set; }
        public string? HangKh { get; set; }

        public virtual Khachhang MakhachhangNavigation { get; set; } = null!;
    }
}
