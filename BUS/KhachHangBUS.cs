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

        public static bool XoaKhachHang(int maKH)
        {
            return DAL.KhachHangDAL.XoaKhachHang(maKH);
        }

        public static DataTable LayTatCaKhachHang_DataTable()
        {
            return DAL.KhachHangDAL.LayTatCaKhachHang_DataTable();
        }

        public static KhachHangDTO LayKhachHang(int maKH)
        {
            return DAL.KhachHangDAL.LayKhachHang(maKH);
        }
        public static int PhatSinhMaKH()
        {
            return DAL.KhachHangDAL.PhatSinhMaKH();
        }
        public static bool CapNhatThongTinKhachHang(KhachHangDTO khachHangDTO)
        {
            return DAL.KhachHangDAL.CapNhatThongTinKhachHang(khachHangDTO);
        }

        public static bool CapNhatDiemTichLuy(int maKH, double diemTichLuy)
        {
            return DAL.KhachHangDAL.CapNhatDiemTichLuy(maKH, diemTichLuy);
        }

        public static LoaiKhachHangDTO LayLoaiKhachHangCoTheDatDuoc(KhachHangDTO khachHang)
        {
            LoaiKhachHangDTO loaiKhachHangDto = DAL.KhachHangDAL.LayLoaiKhachHangCoTheDatDuoc(khachHang);
            LoaiKhachHangDTO loaiKhachHangHienTai = LoaiKhachHangBUS.LayLoaiKhachHang(khachHang);
            if (loaiKhachHangDto.SoDiemDeDatDuoc < loaiKhachHangHienTai.SoDiemDeDatDuoc)
                return loaiKhachHangHienTai;
            else
                return loaiKhachHangDto;

        }
        public static bool CapNhatLoaiKhachHang(int maKH, int maLoaiKH)
        {
            return DAL.KhachHangDAL.CapNhatLoaiKhachHang(maKH, maLoaiKH);
        }
    }
}
