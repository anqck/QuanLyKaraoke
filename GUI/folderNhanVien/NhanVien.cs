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
        DataTable nhanVien;
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
        public void RefreshDataBinding()
        {

            try
            {
               // gridControl1.DataSource = khachHang = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();

               // tileControl2.SelectedItem = tileAll;

                //grpLoaiDichVu.Items.Clear();
                //foreach (LoaiDichVuDTO loaiDV in BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_List())
                // {
                //    grpLoaiDichVu.Items.Add(NewTileItem(loaiDV.TenDV.ToString()));
                //
                // }



            }
            catch (Exception x)
            {

            }
        }
        internal void GoToPage_WithoutAnimation(int v)
        {
            NhanVienPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            NhanVienPagecontrol.SelectedPageIndex = v;
            NhanVienPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
