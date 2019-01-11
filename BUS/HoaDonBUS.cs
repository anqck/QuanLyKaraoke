using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BUS
{
    public class HoaDonBUS
    {

        public static int PhatSinhMaHoaDon()
        {
            return DAL.HoaDonDAL.PhatSinhMaHoaDon();
        }

        public static bool LuuThongTinThuePhong(ThuePhongDTO thuePhongDTO, HoaDonDTO hoaDonDTO)
        {
            return HoaDonDAL.LuuThongTinHoaDon(hoaDonDTO) && ThuePhongBUS.LuuThongTinThuePhong(thuePhongDTO);

        }

        public static bool LuuThongTinHoaDon(HoaDonDTO hoaDonDTO)
        {
            return HoaDonDAL.LuuThongTinHoaDon(hoaDonDTO);

        }
        public static HoaDonDTO LayThongTinHoaDonDangThue(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayThongTinHoaDonDangThue(maHoaDon);
        }

        public static DataTable LayTatCaCacHoaDon_KhachHang_DaThanhToan(DateTime dateTime)
        {
            return DAL.HoaDonDAL.LayTatCaCacHoaDon_KhachHang_DaThanhToan(dateTime);
        }
        public static DataTable LayTatCaCacHoaDon_KhachHang_DaThanhToan_TheoNam(DateTime dateTime)
        {
            return DAL.HoaDonDAL.LayTatCaCacHoaDon_KhachHang_DaThanhToan_TheoNam(dateTime);
        }

        public static DataTable LayDoanhThuTheoNam(int nam)
        {
            return HoaDonDAL.LayDoanhThuTheoNam(nam);
        }

        public static DataTable LayTatCaCacHoaDon_KhachHang_DaThanhToan()
        {
            return DAL.HoaDonDAL.LayTatCaCacHoaDon_KhachHang_DaThanhToan();
        }

        public static List<ThuePhongDTO> LayTatCaCacThuePhong(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayTatCaCacThuePhong(maHoaDon);
        }

        public static Dictionary<int, double> GetTongDoanhThuTheoNgay(DateTime dateTime)
        {
            return DAL.HoaDonDAL.GetTongDoanhThuTheoNgay(dateTime);
        }

        public static Dictionary<int, double> GetTongDoanhThuTheoThang(DateTime dateTime)
        {
            return DAL.HoaDonDAL.GetTongDoanhThuTheoThang(dateTime);
        }

        public static DataTable LayTatCaCacThuePhong_DataTable(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(maHoaDon);
        }
        public static bool CapNhatHoaDonDaThanhToan(HoaDonDTO hoaDonDTO)
        {
            return DAL.HoaDonDAL.CapNhatHoaDonDaThanhToan(hoaDonDTO);
        }
        public static int DemSoLuongPhongDangConDuocThueHienTai(HoaDonDTO hoaDonDTO)
        {
            return DAL.HoaDonDAL.DemSoLuongPhongDangConDuocThueHienTai(hoaDonDTO);
        }
        public static int DemSoLuongThuePhong(int maHoaDon)
        {
            return DAL.HoaDonDAL.DemSoLuongThuePhong(maHoaDon);
        }
        public static DataTable LayTatCaCacHoaDon_KhachHang_NhanVien()
        {
            return DAL.HoaDonDAL.LayTatCaCacHoaDon_KhachHang_NhanVien();
        }
        public static bool CapNhatGhiChu(int maHoaDon, string strGhiChu)
        {
            return DAL.HoaDonDAL.UpdateGhiChu(maHoaDon, strGhiChu);
        }
        public static bool UpdateKhachHang(int maHoaDon, int maKH)
        {
            return DAL.HoaDonDAL.UpdateKhachHang(maHoaDon, maKH);
        }

        public static bool XoaHoaDon(HoaDonDTO hoaDon)
        {
            return DAL.HoaDonDAL.XoaHoaDon(hoaDon);
        }
        public static DataTable LayTatCaDichVu_Phong_DichVuPhong()
        {
            return DAL.HoaDonDAL.LayTatCaDichVu_Phong_DichVuPhong();
        }
        public static Dictionary<int, double> GetTongDoanhThuTheoThang(int Nam)
        {
            return DAL.HoaDonDAL.GetTongDoanhThuTheoThang(Nam);
        }
        public static Dictionary<int, double> GetTongDoanhThuTheoNam()
        {
            return DAL.HoaDonDAL.GetTongDoanhThuTheoNam();
        }
        public static bool CapNhatTienTraTruoc(HoaDonDTO hoaDonDTO, double tienTraTruoc)
        {
            return DAL.HoaDonDAL.CapNhatTienTraTruoc(hoaDonDTO, tienTraTruoc);
        }

        public static HoaDonDTO LayThongTinHoaDon(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayThongTinHoaDon(maHoaDon);
        }
        public static DataTable LayThongTinHoaDon_DataTable(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayThongTinHoaDon_DataTable(maHoaDon);
        }
        public static DataTable LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(maHoaDon);
        }
        public static DataTable LayTatCaDichVu_Phong_DichVuPhong_DaThanhToan(DateTime dateTime)
        {
            return DAL.HoaDonDAL.LayTatCaDichVu_Phong_DichVuPhong_DaThanhToan(dateTime);
        }



    
    }
}
