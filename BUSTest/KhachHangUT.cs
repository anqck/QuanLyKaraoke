using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;
using DAL;
using System.Data;

namespace BUSTest
{
    [TestClass]
    public class KhachHangUT
    {
        
        [TestMethod]
        public void TaoKhachHang_1()
        {
            DAL.DataProvider.InitalizeConnection();

            KhachHangDTO khachhang = new KhachHangDTO(KhachHangBUS.PhatSinhMaKH(), "abc", "123", "123", "123", 0, 0, new DateTime());
            KhachHangBUS.LuuThongTinKH(khachhang);

            DataTable khachhangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();

            Assert.IsTrue(khachhang.MaKH == (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"]);
        }

        [TestMethod]
        public void SuaKhachHang_1()
        {
            DAL.DataProvider.InitalizeConnection();

            DataTable khachhangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();

            KhachHangDTO kh = new KhachHangDTO((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"], "zyx", "321", "321", "321", 0, 0, new DateTime());
            KhachHangBUS.CapNhatThongTinKhachHang(kh);

            DataTable newKhachHangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();
            Assert.IsTrue(newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["TenKH"].ToString() != khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"].ToString());
        }

        [TestMethod]
        public void XoaKhachHang_1()
        {
            DAL.DataProvider.InitalizeConnection();
            
            DataTable khachhangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();

            KhachHangBUS.XoaKhachHang((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"]);

            DataTable newKhachHangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();
            Assert.IsTrue((int)newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["MaKH"] != (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"]);
        }

        [TestMethod]
        public void TaoKhachHang_2()
        {
            DAL.DataProvider.InitalizeConnection();

            KhachHangDTO khachhang = new KhachHangDTO(KhachHangBUS.PhatSinhMaKH(), "xyz","321", "321", "321", 0, 0, new DateTime(1997,11,11   ));
            KhachHangBUS.LuuThongTinKH(khachhang);

            DataTable khachhangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();

            Assert.IsTrue(khachhang.MaKH == (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"]);
        }

        [TestMethod]
        public void SuaKhachHang_2()
        {
            DAL.DataProvider.InitalizeConnection();

            DataTable khachhangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();

            KhachHangDTO kh = new KhachHangDTO((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"], "abc", "123", "123", "123", 0, 0, new DateTime());
            KhachHangBUS.CapNhatThongTinKhachHang(kh);

            DataTable newKhachHangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();
            Assert.IsTrue(newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["TenKH"].ToString() != khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"].ToString());
        }

        [TestMethod]
        public void XoaKhachHang_2()
        {
            DAL.DataProvider.InitalizeConnection();

            DataTable khachhangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();

            KhachHangBUS.XoaKhachHang((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"]);

            DataTable newKhachHangDT = KhachHangBUS.LayTatCaKhachHang_DataTable();
            Assert.IsTrue((int)newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["MaKH"] != (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaKH"]);
        }

    }
}
