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

namespace GUI.folderKhachHang
{
    public partial class KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.KhachhangPagecontrol.SelectedPage= PageKhachhang;
        }

        private void wbntThemloaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.KhachhangPagecontrol.SelectedPage = PageKhachhang;
        }

        private void wbntKhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(wbntKhachhang.Buttons[0]))
            {
                this.KhachhangPagecontrol.SelectedPage = PageThemkhachhang;
            }
            if (e.Button.Equals(wbntKhachhang.Buttons[1]))
            {
                this.KhachhangPagecontrol.SelectedPage = PageSuakhachang;
            }
        }
    }
}