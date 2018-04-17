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

namespace GUI.folderQuanLyPhong
{
    public partial class QuanLyPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyPhong()
        {
            InitializeComponent();

        }

        private void wbntTinhtrangphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            QuanlyPagecontrol.SelectedPageIndex = 1;
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            QuanlyPagecontrol.SelectedPageIndex = 0;
        }

        public void RefreshDataBinding()
        {
            try
            {
                gridControl.DataSource = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong,quanlykaraoke.loaiphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong and quanlykaraoke.phong.MaLoaiPhong = quanlykaraoke.loaiphong.MaLP ;");
            }
            catch (Exception x)
            {

            }
        }
    }
}
