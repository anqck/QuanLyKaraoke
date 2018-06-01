using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable LayTatCaLoaiPhong_DataTable()
        {
            return DAL.LoaiPhongDAL.LayTatCaLoaiPhong_DataTable();
        }

        public static List<LoaiPhongDTO> LayTatCaLoaiPhong_List()
        {
            return DAL.LoaiPhongDAL.LayTatCaLoaiPhong_List();
        }

        public static LoaiPhongDTO LayLoaiPhong(PhongDTO phong)
        {
            return DAL.LoaiPhongDAL.LayLoaiPhong(phong);
        }
        public static bool XoaLoaiPhong(LoaiPhongDTO loaiPhongDTO)
        {
            return DAL.LoaiPhongDAL.XoaLoaiPhong(loaiPhongDTO);
        }
    }
}
