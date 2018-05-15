using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.LoaiPhongDTO;

namespace DAL
{
    public class DonGia_LoaiPhongDAL
    {
        public static int PhatSinhMaDonGia_LoaiPhong()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.dongia_loaiphong.MaDonGiaPhong FROM quanlykaraoke.dongia_loaiphong ORDER BY quanlykaraoke.dongia_loaiphong.MaDonGiaPhong DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) +1;
        }
        public static bool ThemDonGiaTheoKhoangThoiGian(LoaiPhongDTO.DonGiaTheoTuan donGiaTuan)
        {
            
            foreach (DonGiaTheoNgay donGia in donGiaTuan.listDonGiaTheoNgay)
            {
                foreach (DonGiaTheoKhoangThoiGian donGiaTheoThoiGian in donGia.listDonGiaTheoKhoangThoiGian)
                {
                    StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.dongia_loaiphong (MaDonGiaPhong, MaLoaiPhong, GioBatDau, GioKetThuc, DonGia, Thu) VALUES('$0','$1','$2','$3','$4','$5')");
                    strSQL.Replace("$0", PhatSinhMaDonGia_LoaiPhong().ToString());
                    strSQL.Replace("$1", donGiaTuan.MaLoaiPhong.ToString());
                    strSQL.Replace("$2", donGiaTheoThoiGian.GioBatDau.hour.ToString() + ":00:00");
                    strSQL.Replace("$3", donGiaTheoThoiGian.GioKetThuc.hour.ToString() + ":00:00");
                    strSQL.Replace("$4", donGiaTheoThoiGian.DonGia.ToString());
                    strSQL.Replace("$5", donGia.NgayTrongTuan.ToString());
                    DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());
                }                
            }
            return true;
        }
    }
}
