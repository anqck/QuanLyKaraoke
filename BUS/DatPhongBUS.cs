using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DatPhongBUS
    {
        public static int PhatSinhMaDatPhong()
        {
            return DAL.DatPhongDAL.PhatSinhMaDatPhong();
        }
        public static DataTable LayCacPhongConTrongTrongThoiGian(DateTime time, int khoangThoiGianToiThieu)
        {
            return DAL.DatPhongDAL.LayCacPhongConTrongTrongThoiGian(time, khoangThoiGianToiThieu);

        }



        public static DateTime LayThoiDiemDatPhongGanNhat_Sau(int maPhong, DateTime thoiDiem)
        {
            return DAL.DatPhongDAL.LayThoiDiemDatPhongGanNhat_Sau(maPhong, thoiDiem);
        }

        public static DateTime LayThoiDiemDatPhongGanNhat_Truoc(int maPhong, DateTime thoiDiem)
        {
            return DAL.DatPhongDAL.LayThoiDiemDatPhongGanNhat_Truoc(maPhong, thoiDiem);
        }
        public static bool LuuThongTinDatPhong(DatPhongDTO datPhongDTO)
        {
            return DAL.DatPhongDAL.LuuThongTinDatPhong(datPhongDTO);
        }

        public static DatPhongDTO LayThongTinDatPhong(int maDatPhong)
        {
            return DAL.DatPhongDAL.LayThongTinDatPhong(maDatPhong);

        }
        public static List<DatPhongDTO> LayTatCaCacDatPhong(int maPhong)
        {
            return DAL.DatPhongDAL.LayTatCaCacDatPhong(maPhong);
        }
        public static DataTable LayTatCaDatPhong_TinhTrangPhong_KhachHang_NhanVien_DataTable()
        {
            return DAL.DatPhongDAL.LayTatCaDatPhong_TinhTrangPhong_KhachHang_NhanVien_DataTable();
        }

        public static DataTable LayThongTinDatPhong_table(int maDatPhong)
        {
            return DAL.DatPhongDAL.LayThongTinDatPhong_table(maDatPhong);
        }

        public static DataTable LayTatCaDatPhong_ChiTietDatPhong_DataTable()
        {
            return DAL.DatPhongDAL.LayTatCaDatPhong_ChiTietDatPhong_DataTable();
        }

        public static TinhTrangDatPhongDTO LayTinhTrangPhong(int maTinhTrangPhong)
        {
            return DAL.DatPhongDAL.LayTinhTrangPhong(maTinhTrangPhong);
        }

        public static List<TinhTrangDatPhongDTO> LayTatCaTinhTrangDatPhong_List()
        {
            return DAL.DatPhongDAL.LayTatCaTinhTrangDatPhong_List();
        }
        public static void UpdateKhachHang(int maDatPhong, int maKH)
        {
            DAL.DatPhongDAL.UpdateKhachHang(maDatPhong, maKH);
        }
        public static List<ChiTietDatPhongDTO> LayTatCaCacChiTietDatPhong(int maDatPhong)
        {
            return DAL.DatPhongDAL.LayTatCaCacChiTietDatPhong(maDatPhong);
        }
        public static DataTable LayTatCaCacChiTietDatPhong_table(int maDatPhong)
        {
            return DAL.DatPhongDAL.LayTatCaCacChiTietDatPhong_table(maDatPhong);
        }

        public static void XoaCacDichVuDatPhong(ChiTietDatPhongDTO chiTietDatPhong)
        {
            DAL.DatPhongDAL.XoaCacDichVuDatPhong(chiTietDatPhong);
        }
        public static void XoaDatChiTietDatPhong(ChiTietDatPhongDTO chiTietDatPhong)
        {
            DAL.DatPhongDAL.XoaChiTietDatPhong(chiTietDatPhong);
        }
        public static int DemSoLuongChiTietDatPhong(int maDatPhong)
        {
            return DAL.DatPhongDAL.DemSoLuongChiTietDatPhong(maDatPhong);
        }
        public static bool XoaDatPhong(int maDatPhong)
        {
            return DAL.DatPhongDAL.XoaDatPhong(maDatPhong);
        }
        public static void CapNhatTinhTrangDatPhong(int value, int MaDatPhong)
        {
            DAL.DatPhongDAL.CapNhatTinhTrangDatPhong(value, MaDatPhong);
        }
        public static Dictionary<int, DatPhongDTO> LayCacDatPhongDangHetHanDat(int khoangThoiGian)
        {
            return DAL.DatPhongDAL.LayCacDatPhongDangHetHanDat(khoangThoiGian);

        }
        public static DatPhongDTO LayThongTinThuePhongCuaPhongDangDat(int maPhong, DateTime now)
        {
            return DAL.DatPhongDAL.LayThongTinThuePhongCuaPhongDangDat(maPhong, now);
        }
        public static DataTable LayTatCaCacDatPhongTrongTuongLai(int maPhong)
        {
            return DAL.DatPhongDAL.LayTatCaCacDatPhongTrongTuongLai(maPhong);
        }

        public static Dictionary<int, DatPhongDTO> LayCacDatPhongDangSapDuocDatVaDangDuocDat(int khoangThoiGian)
        {
            return DAL.DatPhongDAL.LayCacDatPhongDangSapDuocDatVaDangDuocDat(khoangThoiGian);

        }

        public static Dictionary<int, ChiTietDatPhongDTO> LayCacChiTietDatPhongDangSapDuocDatVaDangDuocDat(int khoangThoiGian)
        {
            return DAL.DatPhongDAL.LayCacChiTietDatPhongDangSapDuocDatVaDangDuocDat(khoangThoiGian);

        }

        public static void CapNhatTienTraTruocDatPhong(double value, int maDatPhong)
        {
            DAL.DatPhongDAL.CapNhatTienTraTruocDatPhong(value, maDatPhong);
        }
        public static void CapNhatGhiChuDatPhong(double value, int maDatPhong)
        {
            DAL.DatPhongDAL.CapNhatGhiChuDatPhong(value, maDatPhong);
        }
    }
}
