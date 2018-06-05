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
            themNhanVien1.actionBack = GoToHomePage;
            suaNhanVien1.actionBack = GoToHomePage;
        }
        void GoToHomePage()
        {
            RefreshDataBinding();
            this.NhanVienPagecontrol.SelectedPage = PageNhanvien;
        }
        private void wbntDichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm nhân viên":
                    //Nếu không có loại KH, thông báo cần tạo loại phòng trước

                    //if (LoaiKhachHangBUS.LayTatCaLoaiKhachHang_List().Count == 0)
                    //{
                    //    XtraMessageBox.Show("Cần phải thêm loại khách hàng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}

                    themNhanVien1.Initialize();
                    this.NhanVienPagecontrol.SelectedPage = PageThemnhanvien;
                    break;
                case "Sửa nhân viên":
                    //suaKhachHang3.RefreshDataBinding((int)khachHang.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaKH"]);
                    suaNhanVien1.RefreshDataBinding((int)nhanVien.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaNhanVien"]);
                   
                    this.NhanVienPagecontrol.SelectedPage = PageSuanhanvien;
                    break;
                
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
                gridControl1.DataSource = nhanVien = BUS.NhanVienBUS.LayTatCaNhanVien_LoaiTaiKhoan();

                //tileControl2.SelectedItem = tileAll;

              //  grpLoaiDichVu.Items.Clear();
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
        internal void GoToPage(int v)
        {
            NhanVienPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            NhanVienPagecontrol.SelectedPageIndex = v;
            NhanVienPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void NhanVienPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (e.Page == PageNhanvien)
            {
                this.RefreshDataBinding();
                return;
            }
        }
    }
}
