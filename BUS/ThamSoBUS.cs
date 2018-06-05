using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThamSoBUS
    {
        public static double QuyDoiDiem(double TongTien)
        {
            return DAL.ThamSoDAL.GetTyLeQuyDoiDiemTien()*TongTien;

        }

        public static int LayKhoangThoiGianToiThieuGiuaHaiLanThue()
        {
            return DAL.ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue();
        }
    }
}
