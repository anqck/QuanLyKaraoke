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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace GUI.folderKhachHang
{
    public partial class KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public Action goToLoaiKhachHang { get; set; }

        DataTable khachHang;

        FilterControlDialog filterDialog;
        String strFilterDialog;

        public KhachHang()
        {
            InitializeComponent();
            themKhachHang3.actionBack = GoToHomePage;
            suaKhachHang3.actionBack = GoToHomePage;

            tileFilter.Visible = false;
        }
        void GoToHomePage()
        {
            RefreshDataBinding();
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
                    //Nếu không có loại KH, thông báo cần tạo loại phòng trước
                    if (LoaiKhachHangBUS.LayTatCaLoaiKhachHang_List().Count == 0)
                    {
                        XtraMessageBox.Show("Cần phải thêm loại khách hàng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    themKhachHang3.Initialize();
                    this.KhachhangPagecontrol.SelectedPage = PageThemkhachhang;
                    break;
                case "Sửa khách hàng":
                    suaKhachHang3.RefreshDataBinding((int)khachHang.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaKH"]);
                    this.KhachhangPagecontrol.SelectedPage = PageSuakhachang;
                    break;
                case "Bộ lọc":
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = "BỘ LỌC", Description = "Close the application?" };
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Lọc", Result = System.Windows.Forms.DialogResult.Yes };
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Hủy", Result = System.Windows.Forms.DialogResult.No };
                    action.Commands.Add(command1);
                    action.Commands.Add(command2);
                    FlyoutProperties properties = new FlyoutProperties();
                    properties.ButtonSize = new Size(160, 50);
                    properties.Style = FlyoutStyle.MessageBox;

                    filterDialog = new FilterControlDialog(gridControl1, gridView1.ActiveFilterString.ToString());

                    if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.FindForm(), filterDialog, action, properties) == DialogResult.Yes)
                    {
                        if (filterDialog.GetFilterString() == "")
                            return;

                        gridView1.ActiveFilterString = strFilterDialog = filterDialog.GetFilterString();
                        tileControl2.SelectedItem = tileFilter;
                        tileFilter.Visible = true;

                    }


                    break;
                case "Quản lý loại khách hàng":
                    goToLoaiKhachHang();
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

            //try
            //{
                gridControl1.DataSource = khachHang = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();

                tileControl2.SelectedItem = tileAll;

                grpLoaiKH.Items.Clear();
                foreach (DTO.LoaiKhachHangDTO loaiKH in BUS.LoaiKhachHangBUS.LayTatCaLoaiKhachHang_List())
                {
                    grpLoaiKH.Items.Add(NewTileItem(loaiKH.TenLoaiKH.ToString()));

                }



            //}
            //catch (Exception x)
            //{

            //}
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

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridView1.ActiveFilterString == "")
            {
                tileControl2.SelectedItem = tileAll;
                tileFilter.Visible = false;
            }

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                wbntKhachhang.Buttons[1].Properties.Enabled = false;

                return;
            }

            if (e.FocusedRowHandle == 0 )
            {
                wbntKhachhang.Buttons[1].Properties.Enabled = false;

            }
            else
            {
                wbntKhachhang.Buttons[1].Properties.Enabled = true;


            }
        }
        String strFilterLoaiKH;
        private void tileControl2_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            if (e.Item == tileAll)
            {
                gridView1.ActiveFilterEnabled = false;
                gridView1.ActiveFilterString = "";

            }
            else if (e.Item == tileFilter)
            {
                gridView1.ActiveFilterEnabled = true;
                gridView1.ActiveFilterString = strFilterDialog;

            }
            else
            {
                gridView1.ActiveFilterEnabled = true;
                strFilterLoaiKH = BUS.LoaiKhachHangBUS.GetFilterString_LoaiKhachHang(e.Item.Name.ToString());
                gridView1.ActiveFilterString = strFilterLoaiKH;

            }
        }
        public void GoToHomePageWithoutAnimation()
        {
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            KhachhangPagecontrol.SelectedPageIndex = 0;
            KhachhangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}