using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DichVuPhongDAL
    {
        public static int PhatSinhMaDichVuPhong()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.dichvuphong.MaDVP FROM quanlykaraoke.dichvuphong ORDER BY quanlykaraoke.dichvuphong.MaDVP DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinDichVuPhong(DichVuPhongDTO dichVuPhongDTO)
        {

            try
            {

                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.dichvuphong (MaDVP, MaThuePhong, MaDV , ThoiGian, SoLuong, Gia) VALUES('$0','$1','$2','$3','$4','$5')");
                strSQL.Replace("$0", dichVuPhongDTO.MaDVP.ToString());
                strSQL.Replace("$1", dichVuPhongDTO.MaThuePhong.ToString());
                strSQL.Replace("$2", dichVuPhongDTO.MaDV.ToString());
                strSQL.Replace("$3", dichVuPhongDTO.ThoiGian.ToString("yyyy-MM-dd HH:mm:ss.fff" ));
                strSQL.Replace("$4", dichVuPhongDTO.SoLuong.ToString());
                strSQL.Replace("$5", dichVuPhongDTO.DonGia.ToString());

                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static DataTable LayTatCaDichVuPhong_DichVu_LoaiDV(ThuePhongDTO thuePhongDTO)
        {
            return DataProvider.ExecuseQuery("SELECT MaDVP,dichvuphong.MaThuePhong, dichvuphong.MaDV, ThoiGian,SoLuong, Gia, TenDV, DonVi, dichvu.MaLDV, TenLDV FROM quanlykaraoke.dichvuphong,quanlykaraoke.dichvu,quanlykaraoke.loaidichvu  WHERE quanlykaraoke.dichvuphong.MaThuePhong = '" + thuePhongDTO.MaThuePhong+ "' AND quanlykaraoke.dichvuphong.MaDV = quanlykaraoke.dichvu.MaDV AND quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV; ");

        }
        public static bool UpdateDichVuPhong(DichVuPhongDTO dichVuPhongDTO)
        {
            try
            {
                DataProvider.ExecuseNonQuery("UPDATE  quanlykaraoke.dichvuphong SET  quanlykaraoke.dichvuphong.SoLuong = '" + dichVuPhongDTO.SoLuong + "',  quanlykaraoke.dichvuphong.Gia ='" + dichVuPhongDTO.DonGia + "' WHERE  quanlykaraoke.dichvuphong.MaDVP = '" + dichVuPhongDTO.MaDVP + "';");
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
        public static bool XoaDichVuPhong(int maDVP)
        {
            try
            {
                DataProvider.ExecuseNonQuery("DELETE FROM  quanlykaraoke.dichvuphong  WHERE  quanlykaraoke.dichvuphong.MaDVP = '" + maDVP + "';");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static DataTable LayTatCaDichVuPhong_DichVu_LoaiDV(HoaDonDTO hoaDonDTO)
        {
            return DataProvider.ExecuseQuery("SELECT MaDVP,thuephong.MaThuePhong, dichvuphong.MaDV, ThoiGian,SoLuong, Gia, TenDV, DonVi, dichvu.MaLDV, TenLDV FROM quanlykaraoke.dichvuphong,quanlykaraoke.dichvu,quanlykaraoke.loaidichvu,quanlykaraoke.thuephong  WHERE quanlykaraoke.thuephong.MaHoaDon = '" + hoaDonDTO.MaHoaDon + "' AND quanlykaraoke.dichvuphong.MaDV = quanlykaraoke.dichvu.MaDV AND quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV;");

        }
    }
}
