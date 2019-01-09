using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;
using DAL;
using System.Data;

namespace BUSTest
{
    [TestClass]
    public class DichVuUT
    {
        
        [TestMethod]
        public void TaoDichVu_1()
        {
            DAL.DataProvider.InitalizeConnection();

            DichVuDTO dichVu = new DichVuDTO(DichVuBUS.PhatSinhMaDichVu(), "abc", 20000, "cái",BUSTest.Properties.Resources.No_Image_Available, 1);
            DichVuBUS.LuuThongTinDichVu(dichVu);


            DichVuDTO p = DichVuBUS.LayThongTinDichVu(dichVu.MaDV);

            Assert.IsTrue(dichVu.TenDV == p.TenDV);
        }

        [TestMethod]
        public void SuaDichVu_1()
        {
            DAL.DataProvider.InitalizeConnection();


            DichVuDTO p = DichVuBUS.LayThongTinDichVu(DichVuBUS.PhatSinhMaDichVu()-1);
            p.TenDV = "xyz";
            p.DonVi = "chai";

           DichVuBUS.CapNhatThongTinDichVu(p);


            DichVuDTO pNew = DichVuBUS.LayThongTinDichVu(p.MaDV);

            Assert.IsTrue(pNew.TenDV == p.TenDV);
        }

        [TestMethod]
        public void TaoDichVu_2()
        {
            DAL.DataProvider.InitalizeConnection();

            DichVuDTO dichVu = new DichVuDTO(DichVuBUS.PhatSinhMaDichVu(), "xyz", 30000, "Đĩa", BUSTest.Properties.Resources.No_Image_Available, 2);
            DichVuBUS.LuuThongTinDichVu(dichVu);


            DichVuDTO p = DichVuBUS.LayThongTinDichVu(dichVu.MaDV);

            Assert.IsTrue(dichVu.TenDV == p.TenDV);
        }

        [TestMethod]
        public void SuaDichVu_2()
        {
            DAL.DataProvider.InitalizeConnection();


            DichVuDTO p = DichVuBUS.LayThongTinDichVu(DichVuBUS.PhatSinhMaDichVu() - 1);
            p.TenDV = "abc";
            p.DonVi = "Tô";

            DichVuBUS.CapNhatThongTinDichVu(p);


            DichVuDTO pNew = DichVuBUS.LayThongTinDichVu(p.MaDV);

            Assert.IsTrue(pNew.TenDV == p.TenDV);
        }

        //[TestMethod]
        //public void SuaKhachHang_1()
        //{
        //    DAL.DataProvider.InitalizeConnection();

        //    DataTable phongDT = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();


        //    PhongDTO phongDto = new PhongDTO((int)phongDT.Rows[phongDT.Rows.Count - 1]["MaPhong"], "abc", 0);
        //    PhongBUS.CapNhatThongTinPhong(phongDto);


        //    PhongDTO p = PhongBUS.LayThongTinPhong(phongDto.MaPhong);

        //    Assert.IsTrue(newPhongDT.Rows[newPhongDT.Rows.Count - 1]["TenPhong"].ToString() != phongDT.Rows[phongDT.Rows.Count - 1]["TenPhong"].ToString());
        //}


    }
}
