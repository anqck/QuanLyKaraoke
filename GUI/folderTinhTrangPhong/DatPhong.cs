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
using DevExpress.XtraBars.Docking2010.Customization;

namespace GUI.folderTinhTrangPhong
{
    public partial class DatPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public DatPhong()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Hủy":
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                default:
                    break;
            }
        }

        private void txtPhong_Properties_Popup(object sender, EventArgs e)
        {

        }

        private void txtPhong_Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {

        }
    }
}
