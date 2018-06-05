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
    public class DichVuPhongBUS
    {
        public static int PhatSinhMaDichVuPhong()
        {
            return DichVuPhongDAL.PhatSinhMaDichVuPhong();
        }

        public static bool LuuThongTinDichVuPhong(DichVuPhongDTO dichVuPhongDTO)
        {
            return DichVuPhongDAL.LuuThongTinDichVuPhong(dichVuPhongDTO);
        }

        public static DataTable LayTatCaDichVuPhong_DichVu(ThuePhongDTO thuePhongDTO)
        {
            return DichVuPhongDAL.LayTatCaDichVuPhong_DichVu_LoaiDV(thuePhongDTO);
        }



        public static DataTable LayTatCaDichVuPhong_DichVu(HoaDonDTO hoaDonDTO)
        {
            return DichVuPhongDAL.LayTatCaDichVuPhong_DichVu_LoaiDV(hoaDonDTO);
        }

        public static void UpdateDichVuPhong(DichVuPhongDTO dichVuPhongDTO)
        {
            DichVuPhongDAL.UpdateDichVuPhong(dichVuPhongDTO);
        }
        public static bool XoaDichVuPhong(int maDVP)
        {
            return DichVuPhongDAL.XoaDichVuPhong(maDVP);
        }
        public static Dictionary<int, double> GetTongDoanhThuTheoThang(DateTime dateTime)
        {
            return DichVuPhongDAL.GetTongDoanhThuTheoThang( dateTime);
        }
        public static DataTable LayTatCaCacDichVu_TrongThang(DateTime dateTime)
        {
            return DichVuPhongDAL.LayTatCaCacDichVu_TrongThang(dateTime);
        }
    }
}
