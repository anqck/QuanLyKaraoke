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

namespace GUI.TinhTrangPhong
{
    public partial class TinhTrangPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public TinhTrangPhong()
        {
            InitializeComponent();
            try
            {
                //gridControl.DataSource = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong;");
            }
            catch (Exception e)
            {

            }
        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
         
            if (e.Button.Equals(this.wbntTinhtrangphong.Buttons[0] ))
            {
                this.TinhtrangPagecontrol.SelectedPageIndex = 1;
            }
        }

        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(this.wbntThemphong.Buttons[0]))
            {
                this.TinhtrangPagecontrol.SelectedPageIndex = 0;
            }
        }
    }
}
