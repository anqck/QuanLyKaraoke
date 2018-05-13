using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongDAL
    {

        public static int PhatSinhMaPhong()
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) + 1 FROM quanlykaraoke.phong;").Rows[0][0] ); 
        }

        public static bool CapNhatTinhTrangPhong(PhongDTO phongDTO,int maTinhTrangPhong)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("UPDATE quanlykaraoke.phong SET MaTinhTrangPhong = '$0' WHERE MaPhong = '$1'");
                strSQL.Replace("$1", phongDTO.MaPhong.ToString());
                strSQL.Replace("$0", maTinhTrangPhong.ToString());

                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public static Dictionary<string, PhongDTO> LayTatCaPhong()
        //{

        //    DataTable dt = DataProvider.ExecuseQuery("Select * FROM phong");

        //    Dictionary<string, PhongDTO> res = new Dictionary<string, PhongDTO>();

        //    for (int i = 0; i < dt.Rows.Count - 1; i++)
        //    {
        //        DTO.PhongDTO temp = new PhongDTO();
        //        temp.MaPhong = dt.Rows[i]["MaPhong"].ToString();

        //        res.Add(temp.MaPhong, temp);
        //    }

        //    return res;
        //}

        public static bool LuuThongTinPhong(PhongDTO phongDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.phong (MaPhong, TenPhong, MaTinhTrangPhong, MaLoaiPhong, GhiChu, Tang) VALUES('$0','$1','$2','$3','$4','$5')");
                strSQL.Replace("$0", phongDTO.MaPhong.ToString());
                strSQL.Replace("$1", phongDTO.TenPhong.ToString());
                strSQL.Replace("$2", phongDTO.MaTinhTrangPhong.ToString());
                strSQL.Replace("$3", phongDTO.MaLoaiPhong.ToString());
                strSQL.Replace("$4", phongDTO.GhiChu.ToString());
                strSQL.Replace("$5", phongDTO.Tang.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static DataTable LayTatCaPhong_TinhTrangPhong_LoaiPhong()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong,quanlykaraoke.loaiphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong and quanlykaraoke.phong.MaLoaiPhong = quanlykaraoke.loaiphong.MaLP ;");
        }

        public static DataTable LayTatCaPhong_TinhTrangPhong()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong;");
        }

        public static List<String> LayCacTangCoSan()
        {
            List<String> res = new List<string>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT quanlykaraoke.phong.tang FROM quanlykaraoke.phong group by quanlykaraoke.phong.tang;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(row[0].ToString());
            }

            return res;
        }

      

        public static void LuuPhongMoi(PhongDTO phong)
        {
            //DAL.DataProvider.ExecuseNonQuery("Insert into ")
        }
    }
}
