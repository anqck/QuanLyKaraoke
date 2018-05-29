using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace BUS
{
    public class PhongBUS
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

        public static bool CapNhatTinhTrangPhong(PhongDTO phong, int maTinhTrangPhong)
        {
            return DAL.PhongDAL.CapNhatTinhTrangPhong(phong,maTinhTrangPhong);
        }

        public static DataTable LayTatCaPhong_TinhTrangPhong_LoaiPhong()
        {
            return DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
        }

    
    }
}
