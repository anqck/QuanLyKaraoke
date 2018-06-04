using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.Configuration;

namespace GUI.folderTinhTrangPhong
{
    public partial class reportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public reportHoaDon()
        {
            InitializeComponent();
        }

        public void BindingData(DataTable dsHoaDon, double TongTienGio, double TongTienKhuyenMai, double TongTienDichVu, double TienTraTruoc)
        {
            DataSource = dsHoaDon;
            DataMember = "dichvuphong";

            //MaDV, ThoiGian,SoLuong,Gia, TenDV, TenLDV


            GroupField groupField = new GroupField("MaThuePhong");
            GroupHeader1.GroupFields.Add(groupField);


            //Group Header
            xrLabel3.DataBindings.Add("Text", null, "MaThuePhong");
            lbTenPhong.DataBindings.Add("Text", null, "TenPhong");

            //Detail
            lbTenDV.DataBindings.Add("Text", null, "TenDV");
            lbDonVi.DataBindings.Add("Text", null, "DonVi");
            
            //lbSoLuong.DataBindings.Add(new  Binding("EditValue", bindingSource1, "CreationDate"));
            lbSoLuong.DataBindings.Add("Text", null, "SoLuong");
            lbDonGia.DataBindings.Add("Text", null, "Gia");

           // ExpressionBinding expressionBinding = ;
            //lbTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Value", "SoLuong*Gia"));
            lbTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "SoLuong*Gia"));


            lbTongTienDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum(SoLuong*Gia)"));
            //lbTongTienDV.DataBindings.Add("Text", null, "Sum(SoLuong)");

            // lbTienDV.DataBindings.Add("Text", null, (Convert.ToInt32(lbDonGia.Text)* Convert.ToInt32(lbSoLuong.Text)).ToString() );


            ///lbTenKH.DataBindings.Add("Text", dsHoaDon, dsHoaDon.Columns["TenKhachHang"].Caption);
            // lbLoaiKH.DataBindings.Add("Text", dsHoaDon, dsHoaDon.Columns["LoaiKhachHang"].Caption);
            //lbDiemTichLuy.DataBindings.Add("Text", dsHoaDon, dsHoaDon.Columns["DiemTichLuy"].Caption);

        }

    }
}
