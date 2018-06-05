using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDatPhongDTO
    {
        public int MaDichVuDatPhong { get; set; }
        public int MaDichVu { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public int MaChiTietDatPhong { get; set; }

        public DichVuDatPhongDTO(int maDichVuDatPhong, int maDichVu,  double soLuong, double donGia, int maChiTietDatPhong)
        {
            MaDichVuDatPhong = maDichVuDatPhong;
            MaDichVu = maDichVu;
            SoLuong = soLuong;
            DonGia = donGia;
            MaChiTietDatPhong = maChiTietDatPhong;

        }
    }
}
