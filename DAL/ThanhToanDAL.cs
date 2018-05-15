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
        public static List<DonGiaTheoKhoangThoiGian> LayTatCaCacDonGiaNamTrongKhoang(Ngay ngay)
        {
            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau >= '"+ngay.GioBatDau.ToString()+"' and GioKetThuc <= '"+ ngay.GioKetThuc.ToString() + "' and Thu = '"+ngay.Thu+"';");

            foreach(DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(new Gio((TimeSpan)row["GioBatDau"]), new Gio((TimeSpan)row["GioKetThuc"]), (double)row["DonGia"]));
               
            }

            return list;
        }
        public static List<DonGiaTheoKhoangThoiGian> LayDonGiaMaGioBatDauNamTrong(Ngay ngay)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau < '" + ngay.GioBatDau.ToString() + "' and GioKetThuc > '" + ngay.GioBatDau.ToString() + "' and Thu = '" + ngay.Thu + "';");

            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(ngay.GioBatDau, new Gio((TimeSpan)dt.Rows[0]["GioKetThuc"]), Convert.ToInt32(dt.Rows[0]["DonGia"])));

            }

            return list;
        }
        public static List<DonGiaTheoKhoangThoiGian> LayDonGiaMaGiaKetThucNamTrong(Ngay ngay)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau < '" + ngay.GioKetThuc.ToString() + "' and GioKetThuc > '" + ngay.GioKetThuc.ToString() + "' and Thu = '" + ngay.Thu + "';");

            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(new Gio((TimeSpan)dt.Rows[0]["GioBatDau"]), ngay.GioKetThuc, Convert.ToInt32(dt.Rows[0]["DonGia"])));

            }

            return list;
        }
        public static List<DonGiaTheoKhoangThoiGian> LayDonGiaMaGioBatDauVaGioKetThucNamTrong(Ngay ngay)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.dongia_loaiphong WHERE GioBatDau < '" + ngay.GioKetThuc.ToString() + "' and GioKetThuc > '" + ngay.GioKetThuc.ToString() + "' and GioBatDau < '" + ngay.GioBatDau.ToString() + "' and GioKetThuc > '" + ngay.GioBatDau.ToString() + "'and Thu = '" + ngay.Thu + "';");

            List<DonGiaTheoKhoangThoiGian> list = new List<DonGiaTheoKhoangThoiGian>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DonGiaTheoKhoangThoiGian(ngay.GioBatDau, ngay.GioKetThuc, Convert.ToInt32(dt.Rows[0]["DonGia"])));

            }

            return list;
        }
    }
}
