using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DTO;
using System.Collections.Generic;
using BUS;

namespace GUI.folderDatPhong
{
    public partial class PhieuDatPhong : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuDatPhong()
        {
            InitializeComponent();
        }


        public void BindingData( DatPhongDTO datPhong, KhachHangDTO khachHang)
        {

            lbNgaylapphieu.Text = datPhong.NgayLapPhieuDat.ToString("dd/MM/yyyy HH:mm:ss");
            lbMaphieudat.Text = datPhong.MaDatPhong.ToString();
            lbGiovao.Text = datPhong.ThoiGianDatPhong.ToString("dd/MM/yyyy HH:mm:ss");
            lbTienCoc.Text = datPhong.SoTienDatTruoc.ToString("###,###,##0 VNĐ"); ;

            DataSet dsDatphong;
            dsDatphong = new DataSet();
            dsDatphong.Tables.Add(DatPhongBUS.LayThongTinDatPhong_table(datPhong.MaDatPhong));
            dsDatphong.Tables.Add(ChiTietDatPhongBUS.LayTatCaChiTietDatPhong_DataTable(datPhong.MaDatPhong));
            dsDatphong.Tables.Add(DichVuDatPhongBUS.LayTatCaDichVuDatPhong_DichVu_LoaiDV(datPhong.MaDatPhong));

            dsDatphong.Relations.Add("DanhSachPhong", dsDatphong.Tables[0].Columns["MaDatPhong"], dsDatphong.Tables[1].Columns["MaDatPhong"]);
            dsDatphong.Relations.Add("DanhSachDichVu", dsDatphong.Tables[1].Columns["MaChiTietDatPhong"], dsDatphong.Tables[2].Columns["MaChiTietDatPhong"]);



            DataSource = dsDatphong;
            DataMember = "DsPhongDat";

       

            GroupHeader4.GroupFields.Clear();


            GroupHeader4.GroupUnion = GroupUnion.WithFirstDetail;
            GroupHeader4.GroupFields.Add(new GroupField("MaChiTietDatPhong"));


        
            //Group Header 4

            lbTenPhong.DataBindings.Add("Text", null, "DsPhongDat.TenPhong");
            lbMaPhong.DataBindings.Add("Text", null, "DsPhongDat.MaPhong");
            lbLoaiPhong.DataBindings.Add("Text", null, "DsPhongDat.TenLoaiPhong");
            lbSucchua.DataBindings.Add("Text", null, "DsPhongDat.SucChua");


            // //Group Header 2
            // lbLoaiDichVu.DataBindings.Add("Text", null, "colType");


            // //Detail


            string detailDataMember = string.Format("{0}.{1}", dsDatphong.Tables[1].TableName, dsDatphong.Relations[1].RelationName);
            DetailReport.DataSource = dsDatphong;
            DetailReport.DataMember = detailDataMember;

            // GroupHeader3.GroupFields.Clear();
            // GroupHeader3.GroupFields.Add(new GroupField("colType"));

            // lbLoaiDichVu.DataBindings.Add("Text", null, detailDataMember + ".colType");

            Tendichvu.DataBindings.Add("Text", null, detailDataMember + ".TenDV");
            donvitinh.DataBindings.Add("Text", null, detailDataMember + ".DonVi");
            soluong.DataBindings.Add("Text", null, detailDataMember + ".SoLuong");
            gia.DataBindings.Add("Text", null, detailDataMember + ".Gia");

            // //lbTenDV.DataBindings.Add("Text", null, detailDataMember+".TenDV");
            // //lbDonViTinh.DataBindings.Add("Text", null, "dichvuphong.DonVi");
            // //lbSoLuong.DataBindings.Add("Text", null, "dichvuphong.SoLuong");
            // //lbDonGia.DataBindings.Add("Text", null, "dichvuphong.Gia");
            tongmotDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", detailDataMember + ".SoLuong * " + detailDataMember + ".Gia"));
            

            // //Group Footer 2
             lbTongTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum( " + detailDataMember + ".SoLuong * " + detailDataMember + ".Gia)"));

            double TongTienDichVu = 0;
            foreach(DataRow r in dsDatphong.Tables[2].Rows)
            {
                TongTienDichVu += (double)r["SoLuong"] * (double)r["Gia"];
            }

            lbTienHoaDon.Text = TongTienDichVu.ToString("###,###,##0 VNĐ"); ;
            //lbTienHoaDon.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum( " + dsDatphong.Tables[2].TableName + ".SoLuong * " + dsDatphong.Tables[2].TableName + ".Gia)"));
            // //Group Footer 1
            // lbTongTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum( " + detailDataMember + ".SoLuong * " + detailDataMember + ".Gia)"));
            // //lbTongTienDV.DataBindings.Add("Text", null, "Sum(SoLuong)");

            // // lbTienDV.DataBindings.Add("Text", null, (Convert.ToInt32(lbDonGia.Text)* Convert.ToInt32(lbSoLuong.Text)).ToString() );

            // lbMaphieudat.Text = "#" + datphongDTO.MadatphongDTO.ToString();
            // //lbNgayThanhToan.Text = dsDatphong.Rows[0]["ThoiGian"].ToString();


            lbTenKH.Text = khachHang.TenKH;
            lbLoaiKH.Text = BUS.LoaiKhachHangBUS.LayLoaiKhachHang(khachHang.MaKH).TenLoaiKH;
            lbDiemTichLuy.Text = BUS.KhachHangBUS.LayKhachHang(khachHang.MaKH).DiemTichLuy.ToString("###,###,##0");

            Ghichu.Text = datPhong.GhiChu;
    }

      
    }
}
