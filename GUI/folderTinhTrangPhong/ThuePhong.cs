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

        public ThuePhong(PhongDTO phong)
        {
            InitializeComponent();
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
            switch(XtraDialog.Show(chonKhachHang, "Sign in", MessageBoxButtons.OKCancel))
            {
                case DialogResult.OK:
                    khachHang = chonKhachHang.LayKhachHangDaChon();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
            //FlyoutDialog.Show(this.FindForm(), new folderKhachHang.ChonKhachHang());
        }
    }
}
