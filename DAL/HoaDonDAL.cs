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
                
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.hoadon (MaHoaDon, MaNhanVienThanhToan, TongTienThanhToan, NgayThanhToan, SoTienKhuyenMai, GhiChu,MaKH,TienTraTruoc) VALUES('$0','$1',$2,$3,$4,'$5','$6','$7')");
                strSQL.Replace("$0", hoaDonDTO.MaHoaDon.ToString());
                strSQL.Replace("$1", hoaDonDTO.MaNhanVienThanhToan.ToString());
                strSQL.Replace("$2", (Double.IsNaN(hoaDonDTO.TongTienThanhToan)?("NULL"):("'" + hoaDonDTO.TongTienThanhToan.ToString() + "'")));
                strSQL.Replace("$3", (DateTime.Equals(DateTime.MinValue, hoaDonDTO.NgayThanhToan)?("NULL"):("'" + hoaDonDTO.NgayThanhToan.ToString("yyyy-MM-dd HH:mm:ss.fff" + "'"))));
                strSQL.Replace("$4", (Double.IsNaN(hoaDonDTO.SoTienKhuyenMai) ? ("NULL") : ("'" + hoaDonDTO.SoTienKhuyenMai.ToString() + "'")));
                strSQL.Replace("$5", hoaDonDTO.GhiChu.ToString());
                strSQL.Replace("$6", hoaDonDTO.MaKH.ToString());
                strSQL.Replace("$7", hoaDonDTO.TienTraTruoc.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static HoaDonDTO LayThongTinHoaDonDangThue(int maHoaDon)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM hoadon WHERE hoadon.MaHoaDon = '" + maHoaDon.ToString() + "';");

            return new HoaDonDTO((int)dt.Rows[0]["MaHoaDon"], (int)dt.Rows[0]["MaNhanVienThanhToan"], (dt.Rows[0]["TongTienThanhToan"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["TienTraTruoc"]), (dt.Rows[0]["TienTraTruoc"].ToString() == "")?(-1):((double)dt.Rows[0]["TienTraTruoc"]), (dt.Rows[0]["NgayThanhToan"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(dt.Rows[0]["NgayThanhToan"].ToString()), (dt.Rows[0]["SoTienKhuyenMai"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["SoTienKhuyenMai"]), dt.Rows[0]["GhiChu"].ToString(), (int)dt.Rows[0]["MaKH"]);

        }
    }
}
