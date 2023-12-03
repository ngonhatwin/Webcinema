using System;
using System.Collections.Generic;

namespace WebCinema.Models
{
    public partial class LichchieuModels
    {
     

        public string MaLichChieu { get; set; } = null!;
        public DateTime NgayChieu { get; set; }
        public TimeSpan GioChieu { get; set; }

      
    }
}
