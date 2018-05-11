using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiKhachHangDAL
    {
        public static int PhatSinhMaLoaiKH()
        {

            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.loaikhachhang;").Rows[0][0]);
        }

        public static DataTable LayTatCaLoaiKhachHang_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong;");
        }

        public static LoaiKhachHangDTO LayLoaiKhachHang(KhachHangDTO khachHang)
        {
            DataTable resLoaiPhong = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang WHERE quanlykaraoke.loaikhachhang.MaLoaiKH = '" + khachHang.MaLoaiKH.ToString() + "';");
            return new LoaiKhachHangDTO(Convert.ToInt32(resLoaiPhong.Rows[0]["MaLoaiKH"]), resLoaiPhong.Rows[0]["TenLoaiKH"].ToString());
        }

        public static List<LoaiKhachHangDTO> LayTatCaLoaiKhachHang_List()
        {
            List<LoaiKhachHangDTO> res = new List<LoaiKhachHangDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(new LoaiKhachHangDTO(Convert.ToInt32(row["MaLoaiKH"]), row["TenLoaiKH"].ToString()));
            }

            return res;
        }
    }
}
