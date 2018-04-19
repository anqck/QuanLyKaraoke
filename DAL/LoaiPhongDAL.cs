using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiPhongDAL
    {
        public static int PhatSinhMaLoaiPhong()
        {
            
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.loaiphong;").Rows[0][0]);
        }

        public static DataTable LayTatCaLoaiPhong()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong;");
        }
    }
}
