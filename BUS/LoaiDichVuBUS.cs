using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiDichVuBUS
    {
        public static int PhatSinhLoaiDichVu()
        {
            return DAL.LoaiDichVuDAL.PhatSinhMaLoaiDV();
        }

        public static List<LoaiDichVuDTO> LayTatCaLoaiDichVu_List()
        {
            return DAL.LoaiDichVuDAL.LayTatCaLoaiDichVu_List();
        }

        public static LoaiDichVuDTO LayLoaiDichVu(DichVuDTO dichVu)
        {
            return DAL.LoaiDichVuDAL.LayLoaiDichVu(dichVu);
        }
        public static DataTable LayTatCaLoaiDichVu_DataTable()
        {
            return DAL.LoaiDichVuDAL.LayTatCaLoaiDichVu_DataTable();
        }
        public static bool XoaLoaiDichVu(int maLDV)
        {
            return DAL.LoaiDichVuDAL.XoaLoaiDichVu(maLDV);
        }
    }
}
