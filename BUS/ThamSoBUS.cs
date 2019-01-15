using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThamSoBUS
    {
        public static double QuyDoiDiem(double TongTien)
        {
            return DAL.ThamSoDAL.GetTyLeQuyDoiDiemTien()*(TongTien/1000);

        }

        public static int LayKhoangThoiGianToiThieuGiuaHaiLanThue()
        {
            return DAL.ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue();
        }

        public static int LayKhoangThoiGianChoDatPhong()
        {
            return DAL.ThamSoDAL.LayKhoangThoiGianChoDatPhong();
        }

        public static int LayKhoangThoiGianTuDongHuyDatPhong()
        {
            return DAL.ThamSoDAL.LayKhoangThoiGianTuDongHuyDatPhong();
        }

        public static bool LayChuyenSangChoDonDepSauKhiThanhToan()
        {
            return DAL.ThamSoDAL.LayChuyenSangChoDonDepSauKhiThanhToan();

        }

        public static void SetKChuyenSangChoDonDepSauKhiThanhToan(bool b)
        {
            DAL.ThamSoDAL.SetKChuyenSangChoDonDepSauKhiThanhToan(b);

        }

        public static void SetTyLeQuyDoiDiemTien(double i)
        {
            DAL.ThamSoDAL.SetTyLeQuyDoiDiemTien(i);

        }

        public static void SetKhoangThoiGianTuDongHuyDatPhong(int i)
        {
            DAL.ThamSoDAL.SetKhoangThoiGianTuDongHuyDatPhong(i);
        }
        public static void SetKhoangThoiGianToiThieuGiuaHaiLanThue(int i)
        {
            DAL.ThamSoDAL.SetKhoangThoiGianToiThieuGiuaHaiLanThue(i);

        }

        public static void SetKhoangThoiGianChoDatPhong(int i)
        {
            DAL.ThamSoDAL.SetKhoangThoiGianChoDatPhong(i);

        }

        //static double Round(double value, int digits)
        //{
        //    if (digits >= 0) return Math.Round(value, digits);

        //    double n = Math.Pow(10, -digits);
        //    return Math.Round(value / n, 0) * n;
        //}
        static long RoundingTo(long myNum, long roundTo)
        {
            if (roundTo <= 0) return myNum;
            return (myNum + roundTo / 2) / roundTo * roundTo;
        }

        public static double GetSoTienLamTron(double soTien)
        {
            return RoundingTo(Convert.ToInt64(soTien), 500);

        }
    }
}
