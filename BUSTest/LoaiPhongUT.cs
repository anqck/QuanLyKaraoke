//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BUS;
//using DTO;
//using DAL;
//using System.Data;

//namespace BUSTest
//{
//    [TestClass]
//    public class LoaiPhongUT
//    {

//        [TestMethod]
//        //public void TaoLoaiPhong_1()
//        //{
//        //    DAL.DataProvider.InitalizeConnection();

//        //    LoaiPhongDTO phongDTO = new LoaiPhongDTO(LoaiPhongBUS.PhatSinhLoaiMaLoaiPhong(), "abc");
//        //    LoaiPhongBUS.ThemLoaiPhong(phongDTO.MaLoaiPhong, phongDTO.TenLoaiPhong);

//        //    DataTable phongDT = LoaiPhongBUS.LayTatCaLoaiPhong_DataTable();

//        //    Assert.IsTrue(phongDTO.MaLoaiPhong == (int)phongDT.Rows[phongDT.Rows.Count - 1]["MaLP"]);
//        //}

//        //[TestMethod]
//        //public void SuaLoaiPhong_1()
//        //{
//        //    DAL.DataProvider.InitalizeConnection();



//        //    DataTable phongDT = LoaiPhongBUS.LayTatCaLoaiPhong_DataTable();


//        //    LoaiKhachHangDTO loaiHangDTO = new LoaiKhachHangDTO(LoaiKhachHangBUS.PhatSinhLoaiKhachHang(), "abc", 0, 0, 0, 0, 0, 0, 0);
//        //    LoaiPhongBUS.(loaiHangDTO);

//        //    DataTable newKhachHangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();
//        //    Assert.IsTrue(newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["TenLoaiKH"].ToString() == khachhangDT.Rows[khachhangDT.Rows.Count - 1]["TenLoaiKH"].ToString());
//        //}

//        //[TestMethod]
//        //public void XoaLoaiKhachHang_1()
//        //{
//        //    DAL.DataProvider.InitalizeConnection();


//        //    DataTable khachhangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();

//        //    //LoaiKhachHangDTO loaiHangDTO = new LoaiKhachHangDTO((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"], "xyz", 0, 0, 0, 0, 0, 0, 0);
//        //    LoaiKhachHangBUS.XoaLoaiKhachHang((int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"]);


//        //    DataTable newKhachHangDT = LoaiKhachHangBUS.LayTatCaLoaiKhachHang_DataTable();
//        //    Assert.IsTrue((int)newKhachHangDT.Rows[newKhachHangDT.Rows.Count - 1]["MaLoaiKH"] != (int)khachhangDT.Rows[khachhangDT.Rows.Count - 1]["MaLoaiKH"]);
//        //}



//    }
//}

