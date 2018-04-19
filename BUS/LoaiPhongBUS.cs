using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiPhongBUS
    {
        public static int PhatSinhLoaiMaPhong()
        {
            return DAL.LoaiPhongDAL.PhatSinhMaLoaiPhong();
        }
    }
}
