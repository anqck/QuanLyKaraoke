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

        public static Dictionary<string, PhongDTO> LayTatCaPhong()
        {

            DataTable dt = DataProvider.ExecuseQuery("Select * FROM phong");

            Dictionary<string, PhongDTO> res = new Dictionary<string, PhongDTO>();

            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                DTO.PhongDTO temp = new PhongDTO();
                temp.MaPhong = dt.Rows[i]["MaPhong"].ToString();

                res.Add(temp.MaPhong, temp);
            }

            return res;
        }
 
    }
}
