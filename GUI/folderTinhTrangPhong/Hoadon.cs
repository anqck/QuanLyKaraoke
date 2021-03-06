﻿using System;
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

        public void BindingData(DataSet dsHoaDon, KhachHangDTO khachHang, HoaDonDTO hoaDon, double TongTienGio, double TongTienKhuyenMai, double TongTienDichVu, double TienTraTruoc, string ghiChu, bool isHoaDonTamTinh = false)
        {
            if(isHoaDonTamTinh)
            {
                xrLabel1.Text = "HÓA ĐƠN TẠM TÍNH";
            
            }

            DataSource = dsHoaDon;
            DataMember = "thuephong";

            lbNgayThanhToan.Text = hoaDon.NgayThanhToan.ToString("dd/MM/yyyy HH:mm:ss");

            GroupHeader1.GroupFields.Clear();
            

            GroupHeader1.GroupUnion = GroupUnion.WithFirstDetail;
            GroupHeader1.GroupFields.Add(new GroupField("MaThuePhong"));

            //GroupHeader1.GroupFields.Add(new GroupField("thuephong.MaThuePhong"));
            //GroupHeader1.GroupFields.Add(new GroupField("thuephong.GioThuePhong"));
        

            //Group Header 1
            xrLabel3.DataBindings.Add("Text", null, "thuephong.MaThuePhong");
            lbTenPhong.DataBindings.Add("Text", null, "thuephong.TenPhong");
            lbMaPhong.DataBindings.Add("Text", null, "thuephong.MaPhong");
            lbLoaiPhong.DataBindings.Add("Text", null, "thuephong.TenLoaiPhong");
            lbGioVao.DataBindings.Add("Text", null, "thuephong.GioThuePhong");
            lbGioRa.DataBindings.Add("Text", null, "thuephong.GioTraPhong");
            lbTienphong.DataBindings.Add("Text", null, "thuephong.TienPhong");

            //Group Header 2
            lbLoaiDichVu.DataBindings.Add("Text", null, "colType");


            //Detail
            

            string detailDataMember = string.Format("{0}.{1}", dsHoaDon.Tables[1].TableName,   dsHoaDon.Relations[1].RelationName);
            DetailReport.DataSource = dsHoaDon;
            DetailReport.DataMember = detailDataMember;

            GroupHeader3.GroupFields.Clear();
            GroupHeader3.GroupFields.Add(new GroupField(  "colType"));

            lbLoaiDichVu.DataBindings.Add("Text", null, detailDataMember + ".colType");

            xrTableCell4.DataBindings.Add("Text", null, detailDataMember + ".TenDV");
            xrTableCell6.DataBindings.Add("Text", null, detailDataMember + ".DonVi");
            xrTableCell8.DataBindings.Add("Text", null,  detailDataMember + ".SoLuong");
            xrTableCell12.DataBindings.Add("Text", null, detailDataMember + ".Gia");

            //lbTenDV.DataBindings.Add("Text", null, detailDataMember+".TenDV");
            //lbDonViTinh.DataBindings.Add("Text", null, "dichvuphong.DonVi");
            //lbSoLuong.DataBindings.Add("Text", null, "dichvuphong.SoLuong");
            //lbDonGia.DataBindings.Add("Text", null, "dichvuphong.Gia");
            xrTableCell13.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text",   detailDataMember + ".SoLuong * " + detailDataMember + ".Gia"));

            //Group Footer 2
            lbTongTienDV_Type.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum( " + detailDataMember + ".SoLuong * " + detailDataMember + ".Gia)"));

            //Group Footer 1
            lbTongTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum( " + detailDataMember + ".SoLuong * " + detailDataMember + ".Gia)"));
            //lbTongTienDV.DataBindings.Add("Text", null, "Sum(SoLuong)");

            // lbTienDV.DataBindings.Add("Text", null, (Convert.ToInt32(lbDonGia.Text)* Convert.ToInt32(lbSoLuong.Text)).ToString() );

            lbMaHoaDon.Text = "#"+ hoaDon.MaHoaDon.ToString();
            //lbNgayThanhToan.Text = dsHoaDon.Rows[0]["ThoiGian"].ToString();


            lbTenKH.Text= khachHang.TenKH;
            lbLoaiKH.Text=BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang).TenLoaiKH;
            lbDiemTichLuy.Text = khachHang.DiemTichLuy.ToString("###,###,##0");

            xrTableCell15.Text = (TongTienGio).ToString("###,###,##0 VNĐ");
            lbTienHoaDon.Text = (TongTienDichVu ).ToString("###,###,##0 VNĐ");
            lbTienKhuyenMai.Text = TongTienKhuyenMai.ToString("###,###,##0 VNĐ");
            lbThanhTien.Text = TienTraTruoc.ToString("###,###,##0 VNĐ");
            lbTongThanhTien.Text = (TongTienDichVu + TongTienGio + TongTienKhuyenMai - TienTraTruoc).ToString("###,###,##0 VNĐ");

            xrTableCell18.Text = ghiChu;
        }

    }
}