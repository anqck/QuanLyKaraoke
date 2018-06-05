using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuePhongBUS
    {
        public static void ThuePhong(ThuePhongDTO thueDTO)
        {

        }

        public static ThuePhongDTO LayThongTinPhongDangThue(PhongDTO maPhong)
        {
            return DAL.ThuePhongDAL.LayThongTinPhongDangThue(maPhong);
        }

        public static ThuePhongDTO LayThongTinThuePhong(int maThuePhong)
        {
            return DAL.ThuePhongDAL.LayThongTinThuePhong(maThuePhong);
        }

        public static Dictionary<int,ThuePhongDTO> LayThongTinCacPhongDangDuocThue()
        {
            return DAL.ThuePhongDAL.LayThongTinPhongDangDuocThue();
        }

        public static bool LuuThongTinThuePhong(ThuePhongDTO thuePhongDTO)
        {
            return DAL.ThuePhongDAL.LuuThongTinThuePhong(thuePhongDTO);
        }
        public static int PhatSinhMaThuePhong()
        {
            return DAL.ThuePhongDAL.PhatSinhMaThuePhong();
        }
        public static bool CapNhatThongTinThuePhong(ThuePhongDTO thuePhongDTO)
        {
            return DAL.ThuePhongDAL.CapNhatThongTinThuePhong(thuePhongDTO);
        }
        public static bool XoaCacDichVuPhong(ThuePhongDTO thuePhongDTO)
        {
            return DAL.ThuePhongDAL.XoaCacDichVuPhong(thuePhongDTO);
        }
        public static bool XoaThuePhong(ThuePhongDTO thuePhongDTO)
        {
            return DAL.ThuePhongDAL.XoaThuePhong(thuePhongDTO);
        }
        public static Dictionary<int, PhongDTO> LayCacPhongDangSapDuocDat(int khoangThoiGian)
        {
            return DAL.ThuePhongDAL.LayCacPhongDangSapDuocDat(khoangThoiGian);
        }


    }
}
