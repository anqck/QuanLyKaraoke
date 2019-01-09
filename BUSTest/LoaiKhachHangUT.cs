using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;
using DAL;
using System.Data;

namespace BUSTest
{
    [TestClass]
    public class LoaiKhachHangUT
    {
        
        [TestMethod]
        public void TaoLoaiKhachHang_1()
        {
            DAL.DataProvider.InitalizeConnection();

            LoaiKhachHangDTO loaiHangDTO = new LoaiKhachHangDTO(LoaiKhachHangBUS.PhatSinhLoaiKhachHang(), "abc", 0, 0, 0, 0, 0, 0, 0);
            LoaiKhachHangBUS.LuuThongTinLoaiKhachHang(loaiHangDTO);

            DataTable khachhangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();

            Assert.IsTrue(loaiHangDTO.MaLoaiKH == (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"]);
        }

        [TestMethod]
        public void SuaLoaiKhachHang_1()
        {
            DAL.DataProvider.InitalizeConnection();

            DataTable khachhangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();

            LoaiKhachHangDTO loaiHangDTO = new LoaiKhachHangDTO((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"], "xyz", 0, 0, 0, 0, 0, 0, 0);
            LoaiKhachHangBUS.CapNhatThongTinLoaiKhachHang(loaiHangDTO);

            DataTable newKhachHangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();
            Assert.IsTrue(newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["TenLoaiKH"].ToString() == khachhangDT.Rows[khachhangDT.Rows.Count - 1]["TenLoaiKH"].ToString());
        }

        [TestMethod]
        public void XoaLoaiKhachHang_1()
        {
            DAL.DataProvider.InitalizeConnection();


            DataTable khachhangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();

            //LoaiKhachHangDTO loaiHangDTO = new LoaiKhachHangDTO((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"], "xyz", 0, 0, 0, 0, 0, 0, 0);
            LoaiKhachHangBUS.XoaLoaiKhachHang((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"]);


            DataTable newKhachHangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();
            Assert.IsTrue((int)newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["MaLoaiKH"] != (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"]);
        }


    }
}
