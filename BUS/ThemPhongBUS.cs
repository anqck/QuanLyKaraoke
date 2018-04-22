using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class ThemPhongBUS
    {
        public static int PhatSinhMaPhong()
        {
            return DAL.PhongDAL.PhatSinhMaPhong();
        }

        public static List<String> LayCacTangCoSan()
        {
            return DAL.PhongDAL.LayCacTangCoSan();
        }

        public static bool LuuThongTinPhong(PhongDTO phongDTO)
        {
            return DAL.PhongDAL.LuuThongTinPhong(phongDTO);
        }
    }
}
