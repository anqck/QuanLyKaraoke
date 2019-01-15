using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhongDTO
    {
        public int MaDatPhong { get; set; }
        public DateTime NgayLapPhieuDat { get; set; }

        public DateTime ThoiGianDatPhong { get; set; }

        public double SoTienDatTruoc { get; set; }
        public int MaNhanVien { get; set; }
        public int MaKH { get; set; }
        public string GhiChu { get; set; }
        public int MaTinhTrangDatPhong { get; set; }

      

        public DatPhongDTO(int maDatPhong, DateTime thoiGianDatPhong, double soTienDatTruoc,int maNhanVien, int maKH, string ghiChu, int maTinhTrangDatPhong, DateTime ngayLapPhieuDat)
        {
            MaDatPhong = maDatPhong;
            ThoiGianDatPhong = thoiGianDatPhong;
            SoTienDatTruoc = soTienDatTruoc;
            MaNhanVien = maNhanVien;
            MaKH = maKH;
            GhiChu = ghiChu;
            MaTinhTrangDatPhong = maTinhTrangDatPhong;
            NgayLapPhieuDat = ngayLapPhieuDat;
        }
    }
}
