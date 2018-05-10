using DTO;
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

        public static LoaiPhongDTO LayLoaiPhong(PhongDTO phong)
        {
            DataTable resLoaiPhong = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong WHERE quanlykaraoke.loaiphong.MaLP = '" + phong.MaLoaiPhong.ToString() + "';");
            return new LoaiPhongDTO(Convert.ToInt32(resLoaiPhong.Rows[0]["MaLP"]), resLoaiPhong.Rows[0]["TenLoaiPhong"].ToString());
        }
    }
}
