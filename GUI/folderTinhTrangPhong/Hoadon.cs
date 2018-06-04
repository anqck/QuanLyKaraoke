using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.Configuration;
using DTO;

namespace GUI.folderTinhTrangPhong
{
    public partial class reportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public reportHoaDon()
        {
            InitializeComponent();
        }

        public void BindingData(DataTable dsHoaDon,KhachHangDTO khachHang,HoaDonDTO hoaDon, double TongTienGio, double TongTienKhuyenMai, double TongTienDichVu, double TienTraTruoc)
        {
            DataSource = dsHoaDon;
            DataMember = "dichvuphong";

            //MaDV, ThoiGian,SoLuong,Gia, TenDV, TenLDV


        
            GroupHeader1.GroupFields.Add(new GroupField("MaThuePhong"));
            GroupHeader2.GroupFields.Add(new GroupField("colType"));

            //Group Header 1
            xrLabel3.DataBindings.Add("Text", null, "MaThuePhong");
            lbTenPhong.DataBindings.Add("Text", null, "TenPhong");

            //Group Header 2
            lbLoaiDichVu.DataBindings.Add("Text", null, "colType");
           

            //Detail
            lbTenDV.DataBindings.Add("Text", null, "TenDV");
            lbDonViTinh.DataBindings.Add("Text", null, "DonVi");
            lbSoLuong.DataBindings.Add("Text", null, "SoLuong");
            lbDonGia.DataBindings.Add("Text", null, "Gia");                  
            lbTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "SoLuong*Gia"));

            //Group Footer 2
            lbTongTienDV_Type.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum(SoLuong*Gia)"));

            //Group Footer 1
            lbTongTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum(SoLuong*Gia)"));
            //lbTongTienDV.DataBindings.Add("Text", null, "Sum(SoLuong)");

            // lbTienDV.DataBindings.Add("Text", null, (Convert.ToInt32(lbDonGia.Text)* Convert.ToInt32(lbSoLuong.Text)).ToString() );


            ///lbTenKH.DataBindings.Add("Text", dsHoaDon, dsHoaDon.Columns["TenKhachHang"].Caption);
            // lbLoaiKH.DataBindings.Add("Text", dsHoaDon, dsHoaDon.Columns["LoaiKhachHang"].Caption);
            //lbDiemTichLuy.DataBindings.Add("Text", dsHoaDon, dsHoaDon.Columns["DiemTichLuy"].Caption);

        }

    }
}
