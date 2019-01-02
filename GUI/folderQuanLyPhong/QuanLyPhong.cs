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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace GUI.folderQuanLyPhong
{
    public partial class QuanLyPhong : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable phong;

        FilterControlDialog filterDialog;
        String strFilterDialog;

        public Action goToQuanLyLoaiPhong { get; set; }

        public QuanLyPhong()
        {
            InitializeComponent();
            themPhongMoi1.actionBack = GoToHomePage;
            suaPhong1.actionBack = GoToHomePage;

            tileControl2.SelectedItem = tileAll;
        }
        void GoToHomePage()
        {
            this.QuanlyPagecontrol.SelectedPage = PageQuanly;
        }
        private void wbntTinhtrangphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm phòng":
   
                    //Nếu không có loại phòng, thông báo cần tạo loại phòng trước
                    if (BUS.LoaiPhongBUS.LayTatCaLoaiPhong_List().Count == 0)
                    {
                        XtraMessageBox.Show("Cần phải thêm loại phòng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    themPhongMoi1.Initialize();
                    QuanlyPagecontrol.SelectedPage = PageThemphongmoi;
                    break;
                case "Sửa phòng":
                    if (gridView1.DataRowCount == 0)
                    {
                        XtraMessageBox.Show("Không có phòng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // suaKhachHang3.RefreshDataBinding((int)khachHang.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaKH"]);
                    suaPhong1.RefreshDataBinding((int)phong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaPhong"]);
                    QuanlyPagecontrol.SelectedPage = PageSuaphong;
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

                    filterDialog = new FilterControlDialog(gridControl, gridView1.ActiveFilterString.ToString());

                    if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.FindForm(), filterDialog, action, properties) == DialogResult.Yes)
                    {
                        if (filterDialog.GetFilterString() == "")
                            return;

                        gridView1.ActiveFilterString = strFilterDialog = filterDialog.GetFilterString();
                        tileControl2.SelectedItem = tileFilter;
                        tileFilter.Visible = true;

                    }
                    break;
                case "Quản lý loại phòng":
                    goToQuanLyLoaiPhong();
                    break;
                case "Xóa":
                    //Thông báo xác nhận
                    //if (XtraMessageBox.Show("Bạn có chắc xóa khách hàng '" + gridView1.GetFocusedRowCellValue(colTenKH).ToString() + "' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    //{

                    //    if (BUS.KhachHangBUS.XoaKhachHang((int)gridView1.GetFocusedRowCellValue(colMaKH)))
                    //    {

                    //        //Thông báo thành công/thất bại
                    //        XtraMessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    //        RefreshDataBinding();
                    //    }
                    //    else
                    //        //Thông báo thành công/thất bại
                    //        XtraMessageBox.Show("Xóa khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK);
                    //}
                    break;
            }
        }


        public void RefreshDataBinding()
        {
        
            try
            {

                 gridControl.DataSource = phong = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();             

               

                grpLoaiPhong.Items.Clear();
                foreach (DataRow row in BUS.LoaiPhongBUS.LayTatCaLoaiPhong_DataTable().Rows)
                {
                    grpLoaiPhong.Items.Add(NewTileItem(row["TenLoaiPhong"].ToString()));
                }

            }
            catch (Exception x)
            {

            }
        }

        internal void GoToPage_WithoutAnimation(int v)
        {
            QuanlyPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            QuanlyPagecontrol.SelectedPageIndex = v;
            QuanlyPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }



        #region Types
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

            t.ItemClick += tileLoaiPhong_ItemClick;
            return t;
        }

        TileItem preSelect;
        private void tileControl2_ItemPress(object sender, TileItemEventArgs e)
        {

            switch (e.Item.Name)
            {
                case "tileAll":                   
                    preSelect = tileAll;
                    break;                
                default:
                    return;
            }


            //tileView1.ActiveFilterString = "[TenLoaiPhong] = 'VIP 1'";
        }


        private void tileLoaiPhong_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = (TileItem)sender;
        }

        #endregion

        private void QuanlyPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            RefreshDataBinding();
        }


        String strFilterLoaiPhong;
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
                strFilterLoaiPhong = BUS.LoaiPhongBUS.GetFilterString_LoaiPhong(e.Item.Name.ToString());
                gridView1.ActiveFilterString = strFilterLoaiPhong;

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
    }
}
