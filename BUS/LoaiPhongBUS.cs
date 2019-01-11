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
        public static int PhatSinhLoaiMaLoaiPhong()
        {
            return DAL.LoaiPhongDAL.PhatSinhMaLoaiPhong();
        }

        public static DataTable LayTatCaLoaiPhong_DataTable_GroupByName()
        {
            return DAL.LoaiPhongDAL.LayTatCaLoaiPhong_DataTable_GroupByName();
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
        public static string GetFilterString_LoaiPhong(string str)
        {
            return "[TenLoaiPhong] = '" + str + "'";
        }
        public static bool ThemLoaiPhong(int maLoaiPhong, string strTenLoaiPhong)
        {
            return DAL.LoaiPhongDAL.ThemLoaiPhong(maLoaiPhong, strTenLoaiPhong);
        }
        public static bool XoaDonGiaPhong(int maLoaiPhong)
        {
            return DAL.LoaiPhongDAL.XoaDonGiaPhong(maLoaiPhong);
        }

        public static bool CapNhatLoaiPhong(LoaiPhongDTO loaiPhongDTO)
        {
            return DAL.LoaiPhongDAL.CapNhatLoaiPhong(loaiPhongDTO);
        }
    }
}
