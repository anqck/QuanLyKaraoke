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
    }
}
