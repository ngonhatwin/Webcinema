using System;
using System.Collections.Generic;
using WebCinema.Entities;

namespace WebCinema.Models
{
    public partial class PhongModels
    {
       
        public string MaPhong { get; set; } = null!;
        public string TenPhong { get; set; } = null!;
        public int SoChoNgoi { get; set; }
        public int SoHang { get; set; }
        public int Socot { get; set; }
    }
}
