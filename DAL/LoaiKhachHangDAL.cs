using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiKhachHangDAL
    {
        public static int PhatSinhMaLoaiKH()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.loaikhachhang.MaLoaiKH FROM quanlykaraoke.loaikhachhang ORDER BY quanlykaraoke.loaikhachhang.MaLoaiKH DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static DataTable LayTatCaLoaiKhachHang_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang;");
        }

        public static LoaiKhachHangDTO LayLoaiKhachHang(KhachHangDTO khachHang)
        {
            DataTable resLoaiKH = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang WHERE quanlykaraoke.loaikhachhang.MaLoaiKH = '" + khachHang.MaLoaiKH.ToString() + "';");
            return new LoaiKhachHangDTO(Convert.ToInt32(resLoaiKH.Rows[0]["MaLoaiKH"]), resLoaiKH.Rows[0]["TenLoaiKH"].ToString(), (int)resLoaiKH.Rows[0]["SoDiemDeDatDuoc"], (double)resLoaiKH.Rows[0]["PhanTramGiamGia"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiThieu"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiDa"], (double)resLoaiKH.Rows[0]["PhanTramGiamGia_SinhNhat"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiThieu_SinhNhat"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiDa_SinhNhat"]);
        }

        public static LoaiKhachHangDTO LayLoaiKhachHang(int maLoaiKH)
        {
            DataTable resLoaiKH = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang WHERE quanlykaraoke.loaikhachhang.MaLoaiKH = '" + maLoaiKH + "';");
            return new LoaiKhachHangDTO(Convert.ToInt32(resLoaiKH.Rows[0]["MaLoaiKH"]), resLoaiKH.Rows[0]["TenLoaiKH"].ToString(), (int)resLoaiKH.Rows[0]["SoDiemDeDatDuoc"], (double)resLoaiKH.Rows[0]["PhanTramGiamGia"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiThieu"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiDa"], (double)resLoaiKH.Rows[0]["PhanTramGiamGia_SinhNhat"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiThieu_SinhNhat"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiDa_SinhNhat"]);
        }
        public static List<LoaiKhachHangDTO> LayTatCaLoaiKhachHang_List()
        {
            List<LoaiKhachHangDTO> res = new List<LoaiKhachHangDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(new LoaiKhachHangDTO(Convert.ToInt32(row["MaLoaiKH"]), row["TenLoaiKH"].ToString(), (int)row["SoDiemDeDatDuoc"], (double)row["PhanTramGiamGia"], (double)row["SoTienGiamGiaToiThieu"], (double)row["SoTienGiamGiaToiDa"], (double)row["PhanTramGiamGia_SinhNhat"], (double)row["SoTienGiamGiaToiThieu_SinhNhat"], (double)row["SoTienGiamGiaToiDa_SinhNhat"]));
            }

            return res;
        }

        public static bool LuuThongTinLoaiKhachHang(LoaiKhachHangDTO loaiKhachHangDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.loaikhachhang (MaLoaiKH, TenLoaiKH,SoDiemDeDatDuoc, PhanTramGiamGia, SoTienGiamGiaToiThieu, SoTienGiamGiaToiDa, PhanTramGiamGia_SinhNhat,SoTienGiamGiaToiThieu_SinhNhat,SoTienGiamGiaToiDa_SinhNhat) VALUES('$0','$1','$2','$3','$4','$5','$6','$7','$8')");
                strSQL.Replace("$0", loaiKhachHangDTO.MaLoaiKH.ToString());
                strSQL.Replace("$1", loaiKhachHangDTO.TenLoaiKH.ToString());
                strSQL.Replace("$2", loaiKhachHangDTO.SoDiemDeDatDuoc.ToString());
                strSQL.Replace("$3", loaiKhachHangDTO.PhanTramGiamGia.ToString());
                strSQL.Replace("$4", loaiKhachHangDTO.SoTienGiamGia_Min.ToString());
                strSQL.Replace("$5", loaiKhachHangDTO.SoTienGiamGia_Max.ToString());
                strSQL.Replace("$6", loaiKhachHangDTO.PhanTramGiamGiaSinhNhat.ToString());
                strSQL.Replace("$7", loaiKhachHangDTO.SoTienGiamGiaSinhNhat_Min.ToString());
                strSQL.Replace("$8", loaiKhachHangDTO.SoTienGiamGiaSinhNhat_Max.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool CapNhatThongTinLoaiKhachHang(LoaiKhachHangDTO loaiKhachHangDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("UPDATE loaikhachhang SET  TenLoaiKH = '$1',SoDiemDeDatDuoc = '$2', PhanTramGiamGia = '$3', SoTienGiamGiaToiThieu = '$4', SoTienGiamGiaToiDa = '$5', PhanTramGiamGia_SinhNhat = '$6',SoTienGiamGiaToiThieu_SinhNhat = '$7',SoTienGiamGiaToiDa_SinhNhat = '$8' WHERE MaLoaiKH = '$0';");
                strSQL.Replace("$0", loaiKhachHangDTO.MaLoaiKH.ToString());
                strSQL.Replace("$1", loaiKhachHangDTO.TenLoaiKH.ToString());
                strSQL.Replace("$2", loaiKhachHangDTO.SoDiemDeDatDuoc.ToString());
                strSQL.Replace("$3", loaiKhachHangDTO.PhanTramGiamGia.ToString());
                strSQL.Replace("$4", loaiKhachHangDTO.SoTienGiamGia_Min.ToString());
                strSQL.Replace("$5", loaiKhachHangDTO.SoTienGiamGia_Max.ToString());
                strSQL.Replace("$6", loaiKhachHangDTO.PhanTramGiamGiaSinhNhat.ToString());
                strSQL.Replace("$7", loaiKhachHangDTO.SoTienGiamGiaSinhNhat_Min.ToString());
                strSQL.Replace("$8", loaiKhachHangDTO.SoTienGiamGiaSinhNhat_Max.ToString());
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool XoaLoaiKhachHang(int maLoaiKH)
        {
            DAL.DataProvider.ExecuseQuery("DELETE FROM quanlykaraoke.loaikhachhang WHERE MaLoaiKH = '" + maLoaiKH + "';");
            return true;
        }
    }
}
