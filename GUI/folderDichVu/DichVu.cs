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
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace GUI.folderDichVu
{
    public partial class DichVu : DevExpress.XtraEditors.XtraUserControl
    {
        Action goToQuanLyDichVu;
        FilterControlDialog filterDialog;
        String strFilterDialog;
        public DichVu()
        {
            InitializeComponent();

            themDichVu1.actionBack = GoToHomePage;

            tileFilter.Visible = false;
            
            
        }

        private void wbntDichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm Dịch Vụ":
                    themDichVu1.Initialize();
                    this.DichVuPagecontrol.SelectedPage = PageThemdichvu;
                    break;
                case "Sửa Dịch Vụ":
                    this.DichVuPagecontrol.SelectedPage = PageSuadichvu;
                    break;
                case "Quản Lý Loại Dịch Vụ":
                    goToQuanLyDichVu();
                    break;

                case "Bộ Lọc":
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

                        gridView1.ActiveFilterString = strFilterDialog =filterDialog.GetFilterString();
                        tileControl2.SelectedItem = tileFilter;
                        tileFilter.Visible = true;
                        
                    }
                        


                    //DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.FindForm(), new FilterControlDialog(gridControl1), properties);
                    break;
            }
     

        }


        private void wbntBack_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            GoToHomePage();
            
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

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

            t.ItemClick += tileLoaiDichVu_ItemClick;
            return t;
        }

        private void tileLoaiDichVu_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = (TileItem)sender;

        }

        public void RefreshDataBinding()
        {
            try
            {
                gridControl1.DataSource = DAL.DichVuDAL.LayTatCaDichVu_LoaiDichVu();

                tileControl2.SelectedItem = tileAll;

                grpLoaiDichVu.Items.Clear();
                foreach (LoaiDichVuDTO loaiDV in BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_List())
                {
                    grpLoaiDichVu.Items.Add(NewTileItem(loaiDV.TenDV.ToString()));

                }

               

            }
            catch (Exception x)
            {

            }
        }


        void GoToHomePage()
        {
            this.DichVuPagecontrol.SelectedPage = PageDichvu;
        }

    
        internal void GoToPage(int v)
        {
            DichVuPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            DichVuPagecontrol.SelectedPageIndex = v;
            DichVuPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void DichVuPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
           
            if(e.Page == PageDichvu)
            {
                this.RefreshDataBinding();
                return;
            }
        }
        public void AddGoToLoaiDichVu(Action goToHomeLoaiDichVu)
        {
            goToQuanLyDichVu = goToHomeLoaiDichVu;
        }

        private void tileControl2_ItemPress(object sender, TileItemEventArgs e)
        {
            
        }

        String strFilterLoaiDV;
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
                strFilterLoaiDV = BUS.LoaiDichVuBUS.GetFilterString_LoaiDichVu(e.Item.Name.ToString());
                gridView1.ActiveFilterString = strFilterLoaiDV;
                
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

