using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using DTO;
using DAL;
using System.Data;

namespace BUSTest
{
    [TestClass]
    public class PhongUT
    {
        
        [TestMethod]
        public void TaoPhong_1()
        {
            DAL.DataProvider.InitalizeConnection();

            PhongDTO phongDto = new PhongDTO(PhongBUS.PhatSinhMaPhong(), "abc", 1,"Tầng 1","",1,15);
            PhongBUS.LuuThongTinPhong(phongDto);


            PhongDTO p = PhongBUS.LayThongTinPhong(phongDto.MaPhong);

            Assert.IsTrue(phongDto.TenPhong == p.TenPhong);
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
