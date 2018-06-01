using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class DichVuBUS
    {
        

        public static int PhatSinhMaDichVu()
        {
            return DAL.DichVuDAL.PhatSinhMaDichVu();
        }

        public static bool LuuThongTinDichVu(DichVuDTO dichVuDTO)
        {
            return DAL.DichVuDAL.LuuThongTinDichVu(dichVuDTO);
        }

        public static DataTable LayTatCaDichVu_DataTable()
        {


            return DAL.DichVuDAL.LayTatCaDichVu_DataTable();
        }

        public static Dictionary<int, DichVuDTO> LayTatCaDichVu_Dictionary()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_Dictionary();
        }

        public static DichVuDTO LayThongTinDichVu(int maDichVu)
        {
            return DAL.DichVuDAL.LayThongTinDichVu(maDichVu);
        }

        public static List<DichVuDTO> LayTatCaDichVu_List()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_List();
        }

        public static int DemSoLuongDichVu(int maLoaiDV)
        {
            return DAL.DichVuDAL.DemSoLuongDichVu(maLoaiDV);
        }
        public static bool CapNhatThongTinDichVu(DichVuDTO dichVuDTO)
        {
            return DAL.DichVuDAL.CapNhatThongTinDichVu(dichVuDTO);
        }

        public static DataTable LayTatCaDichVu_LoaiDichVu()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_LoaiDichVu();
        }

        public static DataTable LayTatCaDichVu_LoaiDichVu_ExceptHuyVaKM()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_LoaiDichVu_ExceptHuyVaKM();
        }
        public static DataTable LayTatCaDichVu_LoaiDichVu_KM()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_LoaiDichVu_KM();
        }
    }
}
