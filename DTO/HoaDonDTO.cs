    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public int MaNhanVienThanhToan { get; set; }

        public double TongTienThanhToan { get; set; }

        public DateTime NgayThanhToan { get; set; }
        public double SoTienKhuyenMai { get; set; }
        public double TienTraTruoc { get; set; }
        public string GhiChu { get; set; }
        public int MaKH { get; set; }
        public int MaDatPhong { get; set; }


        public HoaDonDTO(int maHoaDon, int maNhanVienThanhToan, double tongTienThanhToan, double tienTraTruoc, DateTime ngayThanhToan, double soTienKhuyenMai, string ghiChu, int maKH, int maDatPhong)
        {
            MaHoaDon = maHoaDon;
            MaNhanVienThanhToan = maNhanVienThanhToan;
            TongTienThanhToan = tongTienThanhToan;
            NgayThanhToan = ngayThanhToan;
            SoTienKhuyenMai = soTienKhuyenMai;
            GhiChu = ghiChu;
            MaKH = maKH;
            TienTraTruoc = tienTraTruoc;
            MaDatPhong = maDatPhong;

        }
    }
}
