using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int MaLoaiKH { get; set; }
        public int DiemTichLuy { get; set; }

        public DateTime NgaySinh { get; set; }
        public KhachHangDTO()
        {
            MaKH = -1;
            TenKH = "";
            CMND = "";
            SDT = "";
            DiaChi = "";
            MaLoaiKH = -1;
            DiemTichLuy = -1;
        }

        public KhachHangDTO(int maKH,string tenKH,string cMND, string sDT, string diaChi, int maLoaiKH, int diemTichLuy, DateTime ngaySinh)
        {
            MaKH = maKH;
            TenKH = tenKH;
            CMND = cMND;
            SDT = sDT;
            DiaChi = diaChi;
            MaLoaiKH = maLoaiKH;
            DiemTichLuy = diemTichLuy;
            NgaySinh = ngaySinh;
        }
    }
}
