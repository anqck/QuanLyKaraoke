using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DichVuDAL
    {
        public static int PhatSinhDichVu()
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.dichvu;").Rows[0][0]);
        }

        public static bool LuuThongTinDichVu(DichVuDTO dichVuDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.dichvu (MaDV, TenDV, DonGia, DonVi, MaLDV,HinhAnDV) VALUES('$0','$1','$2','$3','$4','$5')");
                strSQL.Replace("$0", dichVuDTO.MaDV.ToString());
                strSQL.Replace("$1", dichVuDTO.TenDV.ToString());
                strSQL.Replace("$2", dichVuDTO.DonGia.ToString());
                strSQL.Replace("$3", dichVuDTO.DonVi.ToString());
                strSQL.Replace("$4", dichVuDTO.MaLoaiDV.ToString());

                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(dichVuDTO.HinhAnh, typeof(byte[]));

                strSQL.Replace("$5", arr.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static DataTable LayTatCaDichVu_LoaiDichVu()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu, quanlykaraoke.loaidichvu where quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV ;");
        }

        public static Dictionary<int, DichVuDTO> LayTatCaDichVu_Dictionary()
        {
            try
            {
                Dictionary<int, DichVuDTO> res = new Dictionary<int, DichVuDTO>();

                DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu;");
                foreach (DataRow row in dt.Rows)
                {
                    DichVuDTO dichVuDTO = new DichVuDTO((int)row["MaDV"], row["TenDV"].ToString(), (double)row["donGia"], row["DonVi"].ToString(), (byte[])row["HinhAnh"], (int)row["MaLDV"]);
                    res.Add(dichVuDTO.MaDV, dichVuDTO);
                }

                return res;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static DataTable LayTatCaDichVu_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu;");
        }

        public static List<DichVuDTO> LayTatCaDichVu_List()
        {
            List<DichVuDTO> res = new List<DichVuDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dichvu;");
            foreach (DataRow row in dt.Rows)
            {
                DichVuDTO dichVuDTO = new DichVuDTO((int)row["MaDV"], row["TenDV"].ToString(), (double)row["donGia"], row["DonVi"].ToString(), (byte[])row["HinhAnh"], (int)row["MaLDV"]);
                res.Add( dichVuDTO);
            }

            return res;
        }
    }
}
