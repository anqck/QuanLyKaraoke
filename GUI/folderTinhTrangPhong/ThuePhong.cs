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
    }
}
