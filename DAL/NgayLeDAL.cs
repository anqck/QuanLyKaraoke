using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NgayLeDAL
    {
        public static int PhatSinhMaNgayLe()
        {

            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.ngayle;").Rows[0][0]);
        }

        public static DataTable LayTatCaNgayLe_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.ngayle;");
        }

        public static List<NgayLeDTO> LayTatCaNgayLe_List()
        {
            List<NgayLeDTO> res = new List<NgayLeDTO>();
            foreach (DataRow row in DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.ngayle;").Rows)
            {
                res.Add(new NgayLeDTO((int)row["MaNgayLe"], (DateTime)row["NgayLe"]));
            }
            return res;
        }

        public static bool ThemNgayLe(NgayLeDTO ngayLe)
        {
            DAL.DataProvider.ExecuseNonQuery("INSERT INTO ngayle(MaNgayLe,NgayLe) VALUES ('" + ngayLe.MaNgayLe + "','" + ngayLe.NgayLe.ToString("yyyy-MM-dd") + "');");
            return true;
        }
        public static bool SuaNgayLe(NgayLeDTO ngayLe)
        {
            DAL.DataProvider.ExecuseNonQuery("UPDATE SET ngayle.NgayLe = '" + ngayLe.NgayLe.ToString("yyyy-MM-dd") + "','" + ngayLe.NgayLe.ToString("yyyy-MM-dd") + "' WHERE ngayle.MaNgayLe = '" + ngayLe.MaNgayLe + "' ;");
            return true;
        }
        public static bool XoaNgayLe(int maNgayLe)
        {
            DAL.DataProvider.ExecuseNonQuery("DELETE FROM ngayle WHERE ngayle.MaNgayLe = '"+maNgayLe+"';");
            return true;
        }
    }
}
