using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDatPhongDTO
    {
        public int MaChiTietDatPhong { get; set; }
        public int MaPhong { get; set; }
        public int MaDatPhong { get; set; }

        public ChiTietDatPhongDTO(int maChiTiet, int maPhong, int maDatPhong)
        {
            MaChiTietDatPhong = maChiTiet;
            MaPhong = maPhong;
            MaDatPhong = maDatPhong;
        }
    }
}
