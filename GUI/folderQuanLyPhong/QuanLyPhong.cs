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
            if (e.Button.Equals(wbntQuanlyphong.Buttons[0]))
            {
                QuanlyPagecontrol.SelectedPage = PageThemphongmoi;
            }
            if (e.Button.Equals(wbntQuanlyphong.Buttons[1]))
            {
                QuanlyPagecontrol.SelectedPage = PageThemloaiphong;
            }
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            QuanlyPagecontrol.SelectedPageIndex = 0;
        }

        public void RefreshDataBinding()
        {
        
            try
            {
                gridControl.DataSource = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();

            }
            catch (Exception x)
            {

            }
        }

        internal void GoToPage(int v)
        {
            QuanlyPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            QuanlyPagecontrol.SelectedPageIndex = v;
            QuanlyPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void wbntThemloaiphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            QuanlyPagecontrol.SelectedPageIndex = 0;
        }
    }
}
