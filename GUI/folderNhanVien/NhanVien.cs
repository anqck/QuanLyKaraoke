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

namespace GUI.folderNhanVien
{
    public partial class NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void wbntDichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(wbntNhanvien.Buttons[0]))
            {
                this.NhanVienPagecontrol.SelectedPage = PageThemnhanvien;
            }
            if (e.Button.Equals(wbntNhanvien.Buttons[1]))
            {
                this.NhanVienPagecontrol.SelectedPage = PageSuanhanvien;
            }
            
        }

        private void wbntBackThemKH_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.NhanVienPagecontrol.SelectedPage = PageNhanvien;
        }

        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.NhanVienPagecontrol.SelectedPage = PageNhanvien;
        }
    }
}
