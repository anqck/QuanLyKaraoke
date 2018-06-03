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
using BUS;

namespace GUI.folderKhachHang
{
    public partial class KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable khachHang;
       
        public KhachHang()
        {
            InitializeComponent();
            themKhachHang3.actionBack = GoToHomePage;
            suaKhachHang3.actionBack = GoToHomePage;
           
        }
        void GoToHomePage()
        {
            this.KhachhangPagecontrol.SelectedPage = PageKhachhang;
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
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm khách hàng":
                    themKhachHang3.Initialize();
                    this.KhachhangPagecontrol.SelectedPage = PageThemkhachhang;
                    break;
                case "Sửa khách hàng":
                    suaKhachHang3.RefreshDataBinding((int)khachHang.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaKH"]);
                    this.KhachhangPagecontrol.SelectedPage = PageSuakhachang;
                    break;
                //case "Xóa":
                //    //Thông báo xác nhận
                //    if (XtraMessageBox.Show("Bạn có chắc xóa khách hàng '" + gridView1.GetFocusedRowCellValue(colTenKH).ToString() + "' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //    {
                       
                //        if (BUS.KhachHangBUS.XoaKhachHang((int)gridView1.GetFocusedRowCellValue(colMaKH)))
                //        {

                //            //Thông báo thành công/thất bại
                //            XtraMessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                //            RefreshDataBinding();
                //        }
                //        else
                //            //Thông báo thành công/thất bại
                //            XtraMessageBox.Show("Xóa khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK);
                //    }
                //    break;
            }

           
        }
        public void RefreshDataBinding()
        {

            try
            {
                gridControl1.DataSource = khachHang = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();

                tileControl2.SelectedItem = tileAll;

                grpLoaiKH.Items.Clear();
                foreach (DTO.LoaiKhachHangDTO loaiKH in BUS.LoaiKhachHangBUS.LayTatCaLoaiKhachHang_List())
                {
                    grpLoaiKH.Items.Add(NewTileItem(loaiKH.TenKH.ToString()));

                }



            }
            catch (Exception x)
            {

            }
        }
        
        private TileItem NewTileItem(String name)
        {
            TileItem t = new TileItem();

            t.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            t.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            t.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
            t.AppearanceItem.Normal.Options.UseBackColor = true;
            t.AppearanceItem.Normal.Options.UseBorderColor = true;
            t.AppearanceItem.Normal.Options.UseFont = true;
            t.AppearanceItem.Normal.Options.UseForeColor = true;
            t.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            t.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            t.AppearanceItem.Selected.Options.UseBackColor = true;
            t.AppearanceItem.Selected.Options.UseFont = true;
            t.AppearanceItem.Selected.Options.UseForeColor = true;



            t.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            t.Name = name;
            t.Text = name;
            //t.Checked = true;

            t.ItemClick += tileLoaiKH_ItemClick;
            return t;
        }
        private void tileLoaiKH_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = (TileItem)sender;

        }
        internal void GoToPage(int v)
        {
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            KhachhangPagecontrol.SelectedPageIndex = v;
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void KhachhangPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (e.Page == PageKhachhang)
            {
                this.RefreshDataBinding();
                return;
            }
        }
    }
}