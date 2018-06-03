using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThamSoDAL
    {
        public static double GetTyLeQuyDoiDiemTien()
        {
            return Double.Parse(DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.thamso WHERE MaThamSo = '0';").Rows[0]["GiaTri"].ToString());

        }
    }
}
