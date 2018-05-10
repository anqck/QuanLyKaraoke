using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class KhachHangDAL
    {
        public static int PhatSinhKH()
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.khachhang;").Rows[0][0]);
        }

        public static bool LuuThongTinKhachHang(KhachHangDTO khachHangDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.khachhang (MaKH, TenKH, CMND, SDT, DiaChi, MaLoaiKH,DiemTichLuy) VALUES('$0','$1','$2','$3','$4','$5','$6')");
                strSQL.Replace("$0", khachHangDTO.MaKH.ToString());
                strSQL.Replace("$1", khachHangDTO.TenKH.ToString());
                strSQL.Replace("$2", khachHangDTO.CMND.ToString());
                strSQL.Replace("$3", khachHangDTO.SDT.ToString());
                strSQL.Replace("$4", khachHangDTO.DiaChi.ToString());
                strSQL.Replace("$5", khachHangDTO.MaLoaiKH.ToString());
                strSQL.Replace("$6", khachHangDTO.DiemTichLuy.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static DataTable LayTatCaKhachHang_LoaiKhachHang()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.khachhang, quanlykaraoke.loaikhachhang where quanlykaraoke.khachhang.MaLoaiKH = quanlykaraoke.loaikhachhang.MaLoaiKH ;");
        }
    }
}
