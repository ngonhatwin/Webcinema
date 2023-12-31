﻿using System;
using System.Collections.Generic;

namespace WebCinema.Entities
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Nguoidungs = new HashSet<Nguoidung>();
            Thanhtoans = new HashSet<Thanhtoan>();
        }

        public string MaNhanVien { get; set; } = null!;
        public string TenNhanVien { get; set; } = null!;
        public string SoDienThoai { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public byte Gioitinh { get; set; }
        public DateTime Ngaysinh { get; set; }

        public virtual ICollection<Nguoidung> Nguoidungs { get; set; }
        public virtual ICollection<Thanhtoan> Thanhtoans { get; set; }
    }
}
