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

        public static bool LuuThongTinPhong(ThuePhongDTO thuephongDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.thuephong (MaThuePhong, MaPhong, MaKH, GioThuePhong, TienTraTruoc, MaTrangThaiThuePhong) VALUES('$0','$1','$2','$3','$4','$5')");
                strSQL.Replace("$0", thuephongDTO.MaThuePhong.ToString());
                strSQL.Replace("$1", thuephongDTO.MaPhong.ToString());
                strSQL.Replace("$2", thuephongDTO.MaKH.ToString());
                strSQL.Replace("$3", thuephongDTO.GioThuePhong.ToString());
                strSQL.Replace("$4", thuephongDTO.TienTraTruoc.ToString());
                strSQL.Replace("$5", thuephongDTO.MaTrangThaiThuePhong.ToString());
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

                DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.thuephong, quanlykaraoke.trangthaithuephong WHERE quanlykaraoke.thuephong.MaTrangThaiThuePhong = quanlykaraoke.trangthaithuephong.MaTrangThaiThuePhong AND quanlykaraoke.trangthaithuephong.LoaiTrangThai = 'Đang thuê' ;");
                foreach (DataRow row in dt.Rows)
                {
                    ThuePhongDTO thuePhongDTO = new ThuePhongDTO((int)row["MaThuePhong"], (int)row["MaPhong"], (int)row["MaKH"], DateTime.Parse(row["GioThuePhong"].ToString()), (double)row["TienTraTruoc"], (int)row["MaTrangThaiThuePhong"]);
                    res.Add(thuePhongDTO.MaPhong,thuePhongDTO);
                }

                return res;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
