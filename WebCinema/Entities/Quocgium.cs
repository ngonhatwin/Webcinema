﻿using System;
using System.Collections.Generic;

namespace WebCinema.Entities
{
    public partial class Quocgium
    {
        public Quocgium()
        {
            Phims = new HashSet<Phim>();
        }

        public string MaQuocgia { get; set; } = null!;
        public string TenQuocGia { get; set; } = null!;

        public virtual ICollection<Phim> Phims { get; set; }
    }
}
