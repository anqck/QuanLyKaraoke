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
        public ThuePhong()
        {
            InitializeComponent();
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
            DevExpress.XtraEditors.XtraDialog.Show(new folderKhachHang.ChonKhachHang(), "Sign in", MessageBoxButtons.OKCancel);
            //FlyoutDialog.Show(this.FindForm(), new folderKhachHang.ChonKhachHang());
        }
    }
}
