using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiKhachHangBUS
    {
        public static int PhatSinhLoaiKhachHang()
        {
            return DAL.LoaiKhachHangDAL.PhatSinhMaLoaiKH();
        }

        public static List<LoaiKhachHangDTO> LayTatCaLoaiKhachHang_List()
        {
            return DAL.LoaiKhachHangDAL.LayTatCaLoaiKhachHang_List();
        }

        public static LoaiKhachHangDTO LayLoaiKhachHang(KhachHangDTO khachHang)
        {
            return DAL.LoaiKhachHangDAL.LayLoaiKhachHang(khachHang);
        }
        public static string GetFilterString_LoaiKhachHang(string str)
        {
            return "[TenLoaiKH] = '" + str + "'";
        }
    }
}
