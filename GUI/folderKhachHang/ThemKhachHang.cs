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
    public partial class ThemKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void wbntThemkhachhang_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (wbntThemkhachhang.Buttons.Equals(wbntThemkhachhang.Buttons[0]))
            {
                //Them khach hang
            }
            if (wbntThemkhachhang.Buttons.Equals(wbntThemkhachhang.Buttons[1]))
            {
                //goi toi nut back cua PAREN
            }
        }
    }
}
