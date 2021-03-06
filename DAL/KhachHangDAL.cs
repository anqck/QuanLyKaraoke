﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class KhachHangDAL
    {
        public static int PhatSinhMaKH()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.khachhang.MaKH FROM quanlykaraoke.khachhang ORDER BY quanlykaraoke.khachhang.MaKH DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinKhachHang(KhachHangDTO khachHangDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO quanlykaraoke.khachhang (MaKH, TenKH, Email, SDT, DiaChi, MaLoaiKH,DiemTichLuy, NgaySinh) VALUES('$0','$1','$2','$3','$4','$5','$6','$7')");
                strSQL.Replace("$0", khachHangDTO.MaKH.ToString());
                strSQL.Replace("$1", khachHangDTO.TenKH.ToString());
                strSQL.Replace("$2", khachHangDTO.Email.ToString());
                strSQL.Replace("$3", khachHangDTO.SDT.ToString());
                strSQL.Replace("$4", khachHangDTO.DiaChi.ToString());
                strSQL.Replace("$5", khachHangDTO.MaLoaiKH.ToString());
                strSQL.Replace("$6", khachHangDTO.DiemTichLuy.ToString());
                strSQL.Replace("$7", khachHangDTO.NgaySinh.ToString("yyyy-MM-dd"));
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static DataTable LayTatCaKhachHang_LoaiKhachHang()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.khachhang, quanlykaraoke.loaikhachhang where quanlykaraoke.khachhang.MaLoaiKH = quanlykaraoke.loaikhachhang.MaLoaiKH ;");
        }

        public static Dictionary<int, KhachHangDTO> LayTatCaKhachHang()
        {
            //try
            //{
                Dictionary<int, KhachHangDTO> res = new Dictionary<int, KhachHangDTO>();

                DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.khachhang;");
                foreach (DataRow row in dt.Rows)
                {
                    KhachHangDTO thuePhongDTO = new KhachHangDTO((int)row["MaKH"], row["TenKH"].ToString(), row["Email"].ToString(), row["SDT"].ToString(), row["DiaChi"].ToString(), (int)row["MaLoaiKH"],(double)row["DiemTichLuy"], (dt.Rows[0]["NgaySinh"].ToString() == "") ? (DateTime.MinValue) : ((DateTime)dt.Rows[0]["NgaySinh"]));
                    res.Add(thuePhongDTO.MaKH, thuePhongDTO);
                }

                return res;

            //}
            //catch (Exception e)
            //{
            //    return null;
            //}
        }
        public static KhachHangDTO LayKhachHang(int maKH)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.khachhang WHERE MaKH = '"+maKH.ToString()+"';");

            return new KhachHangDTO((int)dt.Rows[0]["MaKH"], dt.Rows[0]["TenKH"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["DiaChi"].ToString(), (int)dt.Rows[0]["MaLoaiKH"], (double)dt.Rows[0]["DiemTichLuy"], (dt.Rows[0]["NgaySinh"].ToString()=="")?(DateTime.MinValue):((DateTime)dt.Rows[0]["NgaySinh"]));

        }
        public static bool CapNhatThongTinKhachHang(KhachHangDTO khachHangDTO)
        {
            try
            {
               // StringBuilder strSQL1 = new StringBuilder("UPDATE quanlykaraoke.dichvu SET  TenDV = @1,DonGia = @2, DonVi = @3,MaLDV = @4, HinhAnhDV = @5   WHERE MaDV = @0");
                StringBuilder strSQL = new StringBuilder("UPDATE  quanlykaraoke.khachhang SET  TenKH= '@1', Email = '@2', SDT = '@3', DiaChi = '@4', MaLoaiKH = '@5',DiemTichLuy='@6',NgaySinh='@7'  WHERE MaKH = '@0' ");
                strSQL.Replace("@0", khachHangDTO.MaKH.ToString());
                strSQL.Replace("@1", khachHangDTO.TenKH.ToString());
                strSQL.Replace("@2", khachHangDTO.Email.ToString());
                strSQL.Replace("@3", khachHangDTO.SDT.ToString());
                strSQL.Replace("@4", khachHangDTO.DiaChi.ToString());
                strSQL.Replace("@5", khachHangDTO.MaLoaiKH.ToString());
                strSQL.Replace("@6", khachHangDTO.DiemTichLuy.ToString());
                strSQL.Replace("@7", khachHangDTO.NgaySinh.ToString("yyyy-MM-dd"));
                // Console.WriteLine(strSQL);
                DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
        public static bool CapNhatDiemTichLuy(int maKH, double diemTichLuy)
        {
            StringBuilder strSQL = new StringBuilder("UPDATE  quanlykaraoke.khachhang SET  DiemTichLuy = '@1' WHERE MaKH = '@0' ");
            strSQL.Replace("@0", maKH.ToString());
            strSQL.Replace("@1", diemTichLuy.ToString());

            // Console.WriteLine(strSQL);
            DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

            return true;
        }
        public static bool XoaKhachHang(int maKH)
        {
            try
            {
                //Console.WriteLine("DELECTE FROM quanlykaraoke.khachhang WHERE MaKH = '" + maKH.ToString() + "';");
                DAL.DataProvider.ExecuseQuery("DELETE FROM quanlykaraoke.khachhang WHERE MaKH = '" + maKH.ToString() + "';");
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static DataTable LayTatCaKhachHang_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM khachhang;");
        }
        public static LoaiKhachHangDTO LayLoaiKhachHangCoTheDatDuoc(KhachHangDTO khachHang)
        {
            DataTable resLoaiKH = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaikhachhang WHERE SoDiemDeDatDuoc < '"+ khachHang .DiemTichLuy+ "' ORDER BY SoDiemDeDatDuoc DESC LIMIT 1;");
            if (resLoaiKH.Rows.Count != 0)
                return new LoaiKhachHangDTO(Convert.ToInt32(resLoaiKH.Rows[0]["MaLoaiKH"]), resLoaiKH.Rows[0]["TenLoaiKH"].ToString(), (int)resLoaiKH.Rows[0]["SoDiemDeDatDuoc"], (double)resLoaiKH.Rows[0]["PhanTramGiamGia"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiThieu"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiDa"], (double)resLoaiKH.Rows[0]["PhanTramGiamGia_SinhNhat"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiThieu_SinhNhat"], (double)resLoaiKH.Rows[0]["SoTienGiamGiaToiDa_SinhNhat"]);
            else
                return null;
        }
        public static bool CapNhatLoaiKhachHang(int maKH, int maLoaiKH)
        {
             DAL.DataProvider.ExecuseNonQuery("UPDATE khachhang SET khachhang.MaLoaiKH = '"+maLoaiKH+"' WHERE MaKH = '"+maKH+"';");
            return true;
        }
    }
}
