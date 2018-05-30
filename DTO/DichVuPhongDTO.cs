using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuPhongDTO
    {
        public int MaDVP { get; set; }
        public int MaThuePhong { get; set; }

        public int MaDV { get; set; }

        public DateTime ThoiGian { get; set; }

        public double SoLuong { get; set; }
        public double DonGia { get; set; }

        public DichVuPhongDTO(int maDVP, int maThuePhong,int maDV, DateTime thoiGian, double soLuong, double donGia)
        {
            MaDVP = maDVP;
            MaThuePhong = maThuePhong;
            MaDV = maDV;
            ThoiGian = thoiGian;
            SoLuong = soLuong;

            DonGia = donGia;
        }

    }
}
