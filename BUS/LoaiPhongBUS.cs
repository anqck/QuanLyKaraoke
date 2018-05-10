using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiPhongBUS
    {
        public static int PhatSinhLoaiMaPhong()
        {
            return DAL.LoaiPhongDAL.PhatSinhMaLoaiPhong();
        }

        public static List<LoaiPhongDTO> LayTatCaLoaiPhong()
        {
            List<LoaiPhongDTO> res = new List<LoaiPhongDTO>();

            DataTable dt =  DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaiphong;");
            foreach(DataRow row in dt.Rows)
            {
                res.Add(new LoaiPhongDTO(Convert.ToInt32(row["MaLP"]),row["TenLoaiPhong"].ToString()));
            }

            return res;
        }

        public static LoaiPhongDTO LayLoaiPhong(PhongDTO phong)
        {
            return DAL.LoaiPhongDAL.LayLoaiPhong(phong);
        }
    }
}
