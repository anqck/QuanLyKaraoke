using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return HoaDonDAL.LuuThongTinHoaDon(hoaDonDTO) && ThuePhongBUS.LuuThongTinThuePhong(thuePhongDTO)  ;

        }

        public static bool LuuThongTinHoaDon( HoaDonDTO hoaDonDTO)
        {
            return HoaDonDAL.LuuThongTinHoaDon(hoaDonDTO);

        }
        public static HoaDonDTO LayThongTinHoaDonDangThue(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayThongTinHoaDonDangThue(maHoaDon);
        }

        public static List<ThuePhongDTO> LayTatCaCacThuePhong(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayTatCaCacThuePhong(maHoaDon);
        }
        public static bool CapNhatHoaDonDaThanhToan(HoaDonDTO hoaDonDTO)
        {
            return DAL.HoaDonDAL.CapNhatHoaDonDaThanhToan(hoaDonDTO);
        }
        public static int  DemSoLuongPhongDangConDuocThueHienTai(HoaDonDTO hoaDonDTO)
        {
            return DAL.HoaDonDAL.DemSoLuongPhongDangConDuocThueHienTai(hoaDonDTO);
        }
        public static int DemSoLuongThuePhong(int maHoaDon)
        {
            return DAL.HoaDonDAL.DemSoLuongThuePhong(maHoaDon);
        }
    }
}
