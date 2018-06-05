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
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.ngayle.MaNgayLe FROM quanlykaraoke.ngayle ORDER BY quanlykaraoke.ngayle.MaNgayLe DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static DataTable LayTatCaNgayLe_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.ngayle ;");
        }
        public static bool KiemTraNgayLeTonTai(DateTime dt)
        {
            
           return (DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.ngayle WHERE NgayLe = '" + dt.ToString("yyyy-MM-dd") + "' ;").Rows.Count >= 1);
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
            DAL.DataProvider.ExecuseNonQuery("UPDATE ngayle SET ngayle.NgayLe = '" + ngayLe.NgayLe.ToString("yyyy-MM-dd") + "' WHERE ngayle.MaNgayLe = '" + ngayLe.MaNgayLe + "' ;");
            return true;
        }
        public static bool XoaNgayLe(int maNgayLe)
        {
            DAL.DataProvider.ExecuseNonQuery("DELETE FROM ngayle WHERE ngayle.MaNgayLe = '"+maNgayLe+"';");
            return true;
        }
    }
}
