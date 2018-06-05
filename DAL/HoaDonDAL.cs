using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        public static int PhatSinhMaHoaDon()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.hoadon.MaHoaDon FROM quanlykaraoke.hoadon ORDER BY quanlykaraoke.hoadon.MaHoaDon DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }
        public static bool LuuThongTinHoaDon(HoaDonDTO hoaDonDTO)
        {

            try
            {
                
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.hoadon (MaHoaDon, MaNhanVienThanhToan, TongTienThanhToan, NgayThanhToan, SoTienKhuyenMai, GhiChu,MaKH,TienTraTruoc, MaDatPhong) VALUES('$0',$1,$2,$3,$4,'$5','$6','$7',$8)");
                strSQL.Replace("$0", hoaDonDTO.MaHoaDon.ToString());
                strSQL.Replace("$1", (hoaDonDTO.MaNhanVienThanhToan == -1)? ("NULL"): ("'" + hoaDonDTO.MaNhanVienThanhToan.ToString() + "'"));
                strSQL.Replace("$2", (Double.IsNaN(hoaDonDTO.TongTienThanhToan)?("NULL"):("'" + hoaDonDTO.TongTienThanhToan.ToString() + "'")));
                strSQL.Replace("$3", (DateTime.Equals(DateTime.MinValue, hoaDonDTO.NgayThanhToan)?("NULL"):("'" + hoaDonDTO.NgayThanhToan.ToString("yyyy-MM-dd HH:mm:ss.fff" + "'"))));
                strSQL.Replace("$4", (Double.IsNaN(hoaDonDTO.SoTienKhuyenMai) ? ("NULL") : ("'" + hoaDonDTO.SoTienKhuyenMai.ToString() + "'")));
                strSQL.Replace("$5", hoaDonDTO.GhiChu.ToString());
                strSQL.Replace("$6", hoaDonDTO.MaKH.ToString());
                strSQL.Replace("$7", hoaDonDTO.TienTraTruoc.ToString());
                strSQL.Replace("$8", (hoaDonDTO.MaDatPhong == -1) ? ("NULL") : ("'" + hoaDonDTO.MaDatPhong.ToString() + "'"));

                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static Dictionary<int, double> GetTongDoanhThuTheoThang(DateTime dateTime)
        {
            Dictionary<int, double> res = new Dictionary<int, double>();
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT month(NgayThanhToan)as Thang, SUM(TongTienThanhToan) as TongTien FROM hoadon WHERE NgayThanhToan is not nULL  and year(NgayThanhToan) = '" + dateTime.Year + "' GROUP BY month(NgayThanhToan);");

            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["Thang"], (double)row["TongTien"]);
            }

            return res;
        }

        public static Dictionary<int, double> GetTongDoanhThuTheoNgay(DateTime dateTime)
        {
            Dictionary<int, double> res = new Dictionary<int, double>();
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT day(NgayThanhToan), SUM(TongTienThanhToan) FROM hoadon WHERE NgayThanhToan is not nULL  and MONTH(NgayThanhToan) = '" + dateTime.Month + "' GROUP BY day(NgayThanhToan);");

            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["day(NgayThanhToan)"], (double)row["SUM(TongTienThanhToan)"]);
            }

            return res;
        }

        public static DataTable LayTatCaCacHoaDon_KhachHang_DaThanhToan(DateTime dateTime)
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon, khachhang WHERE hoadon.MaKH = khachhang.MaKH AND TongTienThanhToan IS NOT NULL AND MONTH(NgayThanhToan) = '" + dateTime.Month + "' AND YEAR(NgayThanhToan) = '" + dateTime.Year + "' ;");
        }

        public static DataTable LayTatCaCacHoaDon_KhachHang_DaThanhToan(int nam)
        {
            return DAL.DataProvider.ExecuseQuery("SELECT month(NgayThanhToan) as Thang, count(TongTienThanhToan) as TongSoHoaDon, Max(TongTienThanhToan) as HoaDonDacNhat,sum(SoTienKhuyenMai)as TongTienKhuyenMai, sum(TongTienThanhToan) as TongTienThanhToan FROM hoadon, khachhang WHERE hoadon.MaKH = khachhang.MaKH AND TongTienThanhToan IS NOT NULL and year(NgayThanhToan) = "+ nam+" group by month(NgayThanhToan)");
        }

        public static DataTable LayTatCaCacHoaDon_KhachHang_DaThanhToan()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon, khachhang WHERE hoadon.MaKH = khachhang.MaKH AND TongTienThanhToan IS NOT NULL;");
        }

        public static bool UpdateGhiChu(int maHoaDon, string strGhiChu)
        {
            DataProvider.ExecuseNonQuery("UPDATE hoadon SET hoadon.GhiChu = '" + strGhiChu + "'  WHERE hoadon.MaHoaDon = '" + maHoaDon + "';");

            return true;
        }

        public static DataTable LayTatCaDichVu_Phong_DichVuPhong()
        {
            return DataProvider.ExecuseQuery("SELECT thuephong.MaHoaDon, dichvu.TenDV, dichvuphong.ThoiGian, dichvuphong.SoLuong, dichvuphong.Gia, phong.TenPhong, dichvu.MaLDV FROM thuephong, dichvuphong, phong, dichvu WHERE thuephong.MaThuePhong = dichvuphong.MaThuePhong AND thuephong.MaPhong = phong.MaPhong AND dichvuphong.MaDV = dichvu.MaDV ;");
        }

        public static bool UpdateKhachHang(int maHoaDon, int maKH)
        {
            DataProvider.ExecuseNonQuery("UPDATE hoadon SET hoadon.MaKH = '" + maKH + "'  WHERE hoadon.MaHoaDon = '" + maHoaDon + "';");
            return true;
        }

        public static DataTable LayTatCaCacHoaDon_KhachHang()
        {
           return DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon, khachhang WHERE hoadon.MaKH = khachhang.MaKH;");
        }

        public static DataTable LayThongTinHoaDon_DataTable(int maHoaDon)
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon WHERE hoadon.MaHoaDon = '" + maHoaDon.ToString() + "';");
        }

        public static HoaDonDTO LayThongTinHoaDonDangThue(int maHoaDon)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon WHERE hoadon.MaHoaDon = '" + maHoaDon.ToString() + "';");

            return new HoaDonDTO((int)dt.Rows[0]["MaHoaDon"], (dt.Rows[0]["MaNhanVienThanhToan"].ToString() == "") ? (-1) : ((int)dt.Rows[0]["MaNhanVienThanhToan"]), (dt.Rows[0]["TongTienThanhToan"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["TienTraTruoc"]), (dt.Rows[0]["TienTraTruoc"].ToString() == "")?(-1):((double)dt.Rows[0]["TienTraTruoc"]), (dt.Rows[0]["NgayThanhToan"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(dt.Rows[0]["NgayThanhToan"].ToString()), (dt.Rows[0]["SoTienKhuyenMai"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["SoTienKhuyenMai"]), dt.Rows[0]["GhiChu"].ToString(), (int)dt.Rows[0]["MaKH"], (dt.Rows[0]["MaDatPhong"].ToString() == "") ? (-1) : ((int)dt.Rows[0]["MaDatPhong"]));

        }
        public static List<ThuePhongDTO> LayTatCaCacThuePhong(int maHoaDon)
        {
            List<ThuePhongDTO> res = new List<ThuePhongDTO>();
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon, thuephong WHERE hoadon.MaHoaDon = '" + maHoaDon.ToString() + "' AND thuephong.MaHoaDon = hoadon.MaHoaDon;");

            foreach(DataRow row in dt.Rows)
            {
                res.Add(new ThuePhongDTO((int)row["MaThuePhong"], (int)row["MaPhong"], DateTime.Parse(row["GioThuePhong"].ToString()),  (row["GioTraPhong"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(row["GioTraPhong"].ToString()), (int)row["MaHoaDon"], (row["TienGio"].ToString() == "") ? (Double.NaN) : ((double)row["TienGio"])));
            }

            return res;
            

        }
        public static DataTable LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(int maHoaDon)
        {
            DataTable res = DAL.DataProvider.ExecuseQuery("SELECT * FROM  thuephong, phong,loaiphong WHERE thuephong.MaHoaDon = '" + maHoaDon.ToString() + "' AND thuephong.MaPhong = phong.MaPhong AND loaiphong.MaLP = phong.MaLoaiPhong;");
            res.TableName = "thuephong";
            return res;
        }
        public static bool CapNhatHoaDonDaThanhToan(HoaDonDTO hoaDonDTO)
        {
            DataProvider.ExecuseNonQuery("UPDATE hoadon SET hoadon.MaNhanVienThanhToan = '"+ hoaDonDTO .MaNhanVienThanhToan+ "' ,  hoadon.TongTienThanhToan = '" + hoaDonDTO.TongTienThanhToan + "' ,  hoadon.NgayThanhToan = '" + hoaDonDTO.NgayThanhToan.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' , hoadon.SoTienKhuyenMai = '" + hoaDonDTO.SoTienKhuyenMai + "' WHERE hoadon.MaHoaDon = '" + hoaDonDTO.MaHoaDon + "';");

                return true;
        }
        public static int DemSoLuongPhongDangConDuocThueHienTai(HoaDonDTO hoaDonDTO)
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT COUNT(*) FROM quanlykaraoke.hoadon, quanlykaraoke.thuephong WHERE hoadon.MaHoaDon = thuephong.MaHoaDon AND thuephong.GioTraPhong is NULL AND thuephong.MaHoaDon = '"+hoaDonDTO.MaHoaDon+"' ;").Rows[0][0]);
        }
        public static int DemSoLuongThuePhong(int maHoaDon)
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT COUNT(*) FROM quanlykaraoke.hoadon, quanlykaraoke.thuephong WHERE hoadon.MaHoaDon = thuephong.MaHoaDon  AND thuephong.MaHoaDon = '" + maHoaDon + "' ;").Rows[0][0]);
        }
        public static bool XoaHoaDon(HoaDonDTO hoaDon)
        {
            DAL.DataProvider.ExecuseNonQuery("DELETE FROM hoadon WHERE hoadon.MaHoaDon = '" + hoaDon.MaHoaDon + "';");
            return true;
        }
        public static Dictionary<int, double> GetTongDoanhThuTheoThang(int Nam)
        {
            Dictionary<int, double> res = new Dictionary<int, double>();
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT Month(NgayThanhToan), SUM(TongTienThanhToan) FROM hoadon WHERE Year(NgayThanhToan) = '"+ Nam + "' GROUP BY Month(NgayThanhToan);");

            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["Month(NgayThanhToan)"], (double) row["SUM(TongTienThanhToan)"]);
            }

            return res;
        }

        public static Dictionary<int, double> GetTongDoanhThuTheoNam()
        {
            Dictionary<int, double> res = new Dictionary<int, double>();
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT Year(NgayThanhToan), SUM(TongTienThanhToan) FROM hoadon WHERE NgayThanhToan is not nULL GROUP BY Year(NgayThanhToan);");

            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["Year(NgayThanhToan)"], (double)row["SUM(TongTienThanhToan)"]);
            }

            return res;
        }

        public static int GetNamThanhToanDauTien()
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Min(Year(NgayThanhToan)) FROM hoadon WHERE NgayThanhToan is not nULL GROUP BY Year(NgayThanhToan) ;").Rows[0][0]);
        }
        public static bool CapNhatTienTraTruoc(HoaDonDTO hoaDonDTO, double tienTraTruoc)
        {
            DataProvider.ExecuseNonQuery("UPDATE hoadon SET hoadon.TienTraTruoc = '" + tienTraTruoc + "'  WHERE hoadon.MaHoaDon = '" + hoaDonDTO.MaHoaDon + "';");

            return true;
        }
        public static HoaDonDTO LayThongTinHoaDon(int maHoaDon)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon WHERE hoadon.MaHoaDon = '" + maHoaDon.ToString() + "';");

            return new HoaDonDTO((int)dt.Rows[0]["MaHoaDon"], (dt.Rows[0]["MaNhanVienThanhToan"].ToString() == "") ? (-1) : ((int)dt.Rows[0]["MaNhanVienThanhToan"]), (dt.Rows[0]["TongTienThanhToan"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["TienTraTruoc"]), (dt.Rows[0]["TienTraTruoc"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["TienTraTruoc"]), (dt.Rows[0]["NgayThanhToan"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(dt.Rows[0]["NgayThanhToan"].ToString()), (dt.Rows[0]["SoTienKhuyenMai"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["SoTienKhuyenMai"]), dt.Rows[0]["GhiChu"].ToString(), (int)dt.Rows[0]["MaKH"], (dt.Rows[0]["MaDatPhong"].ToString() == "") ? (-1) : ((int)dt.Rows[0]["MaDatPhong"]));

        }


    }
}
