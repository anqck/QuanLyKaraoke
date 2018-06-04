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

        public void BindingData(DataSet dsHoaDon, KhachHangDTO khachHang, HoaDonDTO hoaDon, double TongTienGio, double TongTienKhuyenMai, double TongTienDichVu, double TienTraTruoc)
        {
            DataSource = dsHoaDon;
            DataMember = "dichvuphong";

            //MaDV, ThoiGian,SoLuong,Gia, TenDV, TenLDV



            GroupHeader1.GroupFields.Add(new GroupField("MaThuePhong"));
            GroupHeader2.GroupFields.Add(new GroupField("colType"));

            //Group Header 1
            xrLabel3.DataBindings.Add("Text", null, "MaThuePhong");
            lbTenPhong.DataBindings.Add("Text", null, "TenPhong");
            lbGioVao.DataBindings.Add("Text", null, "thuephong.GioThuePhong");
            lbGioRa.DataBindings.Add("Text", null, "thuephong.GioTraPhong");

            //Group Header 2
            lbLoaiDichVu.DataBindings.Add("Text", null, "colType");


            //Detail
            lbTenDV.DataBindings.Add("Text", null, "dichvuphong.TenDV");
            lbDonViTinh.DataBindings.Add("Text", null, "dichvuphong.DonVi");
            lbSoLuong.DataBindings.Add("Text", null, "dichvuphong.SoLuong");
            lbDonGia.DataBindings.Add("Text", null, "dichvuphong.Gia");
            lbTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "SoLuong*Gia"));

            //Group Footer 2
            lbTongTienDV_Type.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum(SoLuong*Gia)"));

            //Group Footer 1
            lbTongTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum(SoLuong*Gia)"));
            //lbTongTienDV.DataBindings.Add("Text", null, "Sum(SoLuong)");

            // lbTienDV.DataBindings.Add("Text", null, (Convert.ToInt32(lbDonGia.Text)* Convert.ToInt32(lbSoLuong.Text)).ToString() );

            lbMaHoaDon.Text = "#"+ hoaDon.MaHoaDon.ToString();
            //lbNgayThanhToan.Text = dsHoaDon.Rows[0]["ThoiGian"].ToString();


            lbTenKH.Text= khachHang.TenKH;
            lbLoaiKH.Text=BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang).TenLoaiKH;
            lbDiemTichLuy.Text = khachHang.DiemTichLuy.ToString();

            lbTienHoaDon.Text = (TongTienDichVu + TongTienGio).ToString();
            lbTienKhuyenMai.Text = TongTienKhuyenMai.ToString();
            lbThanhTien.Text = (TongTienDichVu + TongTienGio - TongTienKhuyenMai).ToString();

        }

    }
}