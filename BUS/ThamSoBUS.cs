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
            return DAL.ThamSoDAL.GetTyLeQuyDoiDiemTien()*TongTien;

        }

        public static int LayKhoangThoiGianToiThieuGiuaHaiLanThue()
        {
            return DAL.ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue();
        }

        public static int LayKhoangThoiGianChoDatPhong()
        {
            return DAL.ThamSoDAL.LayKhoangThoiGianChoDatPhong();
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

        public static void SetKhoangThoiGianToiThieuGiuaHaiLanThue(int i)
        {
            DAL.ThamSoDAL.SetKhoangThoiGianToiThieuGiuaHaiLanThue(i);

        }

        public static void SetKhoangThoiGianChoDatPhong(int i)
        {
            DAL.ThamSoDAL.SetKhoangThoiGianChoDatPhong(i);

        }
    }
}
