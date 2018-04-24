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
        private void wbntBack_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.KhachhangPagecontrol.SelectedPage = PageKhachhang;
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
            if (e.Button.Equals(wbntKhachhang.Buttons[3]))
            {
                this.KhachhangPagecontrol.SelectedPage = PageLoaikhachhang;
            }
            if (e.Button.Equals(wbntKhachhang.Buttons[4]))
            {
                this.KhachhangPagecontrol.SelectedPage = PageThemloaikhachhang;
            }
        }
        public void RefreshDataBinding()
        {

            //try
            //{
            //    gridControl.DataSource = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();


            //    tileAll.Elements[1].Text = ((DataView)gridView1.DataSource).Count.ToString();

            //    grpLoaiPhong.Items.Clear();
            //    foreach (DataRow row in DAL.LoaiPhongDAL.LayTatCaLoaiPhong().Rows)
            //    {
            //        grpLoaiPhong.Items.Add(NewTileItem(row["TenLoaiPhong"].ToString()));
            //    }

            //}
            //catch (Exception x)
            //{

            //}
        }

        internal void GoToPage(int v)
        {
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            KhachhangPagecontrol.SelectedPageIndex = v;
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

    }
}