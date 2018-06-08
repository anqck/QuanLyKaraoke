using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThamSoDAL
    {
        public static double GetTyLeQuyDoiDiemTien()
        {
            return Double.Parse(DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.thamso WHERE MaThamSo = '0';").Rows[0]["GiaTri"].ToString());

        }

        public static int LayKhoangThoiGianToiThieuGiuaHaiLanThue()
        {
            return int.Parse(DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.thamso WHERE MaThamSo = '1';").Rows[0]["GiaTri"].ToString());

        }

        public static int LayKhoangThoiGianChoDatPhong()
        {
            return int.Parse(DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.thamso WHERE MaThamSo = '2';").Rows[0]["GiaTri"].ToString());

        }

        public static void SetTyLeQuyDoiDiemTien(double i)
        {
           DataProvider.ExecuseNonQuery("UPDATE quanlykaraoke.thamso SET GiaTri = '" + i + "' WHERE MaThamSo = '0';");

        }

        public static void SetKhoangThoiGianToiThieuGiuaHaiLanThue(int i)
        {
            DataProvider.ExecuseNonQuery("UPDATE quanlykaraoke.thamso SET GiaTri = '" + i + "' WHERE MaThamSo = '1';");

        }

        public static void SetKhoangThoiGianChoDatPhong(int i)
        {
            DataProvider.ExecuseNonQuery("UPDATE quanlykaraoke.thamso SET GiaTri = '" + i + "' WHERE MaThamSo = '2';");

        }
    }
}
