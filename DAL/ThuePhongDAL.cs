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
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.thuephong.MaThuePhong + 1 FROM quanlykaraoke.thuephong ORDER BY quanlykaraoke.thuephong.MaThuePhong DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinThuePhong(ThuePhongDTO thuephongDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.thuephong (MaThuePhong, MaPhong,  GioThuePhong, GioTraPhong, MaHoaDon, TienGio) VALUES('$0','$1','$2',$3,'$4',$5)");
                strSQL.Replace("$0", thuephongDTO.MaThuePhong.ToString());
                strSQL.Replace("$1", thuephongDTO.MaPhong.ToString());
                strSQL.Replace("$2", thuephongDTO.GioThuePhong.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                strSQL.Replace("$3", (DateTime.Equals(DateTime.MinValue, thuephongDTO.GioTraPhong) ? ("NULL") : ("'" + thuephongDTO.GioTraPhong.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'")));
                strSQL.Replace("$4", thuephongDTO.MaHoaDon.ToString());
                strSQL.Replace("$5", double.IsNaN(thuephongDTO.TienGio)?"NULL": ("'" + thuephongDTO.TienGio.ToString()+ "'") );
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }

        public static Dictionary<int, PhongDTO> LayCacPhongDangSapDuocDat(int khoangThoiGian)
        {
            Dictionary<int, PhongDTO> res = new Dictionary<int, PhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM datphong, chitietdatphong WHERE MaTinhTrangDatPhong = '1' AND datphong.MaDatPhong = chitietdatphong.MaDatPhong AND ThoiGianDatPhong BETWEEN '"+DateTime.Now.AddMinutes(-ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue()).ToString("yyyy-MM-dd HH:mm:ss.fff")+ "' AND '" + DateTime.Now.AddMinutes(khoangThoiGian ).ToString("yyyy-MM-dd HH:mm:ss.fff") + "';");
            foreach (DataRow row in dt.Rows)
            {
                PhongDTO phongDTO = PhongDAL.LayThongTinPhong((int)row["MaPhong"]);
                if(!res.ContainsKey(phongDTO.MaPhong))
                    res.Add(phongDTO.MaPhong, phongDTO);
            }

            return res;
        }

       

        public static Dictionary<int, PhongDTO> LayCacPhongDangHetHanDat(int khoangThoiGian)
        {
            Dictionary<int, PhongDTO> res = new Dictionary<int, PhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM datphong, chitietdatphong WHERE MaTinhTrangDatPhong = '1' AND datphong.MaDatPhong = chitietdatphong.MaDatPhong AND ThoiGianDatPhong >= '" + DateTime.Now.AddMinutes(khoangThoiGian).ToString("yyyy-MM-dd HH:mm:ss.fff") + "';");
            foreach (DataRow row in dt.Rows)
            {
                PhongDTO phongDTO = PhongDAL.LayThongTinPhong((int)row["MaPhong"]);
                if (!res.ContainsKey(phongDTO.MaPhong))
                    res.Add(phongDTO.MaPhong, phongDTO);
            }

            return res;
        }



        public static bool XoaCacDichVuPhong(ThuePhongDTO thuePhongDTO)
        {
            DAL.DataProvider.ExecuseNonQuery("DELETE FROM dichvuphong WHERE dichvuphong.MaThuePhong = '"+thuePhongDTO.MaThuePhong+"';");
            return true;
        }

        public static Dictionary<int,ThuePhongDTO> LayThongTinPhongDangDuocThue()
        {
          
                Dictionary<int,ThuePhongDTO> res = new Dictionary<int, ThuePhongDTO>();

                DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM thuephong WHERE thuephong.MaHoaDon IN (SELECT hoadon.MaHoaDon FROM hoadon WHERE hoadon.TongTienThanhToan IS NULL) AND  (thuephong.GioTraPhong  IS NULL )");
                foreach (DataRow row in dt.Rows)
                {
                    ThuePhongDTO thuePhongDTO = new ThuePhongDTO((int)row["MaThuePhong"], (int)row["MaPhong"], DateTime.Parse(row["GioThuePhong"].ToString()), (row["GioTraPhong"].ToString()=="") ?(DateTime.MinValue):DateTime.Parse(row["GioTraPhong"].ToString()),(int)row["MaHoaDon"], (dt.Rows[0]["TienGio"].ToString() == "") ? (Double.NaN) : ((double)dt.Rows[0]["TienGio"]));


                    res.Add(thuePhongDTO.MaPhong,thuePhongDTO);
                }

                return res;

        
        }

        public static ThuePhongDTO LayThongTinPhongDangThue(PhongDTO phong)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM thuephong WHERE thuephong.MaHoaDon IN (SELECT hoadon.MaHoaDon FROM hoadon WHERE hoadon.TongTienThanhToan IS NULL) AND  (thuephong.GioTraPhong  IS NULL ) AND  quanlykaraoke.thuephong.MaPhong = '" + phong.MaPhong.ToString() + "';");

            return new ThuePhongDTO((int)dt.Rows[0]["MaThuePhong"], (int)dt.Rows[0]["MaPhong"],  DateTime.Parse(dt.Rows[0]["GioThuePhong"].ToString()), (dt.Rows[0]["GioTraPhong"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(dt.Rows[0]["GioTraPhong"].ToString()), (int)dt.Rows[0]["MaHoaDon"], (dt.Rows[0]["TienGio"].ToString() == "") ? (-1) : ((double)dt.Rows[0]["TienGio"]));

        }
        public static bool CapNhatThongTinThuePhong(ThuePhongDTO thuePhongDTO)
        {
            DAL.DataProvider.ExecuseQuery("UPDATE thuephong SET thuephong.GioTraPhong = '"+thuePhongDTO.GioTraPhong.ToString("yyyy-MM-dd HH:mm:ss.fff") + "', thuephong.GioThuePhong = '" + thuePhongDTO.GioThuePhong.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' , thuephong.TienGio = " + ((double.IsNaN(thuePhongDTO.TienGio))?("NULL"):("'" +(thuePhongDTO.TienGio).ToString() +"'")) + " WHERE thuephong.MaThuePhong = '" + thuePhongDTO.MaThuePhong+"'  ;");
            return true;
        }
        public static ThuePhongDTO LayThongTinThuePhong(int maThuePhong)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM thuephong WHERE thuephong.MaThuePhong = '"+maThuePhong+"';");

            return new ThuePhongDTO((int)dt.Rows[0]["MaThuePhong"], (int)dt.Rows[0]["MaPhong"], DateTime.Parse(dt.Rows[0]["GioThuePhong"].ToString()), (dt.Rows[0]["GioTraPhong"].ToString() == "") ? (DateTime.MinValue) : DateTime.Parse(dt.Rows[0]["GioTraPhong"].ToString()), (int)dt.Rows[0]["MaHoaDon"], (dt.Rows[0]["TienGio"].ToString() == "") ? (Double.NaN) : ((double)dt.Rows[0]["TienGio"]));

        }
        public static bool XoaThuePhong(ThuePhongDTO thuePhongDTO)
        {
            DAL.DataProvider.ExecuseNonQuery("DELETE FROM thuephong WHERE thuephong.MaThuePhong = '" + thuePhongDTO.MaThuePhong + "';");
            return true;
        }

    }
}
