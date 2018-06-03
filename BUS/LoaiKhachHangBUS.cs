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

        public static LoaiKhachHangDTO LayLoaiKhachHang(int maLoaiKH)
        {
            return DAL.LoaiKhachHangDAL.LayLoaiKhachHang(maLoaiKH);
        }
        public static string GetFilterString_LoaiKhachHang(string str)
        {
            return "[TenLoaiKH] = '" + str + "'";
        }

        public static bool LuuThongTinLoaiKhachHang(LoaiKhachHangDTO loaiKhachHangDTO)
        {
            return DAL.LoaiKhachHangDAL.LuuThongTinLoaiKhachHang(loaiKhachHangDTO);
        }
        public static DataTable LayTatCaLoaiKhachHang_DataTable()
        {
            return DAL.LoaiKhachHangDAL.LayTatCaLoaiKhachHang_DataTable();
        }
        public static bool CapNhatThongTinLoaiKhachHang(LoaiKhachHangDTO loaiKhachHangDTO)
        {
            return DAL.LoaiKhachHangDAL.CapNhatThongTinLoaiKhachHang(loaiKhachHangDTO);
        }
        public static bool XoaLoaiKhachHang(int maLoaiKH)
        {
            return DAL.LoaiKhachHangDAL.XoaLoaiKhachHang(maLoaiKH);
        }
    }
}
