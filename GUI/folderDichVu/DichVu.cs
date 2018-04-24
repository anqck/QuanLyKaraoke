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

namespace GUI.folderDichVu
{
    public partial class DichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public DichVu()
        {
            InitializeComponent();
        }

        private void wbntDichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(wbntDichvu.Buttons[0]))
            {
                this.DichVuPagecontrol.SelectedPage = PageThemdichvu;
            }
            if (e.Button.Equals(wbntDichvu.Buttons[1]))
            {
                this.DichVuPagecontrol.SelectedPage = PageSuadichvu;
            }
            if (e.Button.Equals(wbntDichvu.Buttons[3]))
            {
                this.DichVuPagecontrol.SelectedPage = PageLoaidichvu;
            }
            if (e.Button.Equals(wbntDichvu.Buttons[4]))
            {
                this.DichVuPagecontrol.SelectedPage = PageThemloaidichvu;
            }
        }

        private void wbntBack_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.DichVuPagecontrol.SelectedPage = PageDichvu;
        }
    }
}
