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

namespace GUI.folderTinhTrangPhong
{
    public partial class ThongTinChiTietNhieuPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongTinChiTietNhieuPhong()
        {
            InitializeComponent();

            this.TabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.TabControl.LookAndFeel.UseDefaultLookAndFeel = false;
        }
    }
}
