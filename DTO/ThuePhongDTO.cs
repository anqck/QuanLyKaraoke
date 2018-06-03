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
     
        public DateTime GioThuePhong { get; set; }
        public DateTime GioTraPhong { get; set; }

        public int MaHoaDon { get; set; }

        public double TienGio { get; set; }

        public ThuePhongDTO()
        {
            MaThuePhong = -1;
            MaPhong = -1;
           
        }

        public ThuePhongDTO(int maThuePhong, int maPhong, DateTime gioThuePhong, DateTime gioTraPhong, int maHoaDon,double tienGio)
        {
            MaThuePhong = maThuePhong;
            MaPhong = maPhong;
           
            GioThuePhong = gioThuePhong;
            GioTraPhong = gioTraPhong;

            MaHoaDon = maHoaDon;
            TienGio = tienGio;
        }
    }
}
