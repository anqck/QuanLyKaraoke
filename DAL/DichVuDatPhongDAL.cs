using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DichVuDatPhongDAL
    {
        public static int PhatSinhMaDichVuPhong()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.dichvudatphong.MaDichVuDatPhong FROM quanlykaraoke.dichvudatphong ORDER BY quanlykaraoke.dichvudatphong.MaDichVuDatPhong DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinDichVuDatPhong(DichVuDatPhongDTO dichVuPhongDTO)
        {

     
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.dichvudatphong (MaDichVuDatPhong, MaDichVu, SoLuong , Gia, MaChiTietDatPhong) VALUES('$0','$1','$2','$3','$4')");
                strSQL.Replace("$0", dichVuPhongDTO.MaDichVuDatPhong.ToString());
                strSQL.Replace("$1", dichVuPhongDTO.MaDichVu.ToString());
                strSQL.Replace("$2", dichVuPhongDTO.SoLuong.ToString());
                strSQL.Replace("$3", dichVuPhongDTO.DonGia.ToString());
                strSQL.Replace("$4", dichVuPhongDTO.MaChiTietDatPhong.ToString());


                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
        }

        public static bool UpdateDichVuDatPhong(DichVuDatPhongDTO dichVuDatPhongDTO)
        {
            
                DataProvider.ExecuseNonQuery("UPDATE  quanlykaraoke.dichvudatphong SET  quanlykaraoke.dichvudatphong.SoLuong = '" + dichVuDatPhongDTO.SoLuong + "',  quanlykaraoke.dichvudatphong.Gia ='" + dichVuDatPhongDTO.DonGia + "' WHERE  quanlykaraoke.dichvudatphong.MaDichVuDatPhong = '" + dichVuDatPhongDTO.MaDichVuDatPhong + "';");

            return true;
        }

        public static bool XoaDichVuDatPhong(int maDVP)
        {
            
                DataProvider.ExecuseNonQuery("DELETE FROM  quanlykaraoke.dichvudatphong  WHERE  quanlykaraoke.dichvudatphong.MaDichVuDatPhong = '" + maDVP + "';");

            return true;
        }

        public static DataTable LayTatCaDichVuDatPhong_DichVu_LoaiDV(ChiTietDatPhongDTO chiTietDatPhong)
        {
            return DataProvider.ExecuseQuery("SELECT MaDichVuDatPhong,dichvudatphong.MaChiTietDatPhong, dichvudatphong.MaDichVu,SoLuong, Gia, TenDV, DonVi, dichvu.MaLDV, TenLDV FROM quanlykaraoke.dichvudatphong,quanlykaraoke.dichvu,quanlykaraoke.loaidichvu  WHERE  quanlykaraoke.dichvudatphong.MaDichVu = quanlykaraoke.dichvu.MaDV AND quanlykaraoke.dichvu.MaLDV = quanlykaraoke.loaidichvu.MaLDV AND dichvudatphong.MaChiTietDatPhong = '"+chiTietDatPhong.MaChiTietDatPhong+"'; ");

        }
    }
}
