using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThanhToanBUS
    {
        public static double TinhTien()
        {
            return DAL.LoaiPhongDAL.PhatSinhMaLoaiPhong();
        }

        public static ThuePhongDTO LayThongTinThuePhong(int MaPhong)
        {
            return new ThuePhongDTO();
        }
    }
}
