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
using DevExpress.XtraBars.Docking2010.Customization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThuePhong : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHangDTO khachHang;
        public ThuePhong()
        {
            InitializeComponent();

            khachHang = null;

          
            
            
        }

        public ThuePhong(PhongDTO phong) : this()
        {
            txtMaPhong.Text = phong.MaPhong.ToString();
            txtTenPhong.Text = phong.TenPhong;
            txtLoaiPhong.Text = LoaiPhongBUS.LayLoaiPhong(phong).TenLoaiPhong;

            RefreshDataBinding();
            txtKhachHang.Properties.DisplayMember = "TenKH";
            txtKhachHang.Properties.ValueMember = "MaKH";

            txtGioVao.EditValue = DateTime.Now;
            txtNgayVao.EditValue = DateTime.Now;
        }

        public void RefreshDataBinding()
        {
            txtKhachHang.Properties.DataSource = KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Equals(this.windowsUIButtonPanel1.Buttons[1]))
            {
                //tat cai dialog
            }
        }

        private void bntChonKH_Click(object sender, EventArgs e)
        {

            folderKhachHang.ChonKhachHang chonKhachHang = new folderKhachHang.ChonKhachHang();
            XtraDialogArgs args = new XtraDialogArgs(caption: "Caption", content: chonKhachHang, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
            args.Showing += Args_Showing;
            args.Caption = "Default Text";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };


            switch (XtraDialog.Show(args))
            {
                case DialogResult.OK:
                    khachHang = chonKhachHang.LayKhachHangDaChon();
                    txtKhachHang.EditValue = khachHang.MaKH;
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
           


            //FlyoutDialog.Show(this.FindForm(), new folderKhachHang.ChonKhachHang());
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Text = "Chọn khách hàng";
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }

        private void txtKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view =

            txtKhachHang.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;

            object val = view.GetRowCellValue(view.FocusedRowHandle, "TenKH");
            
        }
    }
}


