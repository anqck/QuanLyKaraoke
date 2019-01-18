using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienGio_ThuePhongDTO
    {
        public int MaTienGio_ThuePhong { get; set; }
        public string Ngay { get; set; }
        public string KhoangThoiGian { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public int MaThuePhong { get; set; }


        public TienGio_ThuePhongDTO(int MaTienGio_ThuePhong, string Ngay, string KhoangThoiGian, double SoLuong, double DonGia, int MaThuePhong)
        {
            this.MaTienGio_ThuePhong = MaTienGio_ThuePhong;
            this.Ngay = Ngay;
            this.KhoangThoiGian = KhoangThoiGian;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.MaThuePhong = MaThuePhong;
        }
    }
}
