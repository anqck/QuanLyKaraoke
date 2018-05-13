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
        public static DataTable LayTatCaDichVu_DataTable()
        {


            return DAL.DichVuDAL.LayTatCaDichVu_DataTable();
        }

        public static Dictionary<int, DichVuDTO> LayTatCaDichVu_Dictionary()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_Dictionary();
        }



        public static List<DichVuDTO> LayTatCaDichVu_List()
        {
            return DAL.DichVuDAL.LayTatCaDichVu_List();
        }
    }
}
