using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.ThongTinThanhToanTheoNgay;
using static DTO.LoaiPhongDTO;
using System.Data;

namespace DAL
{
    public class ThanhToanDAL
    {
        public static int PhatSinhMaHoaDon()
        {
            DataTable dt =DataProvider.ExecuseQuery("SELECT quanlykaraoke.hoadon.MaHoaDon FROM quanlykaraoke.hoadon ORDER BY quanlykaraoke.hoadon.MaHoaDon DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static List<DonGiaTheoKhoangThoiGian> LayTatCaCacDonGiaNamTrongKhoang(Ngay ngay, int maLoaiPhong)
        {
            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau >= '"+ngay.GioBatDau.ToString()+"' and GioKetThuc <= '"+ ngay.GioKetThuc.ToString() + "' and Thu = '"+ngay.Thu+"' and MaLoaiPhong = '"+maLoaiPhong+"';");

            foreach(DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(new Gio((TimeSpan)row["GioBatDau"]), new Gio((TimeSpan)row["GioKetThuc"]), (double)row["DonGia"]));
               
            }

            return list;
        }
        public static List<DonGiaTheoKhoangThoiGian> LayDonGiaMaGioBatDauNamTrong(Ngay ngay, int maLoaiPhong)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau < '" + ngay.GioBatDau.ToString() + "' and GioKetThuc > '" + ngay.GioBatDau.ToString() + "' and Thu = '" + ngay.Thu + "' and MaLoaiPhong = '" + maLoaiPhong + "';");

            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(ngay.GioBatDau, new Gio((TimeSpan)dt.Rows[0]["GioKetThuc"]), Convert.ToInt32(dt.Rows[0]["DonGia"])));

            }

            return list;
        }
        public static List<DonGiaTheoKhoangThoiGian> LayDonGiaMaGiaKetThucNamTrong(Ngay ngay, int maLoaiPhong)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau < '" + ngay.GioKetThuc.ToString() + "' and GioKetThuc > '" + ngay.GioKetThuc.ToString() + "' and Thu = '" + ngay.Thu + "' and MaLoaiPhong = '" + maLoaiPhong + "';");

            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(new Gio((TimeSpan)dt.Rows[0]["GioBatDau"]), ngay.GioKetThuc, Convert.ToInt32(dt.Rows[0]["DonGia"])));

            }

            return list;
        }
        public static List<DonGiaTheoKhoangThoiGian> LayDonGiaMaGioBatDauVaGioKetThucNamTrong(Ngay ngay, int maLoaiPhong)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau < '" + ngay.GioKetThuc.ToString() + "' and GioKetThuc > '" + ngay.GioKetThuc.ToString() + "' and GioBatDau < '" + ngay.GioBatDau.ToString() + "' and GioKetThuc > '" + ngay.GioBatDau.ToString() + "'and Thu = '" + ngay.Thu + "' and MaLoaiPhong = '" + maLoaiPhong + "';");

            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(ngay.GioBatDau, ngay.GioKetThuc, Convert.ToInt32(dt.Rows[0]["DonGia"])));

            }

            return list;
        }
    }
}
