using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietDatPhongBUS
    {
        public static int PhatSinhMaChiTietDatPhong()
        {
            return DAL.ChiTietDatPhongDAL.PhatSinhMaChiTietDatPhong();
        }

        public static bool LuuThongTinDatPhong(ChiTietDatPhongDTO datPhongDTO)
        {
            return DAL.ChiTietDatPhongDAL.LuuThongTinDatPhong(datPhongDTO);
        }

        public static DataTable LayTatCaChiTietDatPhong_DataTable()
        {
            return DAL.ChiTietDatPhongDAL.LayTatCaChiTietDatPhong_DataTable();

        }
        public static void CapNhatThongTinDatPhong(ChiTietDatPhongDTO chiTietDatPhongDTO)
        {
             DAL.ChiTietDatPhongDAL.CapNhatThongTinDatPhong(chiTietDatPhongDTO);
        }
    }
}
