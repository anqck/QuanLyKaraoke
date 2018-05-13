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
    }
}
