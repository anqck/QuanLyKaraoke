using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatPhongDAL
    {
        public static int PhatSinhMaDatPhong()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.datphong.MaDatPhong FROM quanlykaraoke.datphong ORDER BY quanlykaraoke.datphong.MaDatPhong DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static DataTable LayCacPhongConTrongTrongThoiGian(DateTime time, int khoangThoiGianToiThieu)
        {
            return DataProvider.ExecuseQuery("SELECT * FROM loaiphong, phong WHERE loaiphong.MaLP = phong.MaLoaiPhong AND phong.MaPhong NOT IN (SELECT MaPhong FROM datphong, chitietdatphong WHERE MaTinhTrangDatPhong = 1 AND datphong.MaDatPhong = chitietdatphong.MaDatPhong AND ThoiGianDatPhong BETWEEN '" + time.AddMinutes(-khoangThoiGianToiThieu).ToString("yyyy-MM-dd HH:mm:ss.fff") + "' AND '" + time.AddMinutes(khoangThoiGianToiThieu).ToString("yyyy-MM-dd HH:mm:ss.fff") + "') AND MaTinhTrangPhong <> 2;");

        }

        public static DataTable LayTatCaDatPhong_TinhTrangPhong_KhachHang_NhanVien_DataTable()
        {
            return DataProvider.ExecuseQuery("SELECT MaDatPhong, ThoiGianDatPhong, datphong.SoTienDatTruoc,khachhang.TenKH,khachhang.SDT,TenNhanVien,GhiChu,TinhTrangDatPhong FROM datphong, tinhtrangdatphong, khachhang, nhanvien WHERE datphong.MaTinhTrangDatPhong = tinhtrangdatphong.MaTinhTrangDatPhong AND datphong.MaNhanVien = nhanvien.MaNhanVien AND datphong.MaKH = khachhang.MaKH  ;");

        }

        public static List<DatPhongDTO> LayTatCaCacDatPhong(int maPhong)
        {
            List<DatPhongDTO> listDatPhong = new List<DatPhongDTO>();
            foreach(DataRow row in DataProvider.ExecuseQuery("SELECT * FROM datphong, chitietdatphong WHERE datphong.MaDatPhong = chitietdatphong.MaDatPhong AND chitietdatphong.MaPhong = '"+maPhong+"';").Rows)
            {
                listDatPhong.Add(new DatPhongDTO((int)row["MaDatPhong"], DateTime.Parse(row["ThoiGianDatPhong"].ToString()), (double)row["SoTienDatTruoc"], (int)row["MaNhanVien"], (int)row["MaKH"], row["GhiChu"].ToString(), (int)row["MaTinhTrangDatPhong"]));
            }
            return listDatPhong;

        }

        public static DatPhongDTO LayThongTinDatPhong(int maDatPhong)
        {

            DataTable dt = DataProvider.ExecuseQuery("SELECT * FROM datphong  WHERE datphong.MaDatPhong  = '" + maDatPhong + "';");
         
            return new DatPhongDTO((int)dt.Rows[0]["MaDatPhong"], DateTime.Parse(dt.Rows[0]["ThoiGianDatPhong"].ToString()), (double)dt.Rows[0]["SoTienDatTruoc"], (int)dt.Rows[0]["MaNhanVien"], (int)dt.Rows[0]["MaKH"], dt.Rows[0]["GhiChu"].ToString(), (int)dt.Rows[0]["MaTinhTrangDatPhong"]);

        }

        public static bool LuuThongTinDatPhong(DatPhongDTO datPhongDTO)
        {
            StringBuilder stringBuilder =  new StringBuilder("INSERT INTO `quanlykaraoke`.`datphong` (`MaDatPhong`, `ThoiGianDatPhong`, `SoTienDatTruoc`, `MaNhanVien`, `MaKH`, `GhiChu`, `MaTinhTrangDatPhong`) VALUES ('$0', '$1', '$2', '$3', '$4', '$5', '$6');");
            stringBuilder.Replace("$0", datPhongDTO.MaDatPhong.ToString());
            stringBuilder.Replace("$1", datPhongDTO.ThoiGianDatPhong.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            stringBuilder.Replace("$2", datPhongDTO.SoTienDatTruoc.ToString());
            stringBuilder.Replace("$3", datPhongDTO.MaNhanVien.ToString());
            stringBuilder.Replace("$4", datPhongDTO.MaKH.ToString());
            stringBuilder.Replace("$5", datPhongDTO.GhiChu.ToString());
            stringBuilder.Replace("$6", datPhongDTO.MaTinhTrangDatPhong.ToString());

            DataProvider.ExecuseNonQuery(stringBuilder.ToString());
            return true;
        }

        public static DataTable LayTatCaCacDatPhongTrongTuongLai(int maPhong)
        {
            return DataProvider.ExecuseQuery("SELECT datphong.MaDatPhong, datphong.ThoiGianDatPhong, datphong.MaTinhTrangDatPhong FROM quanlykaraoke.datphong, quanlykaraoke.chitietdatphong WHERE quanlykaraoke.datphong.MaDatPhong = quanlykaraoke.chitietdatphong.MaDatPhong AND quanlykaraoke.datphong.ThoiGianDatPhong > now() AND datphong.MaTinhTrangDatPhong = '1' AND MaPhong = '" + maPhong+"';");

        }

        public static DataTable LayTatCaDatPhong_ChiTietDatPhong_DataTable()
        {
            return DataProvider.ExecuseQuery("SELECT * FROM datphong, chitietdatphong WHERE datphong.MaDatPhong = chitietdatphong.MaDatPhong;");   
        }

        public static TinhTrangDatPhongDTO LayTinhTrangPhong(int maTinhTrangPhong)
        {
            DataRow row = DataProvider.ExecuseQuery("SELECT * FROM tinhtrangdatphong WHERE tinhtrangdatphong.MaTinhTrangDatPhong = '" + maTinhTrangPhong + "';").Rows[0];
            return new TinhTrangDatPhongDTO((int)row["MaTinhTrangDatPhong"], row["TinhTrangDatPhong"].ToString());
        }

        public static List<TinhTrangDatPhongDTO> LayTatCaTinhTrangDatPhong_List()
        {
            List<TinhTrangDatPhongDTO> res = new List<TinhTrangDatPhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.tinhtrangdatphong;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(new TinhTrangDatPhongDTO(Convert.ToInt32(row["MaTinhTrangDatPhong"]), row["TinhTrangDatPhong"].ToString()));
            }

            return res;
        }
        public static bool UpdateKhachHang(int maDatPhong, int maKH)
        {
            DataProvider.ExecuseNonQuery("UPDATE datphong SET datphong.MaKH = '" + maKH + "'  WHERE datphong.MaDatPhong = '" + maDatPhong + "';");
            return true;
        }

        public static List<ChiTietDatPhongDTO> LayTatCaCacChiTietDatPhong(int maDatPhong)
        {
            List<ChiTietDatPhongDTO> res = new List<ChiTietDatPhongDTO>();
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM chitietdatphong WHERE MaDatPhong = '"+maDatPhong+"';");

            foreach (DataRow row in dt.Rows)
            {
                res.Add(new ChiTietDatPhongDTO((int)row["MaChiTietDatPhong"], (int)row["MaPhong"],(int)row["MaDatPhong"]));
            }

            return res;


        }
        public static void XoaCacDichVuDatPhong(ChiTietDatPhongDTO chiTietDatPhong)
        {
            DataProvider.ExecuseNonQuery("DELETE FROM dichvudatphong WHERE MaChiTietDatPhong = '"+chiTietDatPhong.MaChiTietDatPhong+"';");
        }
        public static void XoaChiTietDatPhong(ChiTietDatPhongDTO chiTietDatPhong)
        {
            DataProvider.ExecuseNonQuery("DELETE FROM chitietdatphong WHERE MaChiTietDatPhong = '" + chiTietDatPhong.MaChiTietDatPhong + "';");
        }
        public static int DemSoLuongChiTietDatPhong(int maDatPhong)
        {
            return Convert.ToInt32(DataProvider.ExecuseQuery("SELECT Count(*) FROM chitietdatphong WHERE MaDatPhong = '"+maDatPhong+"' ;").Rows[0][0]);
        }
        public static bool XoaDatPhong(int maDatPhong)
        {
            DataProvider.ExecuseNonQuery("DELETE FROM datphong WHERE MaDatPhong = '" + maDatPhong + "';");
            return true;
        }
        public static void CapNhatTinhTrangDatPhong(int value, int MaDatPhong)
        {
            DataProvider.ExecuseNonQuery("UPDATE datphong SET MaTinhTrangDatPhong = '"+value+"' WHERE MaDatPhong = '" + MaDatPhong + "';");
        }
        public static Dictionary<int, DatPhongDTO> LayCacDatPhongDangHetHanDat(int khoangThoiGian)
        {
            Dictionary<int, DatPhongDTO> res = new Dictionary<int, DatPhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM datphong WHERE MaTinhTrangDatPhong = '1'  AND ThoiGianDatPhong <= '" + DateTime.Now.AddMinutes(-khoangThoiGian).ToString("yyyy-MM-dd HH:mm:ss.fff") + "';");
            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["MaDatPhong"], new DatPhongDTO((int)row["MaDatPhong"], DateTime.Parse(row["ThoiGianDatPhong"].ToString()), (double)row["SoTienDatTruoc"], (int)row["MaNhanVien"], (int)row["MaKH"], row["GhiChu"].ToString(), (int)row["MaTinhTrangDatPhong"]));
            }

            return res;
        }
        public static DatPhongDTO LayThongTinThuePhongCuaPhongDangDat(int maPhong, DateTime now)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM datphong, chitietdatphong WHERE datphong.MaDatPhong = chitietdatphong.MaDatPhong AND MaPhong = '"+maPhong+ "' AND MaTinhTrangDatPhong = '1'  AND ThoiGianDatPhong BETWEEN '" + now.AddMinutes(-ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue()).ToString("yyyy-MM-dd HH:mm:ss.fff") + "' AND '" + now.AddMinutes(ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue()).ToString("yyyy-MM-dd HH:mm:ss.fff") + "';");

            if (dt.Rows.Count == 0)
                return null;
            else
                return new DatPhongDTO((int)dt.Rows[0]["MaDatPhong"], DateTime.Parse(dt.Rows[0]["ThoiGianDatPhong"].ToString()), (double)dt.Rows[0]["SoTienDatTruoc"], (int)dt.Rows[0]["MaNhanVien"], (int)dt.Rows[0]["MaKH"], dt.Rows[0]["GhiChu"].ToString(), (int)dt.Rows[0]["MaTinhTrangDatPhong"]);
            
        
        }

        public static Dictionary<int, DatPhongDTO> LayCacDatPhongDangSapDuocDatVaDangDuocDat(int khoangThoiGian)
        {
            Dictionary<int, DatPhongDTO> res = new Dictionary<int, DatPhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM datphong WHERE MaTinhTrangDatPhong = '1'  AND ThoiGianDatPhong BETWEEN '" + DateTime.Now.AddMinutes(-ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue()).ToString("yyyy-MM-dd HH:mm:ss.fff") + "' AND '" + DateTime.Now.AddMinutes(khoangThoiGian).ToString("yyyy-MM-dd HH:mm:ss.fff") + "';");
            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["MaDatPhong"], new DatPhongDTO((int)row["MaDatPhong"], DateTime.Parse(row["ThoiGianDatPhong"].ToString()), (double)row["SoTienDatTruoc"], (int)row["MaNhanVien"], (int)row["MaKH"], row["GhiChu"].ToString(), (int)row["MaTinhTrangDatPhong"]));
            }

            return res;
        }

        public static Dictionary<int, ChiTietDatPhongDTO> LayCacChiTietDatPhongDangSapDuocDatVaDangDuocDat(int khoangThoiGian)
        {
            Dictionary<int, ChiTietDatPhongDTO> res = new Dictionary<int, ChiTietDatPhongDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM datphong, chitietdatphong WHERE datphong.MaDatPhong = chitietdatphong.MaDatPhong AND MaTinhTrangDatPhong = '1'  AND ThoiGianDatPhong BETWEEN '" + DateTime.Now.AddMinutes(-ThamSoDAL.LayKhoangThoiGianToiThieuGiuaHaiLanThue()).ToString("yyyy-MM-dd HH:mm:ss.fff") + "' AND '" + DateTime.Now.AddMinutes(khoangThoiGian).ToString("yyyy-MM-dd HH:mm:ss.fff") + "';");
            foreach (DataRow row in dt.Rows)
            {
                res.Add((int)row["MaChiTietDatPhong"], new ChiTietDatPhongDTO((int)row["MaChiTietDatPhong"], (int)row["MaPhong"], (int)row["MaDatPhong"]));
            }

            return res;
        }
    }
}
