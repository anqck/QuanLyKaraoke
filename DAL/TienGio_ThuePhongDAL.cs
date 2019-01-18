using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TienGio_ThuePhongDAL
    {
        public static int PhatSinhMaTienGio_ThuePhong()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.tiengio_thuephong.MaTienGio_ThuePhong FROM quanlykaraoke.tiengio_thuephong ORDER BY quanlykaraoke.tiengio_thuephong.MaTienGio_ThuePhong DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static DataTable LayTienGio_ThuePhong_DataTable(int maThuePhong)
        {

            return DataProvider.ExecuseQuery("SELECT * FROM tiengio_thuephong  WHERE tiengio_thuephong.MaThuePhong  = '" + maThuePhong + "';");
            
        }

        public static bool LuuTienGio_ThuePhong(TienGio_ThuePhongDTO tienThuePhongDTO)
        {
            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `quanlykaraoke`.`tiengio_thuephong` (`MaTienGio_ThuePhong`, `Ngay`, `KhoangThoiGian`, `DonGia`, `SoLuong`, `MaThuePhong`) VALUES ('$0', '$1', '$2', '$3', '$4', '$5');");
            stringBuilder.Replace("$0", tienThuePhongDTO.MaTienGio_ThuePhong.ToString());
            stringBuilder.Replace("$1", tienThuePhongDTO.Ngay.ToString());
            stringBuilder.Replace("$2", tienThuePhongDTO.KhoangThoiGian.ToString());
            stringBuilder.Replace("$3", tienThuePhongDTO.DonGia.ToString());
            stringBuilder.Replace("$4", tienThuePhongDTO.SoLuong.ToString());
            stringBuilder.Replace("$5", tienThuePhongDTO.MaThuePhong.ToString());
            
            DataProvider.ExecuseNonQuery(stringBuilder.ToString());
            return true;
        }
    }
}
