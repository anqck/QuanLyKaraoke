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
    }
}
