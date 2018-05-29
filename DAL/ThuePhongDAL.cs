using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuePhongDAL
    {
        public static int PhatSinhMaThuePhong()
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.thuephong;").Rows[0][0]);
        }

        public static bool LuuThongTinThuePhong(ThuePhongDTO thuephongDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.thuephong (MaThuePhong, MaPhong,  GioThuePhong, GioTraPhong, MaHoaDon) VALUES('$0','$1','$2',$3,'$4')");
                strSQL.Replace("$0", thuephongDTO.MaThuePhong.ToString());
                strSQL.Replace("$1", thuephongDTO.MaPhong.ToString());
                strSQL.Replace("$2", thuephongDTO.GioThuePhong.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                strSQL.Replace("$3", (DateTime.Equals(DateTime.MinValue, thuephongDTO.GioTraPhong) ? ("NULL") : ("'" + thuephongDTO.GioTraPhong.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'")));
                strSQL.Replace("$4", thuephongDTO.MaHoaDon.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }

        public static Dictionary<int,ThuePhongDTO> LayThongTinPhongDangDuocThue()
        {
            try
            {
                Dictionary<int,ThuePhongDTO> res = new Dictionary<int, ThuePhongDTO>();

                DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM thuephong WHERE thuephong.MaHoaDon IN (SELECT hoadon.MaHoaDon FROM hoadon WHERE hoadon.TongTienThanhToan IS NULL) AND  (thuephong.GioTraPhong  IS NULL )");
                foreach (DataRow row in dt.Rows)
                {
                    ThuePhongDTO thuePhongDTO = new ThuePhongDTO((int)row["MaThuePhong"], (int)row["MaPhong"], DateTime.Parse(row["GioThuePhong"].ToString()), (row["GioTraPhong"].ToString()=="") ?(DateTime.MinValue):DateTime.Parse(row["GioTraPhong"].ToString()),(int)row["MaHoaDon"]);
                    res.Add(thuePhongDTO.MaPhong,thuePhongDTO);
                }

                return res;

            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static ThuePhongDTO LayThongTinPhongDangThue(PhongDTO phong)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM thuephong WHERE thuephong.MaHoaDon IN (SELECT hoadon.MaHoaDon FROM hoadon WHERE hoadon.TongTienThanhToan IS NULL) AND  (thuephong.GioTraPhong  IS NULL ) AND  quanlykaraoke.thuephong.MaPhong = '" + phong.MaPhong.ToString() + "';");

            return new ThuePhongDTO((int)dt.Rows[0]["MaThuePhong"], (int)dt.Rows[0]["MaPhong"],  DateTime.Parse(dt.Rows[0]["GioThuePhong"].ToString()), (dt.Rows[0]["GioTraPhong"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(dt.Rows[0]["GioTraPhong"].ToString()), (int)dt.Rows[0]["MaHoaDon"]);

        }
            
    }
}
