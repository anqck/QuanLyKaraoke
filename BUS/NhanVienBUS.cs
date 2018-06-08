using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class NhanVienBUS
    {
        public static int PhatSinhMaNhanVien()
        {
            return NhanVienDAL.PhatSinhMaNhanVien();
        }
        public static bool LuuThongTinNhanVien(NhanVienDTO NhanVienDTO)
        {
            return NhanVienDAL.LuuThongTinNhanVien(NhanVienDTO);
        }
        public static DataTable LayTatCaNhanVien_LoaiTaiKhoan()
        {
            return NhanVienDAL.LayTatCaNhanVien_LoaiTaiKhoan();
        }

        public static NhanVienDTO XacThucNhanVien(string taiKhoan, string matKhau)
        {
            return NhanVienDAL.XacThucNhanVien(taiKhoan, matKhau);
        }

        public static DataTable LayTatCaLoaiTaiKhoan()
        {
            return NhanVienDAL.LayTatCaLoaiTaiKhoan();
        }
        public static NhanVienDTO LayNhanVien(int MaNhanVien)
        {
            return NhanVienDAL.LayNhanVien( MaNhanVien);
        }

        public static List<LoaiTaiKhoanDTO> LayTatCaLoaiTaiKhoan_List()
        {
            return NhanVienDAL.LayTatCaLoaiTaiKhoan_List();
        }

        public static bool CapNhatThongTinNhanVien(NhanVienDTO NhanVienDTO)
        {
            return NhanVienDAL.CapNhatThongTinNhanVien(NhanVienDTO);
        }
        public static DataTable LayTatCaNhanVien_DataTable()
        {
            return NhanVienDAL.LayTatCaNhanVien_DataTable();
        }
        public static string LayLoaiNhanVien(int maLoaiTaiKhoan)
        {
            return NhanVienDAL.LayLoaiNhanVien(maLoaiTaiKhoan);
        }
    }
}
