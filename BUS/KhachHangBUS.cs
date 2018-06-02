using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class KhachHangBUS
    {
        public static DataTable LayTatCaKhachHang_LoaiKhachHang()
        {


            return DAL.KhachHangDAL.LayTatCaKhachHang_LoaiKhachHang();
        }
        public static bool LuuThongTinKH(KhachHangDTO khachHangDTO)
        {
            return DAL.KhachHangDAL.LuuThongTinKhachHang(khachHangDTO);
        }

        public static Dictionary<int, KhachHangDTO> LayTatCaKhachHang()
        {
            return DAL.KhachHangDAL.LayTatCaKhachHang();
        }


        public static KhachHangDTO LayKhachHang(int maKH)
        {
            return DAL.KhachHangDAL.LayKhachHang(maKH);
        }
        public static int PhatSinhMaKH()
        {
            return DAL.KhachHangDAL.PhatSinhKH();
        }
    }
}
