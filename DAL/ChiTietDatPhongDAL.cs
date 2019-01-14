using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietDatPhongDAL
    {
        public static int PhatSinhMaChiTietDatPhong()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.chitietdatphong.MaChiTietDatPhong FROM quanlykaraoke.chitietdatphong ORDER BY quanlykaraoke.chitietdatphong.MaChiTietDatPhong DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinDatPhong(ChiTietDatPhongDTO datPhongDTO)
        {
            StringBuilder stringBuilder = new StringBuilder("INSERT INTO `quanlykaraoke`.`chitietdatphong` (`MaChiTietDatPhong`, `MaPhong`, `MaDatPhong`) VALUES ('$0', '$1', '$2');");
            stringBuilder.Replace("$0", datPhongDTO.MaChiTietDatPhong.ToString());
            stringBuilder.Replace("$1", datPhongDTO.MaPhong.ToString());
            stringBuilder.Replace("$2", datPhongDTO.MaDatPhong.ToString());


            DataProvider.ExecuseNonQuery(stringBuilder.ToString());
            return true;
        }

        public static DataTable LayTatCaChiTietDatPhong_DataTable(int maDatPhong)
        {
            DataTable res= DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.chitietdatphong,quanlykaraoke.loaiphong,quanlykaraoke.phong WHERE chitietdatphong.MaPhong=phong.MaPhong AND phong.MaLoaiPhong = loaiphong.MaLP  AND chitietdatphong.MaDatPhong= '"+maDatPhong+"  '  ;");
            res.TableName = "DsPhongDat";
            return res;
        }

        public static DataTable LayTatCaChiTietDatPhong_DataTable()
        {
            return DataProvider.ExecuseQuery("SELECT * FROM chitietdatphong ;");

        }
        public static bool CapNhatThongTinDatPhong(ChiTietDatPhongDTO chiTietDatPhongDTO)
        {
             DataProvider.ExecuseNonQuery("UPDATE chitietdatphong SET MaPhong = '"+chiTietDatPhongDTO.MaPhong+"'  WHERE MaChiTietDatPhong = '" + chiTietDatPhongDTO .MaChiTietDatPhong+ "'  ;");
            return true;
        }

    }
}
