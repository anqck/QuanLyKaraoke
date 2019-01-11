using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int MaLoaiPhong { get; set; }
        public string Tang { get; set; }
        public string GhiChu { get; set; }
        public int MaTinhTrangPhong { get; set; }
        public int SucChua { get; set; }
        public PhongDTO()
        {
            MaPhong = -1;
            TenPhong = "";
            MaLoaiPhong = -1;
            Tang = "";
            GhiChu = "";
            MaTinhTrangPhong = -1;
            SucChua = -1;
        }

        public PhongDTO(int maPhong, string tenPhong, int maLoaiPhong)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            MaLoaiPhong = maLoaiPhong;
            Tang = "";
            GhiChu = "";
            MaTinhTrangPhong = -1;
            SucChua = -1;
        }
        public PhongDTO(int maPhong, string tenPhong, int maLoaiPhong, string tang,string ghiChu, int maTinhTrangPhong, int sucChua)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            MaLoaiPhong = maLoaiPhong;
            Tang = tang;
            GhiChu = ghiChu;
            MaTinhTrangPhong = maTinhTrangPhong;
            SucChua = sucChua;
        }
    }
}
