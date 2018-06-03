using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDichVuDAL
    {
        public static int PhatSinhMaLoaiDV()
        {

            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.loaidichvu;").Rows[0][0]);
        }

        public static DataTable LayTatCaLoaiDichVu_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaidichvu;");
        }

        public static LoaiDichVuDTO LayLoaiDichVu(DichVuDTO dichVu)
        {
            DataTable resLoaiPhong = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaidichvu WHERE quanlykaraoke.loaidichvu.MaLDV = '" + dichVu.MaLoaiDV.ToString() + "';");
            return new LoaiDichVuDTO(Convert.ToInt32(resLoaiPhong.Rows[0]["MaLDV"]), resLoaiPhong.Rows[0]["TenLDV"].ToString());
        }

        public static List<LoaiDichVuDTO> LayTatCaLoaiDichVu_List()
        {
            List<LoaiDichVuDTO> res = new List<LoaiDichVuDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaidichvu;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(new LoaiDichVuDTO(Convert.ToInt32(row["MaLDV"]), row["TenLDV"].ToString()));
            }

            return res;
        }


        public static bool XoaLoaiDichVu(int maLDV)
        {
            try
            {
                DAL.DataProvider.ExecuseQuery("DELETE FROM quanlykaraoke.loaidichvu WHERE MaLDV = '" + maLDV.ToString() + "';");
                return true;
            }
                catch(Exception e)
            {
                return false;
            }
        }
        public static int PhatSinhMaDichVu()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.loaidichvu.MaLDV FROM quanlykaraoke.loaidichvu ORDER BY quanlykaraoke.loaidichvu.MaLDV DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }
        public static bool LuuThongTinLoaiDichVu(LoaiDichVuDTO loaiDichVuDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.loaidichvu (MaLDV, TenLDV) VALUES('$0','$1')");
                strSQL.Replace("$0", loaiDichVuDTO.MaLoaiDV.ToString());
                strSQL.Replace("$1", loaiDichVuDTO.TenDV.ToString());
       
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool SuaThongTinLoaiDichVu(LoaiDichVuDTO loaiDichVuDTO)
        {
            try
            {
                DAL.DataProvider.ExecuseQuery("UPDATE  quanlykaraoke.loaidichvu SET quanlykaraoke.loaidichvu.TenLDV = '"+loaiDichVuDTO.TenDV+"' WHERE MaLDV = '" + loaiDichVuDTO.MaLoaiDV.ToString() + "';");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
