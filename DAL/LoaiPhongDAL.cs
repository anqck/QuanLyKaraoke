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

        public static DataTable LayTatCaLoaiPhong_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong;");
        }

        public static List<LoaiPhongDTO> LayTatCaLoaiPhong_List()
        {
            List<LoaiPhongDTO> res = new List<LoaiPhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(new LoaiPhongDTO(Convert.ToInt32(row["MaLP"]), row["TenLoaiPhong"].ToString()));
            }

            return res;
        }

        public static LoaiPhongDTO LayLoaiPhong(PhongDTO phong)
        {
            DataTable resLoaiPhong = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong WHERE quanlykaraoke.loaiphong.MaLP = '" + phong.MaLoaiPhong.ToString() + "';");
            return new LoaiPhongDTO(Convert.ToInt32(resLoaiPhong.Rows[0]["MaLP"]), resLoaiPhong.Rows[0]["TenLoaiPhong"].ToString());
        }
        public static bool XoaLoaiPhong(LoaiPhongDTO loaiPhongDTO)
        {
            try
            {
                DAL.DataProvider.ExecuseNonQuery("DELETE FROM quanlykaraoke.loaiphong WHERE quanlykaraoke.loaiphong.MaLP = '"+loaiPhongDTO.MaLoaiPhong+"';");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool ThemLoaiPhong(int maLoaiPhong, string strTenLoaiPhong)
        {
            DAL.DataProvider.ExecuseNonQuery("INSERT INTO loaiphong(MaLP,TenLoaiPhong) VALUES ('"+maLoaiPhong.ToString()+"','"+ strTenLoaiPhong + "');");
            return true;
        }
        public static bool XoaDonGiaPhong(int maLoaiPhong)
        {
            try
            {
                DAL.DataProvider.ExecuseNonQuery("DELETE FROM quanlykaraoke.dongia_loaiphong WHERE quanlykaraoke.dongia_loaiphong.MaLoaiPhong = '" + maLoaiPhong + "';");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
