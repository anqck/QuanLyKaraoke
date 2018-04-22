using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace GUI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            tinhTrangPhong1.RefreshDataBinding();




        }



        private void BntClose_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }
             
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.bntHome = new DevExpress.XtraBars.Navigation.NavButton();
            this.btnClose = new DevExpress.XtraBars.Navigation.NavButton();
            this.Doc = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButtonHome = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonMinimize = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButtonClose = new DevExpress.XtraBars.Navigation.NavButton();
            this.MenuBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.GroupMenu = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.menuTinhtrangphong = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuQuanlyphong = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.PageControl = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageTinhtrangphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tinhTrangPhong1 = new GUI.TinhTrangPhong.TinhTrangPhong();
            this.pageQuanlyphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.quanLyPhong1 = new GUI.folderQuanLyPhong.QuanLyPhong();
            this.pageKhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.khachHang1 = new GUI.folderKhachHang.KhachHang();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageControl)).BeginInit();
            this.PageControl.SuspendLayout();
            this.pageTinhtrangphong.SuspendLayout();
            this.pageQuanlyphong.SuspendLayout();
            this.pageKhachhang.SuspendLayout();
            this.windowsUIButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bntHome
            // 
            this.bntHome.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.bntHome.Caption = null;
            this.bntHome.Name = "bntHome";
            // 
            // btnClose
            // 
            this.btnClose.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btnClose.Caption = null;
            this.btnClose.Name = "btnClose";
            // 
            // Doc
            // 
            this.Doc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Doc.Appearance.Options.UseBackColor = true;
            this.Doc.BackColor = System.Drawing.Color.DimGray;
            this.Doc.Buttons.Add(this.navButtonHome);
            this.Doc.Buttons.Add(this.navButtonMinimize);
            this.Doc.Buttons.Add(this.navButtonClose);
            // 
            // tileNavCategory1
            // 
            this.Doc.DefaultCategory.Name = "tileNavCategory1";
            this.Doc.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.Doc.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.Doc.Dock = System.Windows.Forms.DockStyle.Top;
            this.Doc.Location = new System.Drawing.Point(0, 0);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(1080, 40);
            this.Doc.TabIndex = 3;
            this.Doc.Text = "tileNavPane1";
            // 
            // navButtonHome
            // 
            this.navButtonHome.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButtonHome.Caption = null;
            this.navButtonHome.Glyph = ((System.Drawing.Image)(resources.GetObject("navButtonHome.Glyph")));
            this.navButtonHome.Name = "navButtonHome";
            // 
            // navButtonMinimize
            // 
            this.navButtonMinimize.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonMinimize.Caption = null;
            this.navButtonMinimize.Glyph = ((System.Drawing.Image)(resources.GetObject("navButtonMinimize.Glyph")));
            this.navButtonMinimize.Name = "navButtonMinimize";
            this.navButtonMinimize.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButtonMinimize_ElementClick);
            // 
            // navButtonClose
            // 
            this.navButtonClose.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButtonClose.Caption = null;
            this.navButtonClose.Glyph = ((System.Drawing.Image)(resources.GetObject("navButtonClose.Glyph")));
            this.navButtonClose.Name = "navButtonClose";
            this.navButtonClose.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.BntClose_ElementClick);
            // 
            // MenuBar
            // 
            this.MenuBar.AllowDrag = false;
            this.MenuBar.AllowDragTilesBetweenGroups = false;
            this.MenuBar.AllowGlyphSkinning = true;
            this.MenuBar.AllowSelectedItem = true;
            this.MenuBar.AppearanceGroupText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.AppearanceGroupText.ForeColor = System.Drawing.Color.Gray;
            this.MenuBar.AppearanceGroupText.Options.UseFont = true;
            this.MenuBar.AppearanceGroupText.Options.UseForeColor = true;
            this.MenuBar.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.AppearanceItem.Normal.Options.UseFont = true;
            this.MenuBar.AppearanceText.BackColor = System.Drawing.Color.Red;
            this.MenuBar.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.AppearanceText.Options.UseBackColor = true;
            this.MenuBar.AppearanceText.Options.UseFont = true;
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.DropDownButtonWidth = 30;
            this.MenuBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.MenuBar.Groups.Add(this.GroupMenu);
            this.MenuBar.IndentBetweenGroups = 10;
            this.MenuBar.IndentBetweenItems = 10;
            this.MenuBar.ItemPadding = new System.Windows.Forms.Padding(5);
            this.MenuBar.ItemSize = 65;
            this.MenuBar.Location = new System.Drawing.Point(0, 40);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(2, 2, 5, 1);
            this.MenuBar.MaxId = 12;
            this.MenuBar.MaximumSize = new System.Drawing.Size(0, 150);
            this.MenuBar.MinimumSize = new System.Drawing.Size(117, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(20, 15, 0, 6);
            this.MenuBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.MenuBar.SelectedItem = this.menuTinhtrangphong;
            this.MenuBar.SelectionBorderWidth = 2;
            this.MenuBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.MenuBar.Size = new System.Drawing.Size(1080, 115);
            this.MenuBar.TabIndex = 4;
            this.MenuBar.TabStop = false;
            this.MenuBar.Text = "tileBar";
            this.MenuBar.WideTileWidth = 150;
            this.MenuBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.MenuBar_SelectedItemChanged);
            // 
            // GroupMenu
            // 
            this.GroupMenu.Items.Add(this.menuTinhtrangphong);
            this.GroupMenu.Items.Add(this.menuQuanlyphong);
            this.GroupMenu.Items.Add(this.tileBarItem3);
            this.GroupMenu.Items.Add(this.tileBarItem5);
            this.GroupMenu.Items.Add(this.tileBarItem1);
            this.GroupMenu.Items.Add(this.tileBarItem2);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Text = "GROUP GÌ ĐÓ";
            // 
            // menuTinhtrangphong
            // 
            this.menuTinhtrangphong.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.menuTinhtrangphong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuTinhtrangphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement7.Text = "Màn hình chính";
            this.menuTinhtrangphong.Elements.Add(tileItemElement7);
            this.menuTinhtrangphong.Id = 10;
            this.menuTinhtrangphong.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuTinhtrangphong.Name = "menuTinhtrangphong";
            // 
            // menuQuanlyphong
            // 
            this.menuQuanlyphong.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.menuQuanlyphong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuQuanlyphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement8.Text = "Quản lý phòng";
            this.menuQuanlyphong.Elements.Add(tileItemElement8);
            this.menuQuanlyphong.Id = 4;
            this.menuQuanlyphong.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuQuanlyphong.Name = "menuQuanlyphong";
            this.menuQuanlyphong.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.tileBarItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement9.Text = "Khách hàng";
            this.tileBarItem3.Elements.Add(tileItemElement9);
            this.tileBarItem3.Id = 6;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            this.tileBarItem3.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.tileBarItem5.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement10.Text = "Nhân viên";
            this.tileBarItem5.Elements.Add(tileItemElement10);
            this.tileBarItem5.Id = 9;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem5.Name = "tileBarItem5";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(216)))), ((int)(((byte)(96)))));
            this.tileBarItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement11.Text = "Dịch vụ";
            this.tileBarItem1.Elements.Add(tileItemElement11);
            this.tileBarItem1.Id = 11;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            this.tileBarItem1.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileBarItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement12.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement12.Text = "Báo cáo";
            this.tileBarItem2.Elements.Add(tileItemElement12);
            this.tileBarItem2.Id = 5;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // PageControl
            // 
            this.PageControl.Appearance.BackColor = System.Drawing.Color.White;
            this.PageControl.Appearance.Options.UseBackColor = true;
            this.PageControl.Controls.Add(this.pageTinhtrangphong);
            this.PageControl.Controls.Add(this.pageQuanlyphong);
            this.PageControl.Controls.Add(this.pageKhachhang);
            this.PageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageControl.Location = new System.Drawing.Point(0, 155);
            this.PageControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageControl.Name = "PageControl";
            this.PageControl.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageTinhtrangphong,
            this.pageQuanlyphong,
            this.pageKhachhang});
            this.PageControl.SelectedPage = this.pageTinhtrangphong;
            this.PageControl.Size = new System.Drawing.Size(1080, 507);
            this.PageControl.TabIndex = 5;
            this.PageControl.Text = "navigationFrame";
            this.PageControl.TransitionAnimationProperties.FrameCount = 5000;
            this.PageControl.TransitionAnimationProperties.FrameInterval = 1000;
            // 
            // pageTinhtrangphong
            // 
            this.pageTinhtrangphong.Caption = "pageTinhtrangphong";
            this.pageTinhtrangphong.Controls.Add(this.tinhTrangPhong1);
            this.pageTinhtrangphong.Name = "pageTinhtrangphong";
            this.pageTinhtrangphong.Size = new System.Drawing.Size(1080, 507);
            // 
            // tinhTrangPhong1
            // 
            this.tinhTrangPhong1.Appearance.BackColor = System.Drawing.Color.White;
            this.tinhTrangPhong1.Appearance.Options.UseBackColor = true;
            this.tinhTrangPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhTrangPhong1.Location = new System.Drawing.Point(0, 0);
            this.tinhTrangPhong1.Margin = new System.Windows.Forms.Padding(5);
            this.tinhTrangPhong1.Name = "tinhTrangPhong1";
            this.tinhTrangPhong1.Padding = new System.Windows.Forms.Padding(3);
            this.tinhTrangPhong1.Size = new System.Drawing.Size(1080, 507);
            this.tinhTrangPhong1.TabIndex = 0;
            this.tinhTrangPhong1.Load += new System.EventHandler(this.tinhTrangPhong1_Load);
            // 
            // pageQuanlyphong
            // 
            this.pageQuanlyphong.Caption = "pageQuanlyphong";
            this.pageQuanlyphong.Controls.Add(this.quanLyPhong1);
            this.pageQuanlyphong.Name = "pageQuanlyphong";
            this.pageQuanlyphong.Size = new System.Drawing.Size(1080, 507);
            // 
            // quanLyPhong1
            // 
            this.quanLyPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyPhong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyPhong1.Name = "quanLyPhong1";
            this.quanLyPhong1.Size = new System.Drawing.Size(1080, 507);
            this.quanLyPhong1.TabIndex = 0;
            // 
            // pageKhachhang
            // 
            this.pageKhachhang.Caption = "pageKhachhang";
            this.pageKhachhang.Controls.Add(this.khachHang1);
            this.pageKhachhang.Name = "pageKhachhang";
            this.pageKhachhang.Size = new System.Drawing.Size(1080, 507);
            // 
            // khachHang1
            // 
            this.khachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHang1.Location = new System.Drawing.Point(0, 0);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1080, 507);
            this.khachHang1.TabIndex = 0;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.LightGray;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đặt phòng", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.Controls.Add(this.searchControl);
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 286);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1062, 109);
            this.windowsUIButtonPanel1.TabIndex = 1;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Location = new System.Drawing.Point(663, 36);
            this.searchControl.Margin = new System.Windows.Forms.Padding(4);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchControl.Properties.Appearance.Options.UseFont = true;
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Size = new System.Drawing.Size(315, 22);
            this.searchControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1080, 662);
            this.Controls.Add(this.PageControl);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Doc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageControl)).EndInit();
            this.PageControl.ResumeLayout(false);
            this.pageTinhtrangphong.ResumeLayout(false);
            this.pageQuanlyphong.ResumeLayout(false);
            this.pageKhachhang.ResumeLayout(false);
            this.windowsUIButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void MenuBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            PageControl.SelectedPageIndex = GroupMenu.Items.IndexOf(e.Item);

            switch(e.Item.Name)
            {
                case "menuTinhtrangphong":
                    tinhTrangPhong1.RefreshDataBinding();
                   
                    tinhTrangPhong1.GoToPage(0);
                    break;
                case "menuQuanlyphong":
                    quanLyPhong1.RefreshDataBinding();
                    quanLyPhong1.GoToPage(0);
                    break;
                default:
                    break;


            }
            //if (e.Item.Name.Equals("menuTinhtrangphong"))
            //    tinhTrangPhong1.RefreshDataBinding();

        }

        private void tinhTrangPhong1_Load(object sender, EventArgs e)
        {

        }

        private void navButtonMinimize_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}