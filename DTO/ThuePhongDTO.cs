using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuePhongDTO
    {
        public int MaThuePhong { get; set; }
        public int MaPhong { get; set; }
        public int MaKH { get; set; }
        public DateTime GioThuePhong { get; set; }
        public double TienTraTruoc { get; set; }
        public int MaTrangThaiThuePhong { get; set; }

        public ThuePhongDTO()
        {
            MaThuePhong = -1;
            MaPhong = -1;
            MaKH = -1;
     
            TienTraTruoc = 0;
            MaTrangThaiThuePhong = -1;
        }

        public ThuePhongDTO(int maThuePhong, int maPhong, int maKH, DateTime gioThuePhong, double tienTraTruoc, int maTrangThaiThuePhong)
        {
            MaThuePhong = maThuePhong;
            MaPhong = maPhong;
            MaKH = maKH;
            GioThuePhong = gioThuePhong;
            TienTraTruoc = tienTraTruoc;
            MaTrangThaiThuePhong = maTrangThaiThuePhong;
        }
    }
}
