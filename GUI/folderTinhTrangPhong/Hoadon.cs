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

        public void BindingData(DataTable dsHoaDon,HoaDonDTO hoadon,KhachHangDTO khachHang, double TongTienGio,double TongTienKhuyenMai, double TongTienDichVu, double TienTraTruoc)
        {
            DataSource = dsHoaDon;
            DataMember = "dichvuphong";

            //MaDV, ThoiGian,SoLuong,Gia, TenDV, TenLDV


            GroupField groupField = new GroupField("MaThuePhong");
            GroupHeader1.GroupFields.Add(groupField);


            //Group Header
            xrLabel3.DataBindings.Add("Text", null, "MaThuePhong");


            //Detail
            detailTenDV.DataBindings.Add("Text", null, "TenDV");
          
        }

    }
}
