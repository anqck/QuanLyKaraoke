using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThanhToan : DevExpress.XtraEditors.XtraUserControl
    {
        private PhongDTO phong;
        private KhachHangDTO khachHang;
        private HoaDonDTO hoaDon;
        private ThuePhongDTO thuePhong;

        public ThanhToan()
        {
            InitializeComponent();

            //snapControl.DataSource = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
            //snapControl.LoadDocument("C:\\Users\\Public\\Documents\\DevExpress Demos 17.1\\Components\\WinForms\\DevExpress.HybridApp.Win\\CS\\DevExpress.HybridApp.Win\\Resources\\MailMerge\\1.snx", DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            //snapControl.ReadOnly = true;

            //snapControl.Document.DataSource = ds;
        }
        public void RefreshDataBinding(PhongDTO phongDTO)
        {
            //doc.Document.DataSource = BUS.PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
        }

        private void wbntQuanlyphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thanh toán":

                    break;
            }
        }
    }
}
