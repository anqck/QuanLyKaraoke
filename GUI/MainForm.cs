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

            dichVu1.AddGoToLoaiDichVu(GoToHomeLoaiDichVu);
            loaiDichVu1.AddGoToDichVu(GoToHomeDichVu);

        }



        private void BntClose_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }
             
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement22 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement23 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement24 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement19 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement29 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement30 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
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
            this.tileBarDropDownContainer1 = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBarDropDownQuanlyphong = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem4 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuKhachhang = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarDropDownKhachhang = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuNhanvien = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuDichvu = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarDropDownDichvu = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBar2 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup3 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem5 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem6 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuBaocao = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.PageControl = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageTinhtrangphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tinhTrangPhong1 = new GUI.TinhTrangPhong.TinhTrangPhong();
            this.pageQuanlyphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.quanLyPhong1 = new GUI.folderQuanLyPhong.QuanLyPhong();
            this.pageKhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.khachHang1 = new GUI.folderKhachHang.KhachHang();
            this.pageNhanvien = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.nhanVien1 = new GUI.folderNhanVien.NhanVien();
            this.pageDichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dichVu1 = new GUI.folderDichVu.DichVu();
            this.pageBaocao = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.pageLoaidichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.loaiDichVu1 = new GUI.folderDichVu.LoaiDichVu();
            this.pageLoaikhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.loaiKhachHang1 = new GUI.folderKhachHang.LoaiKhachHang();
            this.pageLoaiphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.loaiPhong1 = new GUI.folderQuanLyPhong.LoaiPhong();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.picNV = new DevExpress.XtraEditors.PictureEdit();
            this.bntDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.Clock = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Date = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbUser = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbLoaiNV = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileBarDropDownContainer1)).BeginInit();
            this.tileBarDropDownContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileBarDropDownKhachhang)).BeginInit();
            this.tileBarDropDownKhachhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileBarDropDownDichvu)).BeginInit();
            this.tileBarDropDownDichvu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageControl)).BeginInit();
            this.PageControl.SuspendLayout();
            this.pageTinhtrangphong.SuspendLayout();
            this.pageQuanlyphong.SuspendLayout();
            this.pageKhachhang.SuspendLayout();
            this.pageNhanvien.SuspendLayout();
            this.pageDichvu.SuspendLayout();
            this.pageBaocao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
            this.pageLoaidichvu.SuspendLayout();
            this.pageLoaikhachhang.SuspendLayout();
            this.pageLoaiphong.SuspendLayout();
            this.windowsUIButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLoaiNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.Doc.Size = new System.Drawing.Size(1637, 40);
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
            this.MenuBar.IndentBetweenItems = 20;
            this.MenuBar.ItemPadding = new System.Windows.Forms.Padding(5);
            this.MenuBar.ItemSize = 80;
            this.MenuBar.Location = new System.Drawing.Point(0, 40);
            this.MenuBar.Margin = new System.Windows.Forms.Padding(2, 2, 5, 0);
            this.MenuBar.MaxId = 12;
            this.MenuBar.MaximumSize = new System.Drawing.Size(0, 150);
            this.MenuBar.MinimumSize = new System.Drawing.Size(117, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.MenuBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.MenuBar.SelectedItem = this.menuTinhtrangphong;
            this.MenuBar.SelectionBorderWidth = 2;
            this.MenuBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.MenuBar.Size = new System.Drawing.Size(1637, 147);
            this.MenuBar.TabIndex = 4;
            this.MenuBar.TabStop = false;
            this.MenuBar.Text = "tileBar";
            this.MenuBar.WideTileWidth = 180;
            this.MenuBar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.MenuBar_ClickItem);
            // 
            // GroupMenu
            // 
            this.GroupMenu.Items.Add(this.menuTinhtrangphong);
            this.GroupMenu.Items.Add(this.menuQuanlyphong);
            this.GroupMenu.Items.Add(this.menuKhachhang);
            this.GroupMenu.Items.Add(this.menuNhanvien);
            this.GroupMenu.Items.Add(this.menuDichvu);
            this.GroupMenu.Items.Add(this.menuBaocao);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Text = "GROUP GÌ ĐÓ";
            // 
            // menuTinhtrangphong
            // 
            this.menuTinhtrangphong.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.menuTinhtrangphong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuTinhtrangphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement22.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement22.Text = "Màn hình chính";
            this.menuTinhtrangphong.Elements.Add(tileItemElement22);
            this.menuTinhtrangphong.Id = 10;
            this.menuTinhtrangphong.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuTinhtrangphong.Name = "menuTinhtrangphong";
            // 
            // menuQuanlyphong
            // 
            this.menuQuanlyphong.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.menuQuanlyphong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuQuanlyphong.DropDownControl = this.tileBarDropDownContainer1;
            this.menuQuanlyphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement23.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement23.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement23.Text = "Quản lý phòng";
            this.menuQuanlyphong.Elements.Add(tileItemElement23);
            this.menuQuanlyphong.Id = 4;
            this.menuQuanlyphong.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuQuanlyphong.Name = "menuQuanlyphong";
            this.menuQuanlyphong.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarDropDownContainer1
            // 
            this.tileBarDropDownContainer1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.tileBarDropDownContainer1.Appearance.Options.UseBackColor = true;
            this.tileBarDropDownContainer1.Controls.Add(this.tileBarDropDownQuanlyphong);
            this.tileBarDropDownContainer1.Location = new System.Drawing.Point(307, 217);
            this.tileBarDropDownContainer1.Name = "tileBarDropDownContainer1";
            this.tileBarDropDownContainer1.Size = new System.Drawing.Size(702, 120);
            this.tileBarDropDownContainer1.TabIndex = 2;
            // 
            // tileBarDropDownQuanlyphong
            // 
            this.tileBarDropDownQuanlyphong.AllowDrag = false;
            this.tileBarDropDownQuanlyphong.AllowSelectedItem = true;
            this.tileBarDropDownQuanlyphong.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarDropDownQuanlyphong.AppearanceText.Options.UseFont = true;
            this.tileBarDropDownQuanlyphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBarDropDownQuanlyphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBarDropDownQuanlyphong.Groups.Add(this.tileBarGroup1);
            this.tileBarDropDownQuanlyphong.Location = new System.Drawing.Point(0, 0);
            this.tileBarDropDownQuanlyphong.MaxId = 2;
            this.tileBarDropDownQuanlyphong.Name = "tileBarDropDownQuanlyphong";
            this.tileBarDropDownQuanlyphong.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBarDropDownQuanlyphong.Size = new System.Drawing.Size(702, 120);
            this.tileBarDropDownQuanlyphong.TabIndex = 0;
            this.tileBarDropDownQuanlyphong.Text = "tileBar2";
            // 
            // tileBarGroup1
            // 
            this.tileBarGroup1.Items.Add(this.tileBarItem3);
            this.tileBarGroup1.Items.Add(this.tileBarItem4);
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement14.Text = "Loại phòng";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem3.Elements.Add(tileItemElement14);
            this.tileBarItem3.Id = 0;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            this.tileBarItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem_LoaiPhong_ItemClick);
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem4.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement24.Text = "Cái gì đó";
            tileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem4.Elements.Add(tileItemElement24);
            this.tileBarItem4.Id = 1;
            this.tileBarItem4.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem4.Name = "tileBarItem4";
            // 
            // menuKhachhang
            // 
            this.menuKhachhang.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.menuKhachhang.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuKhachhang.DropDownControl = this.tileBarDropDownKhachhang;
            this.menuKhachhang.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement25.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement25.Text = "Khách hàng";
            this.menuKhachhang.Elements.Add(tileItemElement25);
            this.menuKhachhang.Id = 6;
            this.menuKhachhang.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuKhachhang.Name = "menuKhachhang";
            this.menuKhachhang.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarDropDownKhachhang
            // 
            this.tileBarDropDownKhachhang.Appearance.BackColor = System.Drawing.Color.Silver;
            this.tileBarDropDownKhachhang.Appearance.Options.UseBackColor = true;
            this.tileBarDropDownKhachhang.Controls.Add(this.tileBar1);
            this.tileBarDropDownKhachhang.Location = new System.Drawing.Point(307, 79);
            this.tileBarDropDownKhachhang.Name = "tileBarDropDownKhachhang";
            this.tileBarDropDownKhachhang.Size = new System.Drawing.Size(702, 120);
            this.tileBarDropDownKhachhang.TabIndex = 1;
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceText.Options.UseFont = true;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 2;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(702, 120);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItem1);
            this.tileBarGroup2.Items.Add(this.tileBarItem2);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement16.Text = "Loại khách hàng";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem1.Elements.Add(tileItemElement16);
            this.tileBarItem1.Id = 0;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            this.tileBarItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem_LoaiKH_ItemClick);
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement26.Text = "Cái gì đó";
            tileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem2.Elements.Add(tileItemElement26);
            this.tileBarItem2.Id = 1;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // menuNhanvien
            // 
            this.menuNhanvien.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.menuNhanvien.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuNhanvien.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement27.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement27.Text = "Nhân viên";
            this.menuNhanvien.Elements.Add(tileItemElement27);
            this.menuNhanvien.Id = 9;
            this.menuNhanvien.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuNhanvien.Name = "menuNhanvien";
            // 
            // menuDichvu
            // 
            this.menuDichvu.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(216)))), ((int)(((byte)(96)))));
            this.menuDichvu.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuDichvu.DropDownControl = this.tileBarDropDownDichvu;
            this.menuDichvu.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement28.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement28.Text = "Dịch vụ";
            this.menuDichvu.Elements.Add(tileItemElement28);
            this.menuDichvu.Id = 11;
            this.menuDichvu.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuDichvu.Name = "menuDichvu";
            this.menuDichvu.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tileBarDropDownDichvu
            // 
            this.tileBarDropDownDichvu.Appearance.BackColor = System.Drawing.Color.Silver;
            this.tileBarDropDownDichvu.Appearance.Options.UseBackColor = true;
            this.tileBarDropDownDichvu.Controls.Add(this.tileBar2);
            this.tileBarDropDownDichvu.Location = new System.Drawing.Point(307, 343);
            this.tileBarDropDownDichvu.Name = "tileBarDropDownDichvu";
            this.tileBarDropDownDichvu.Size = new System.Drawing.Size(702, 120);
            this.tileBarDropDownDichvu.TabIndex = 2;
            // 
            // tileBar2
            // 
            this.tileBar2.AllowDrag = false;
            this.tileBar2.AllowSelectedItem = true;
            this.tileBar2.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar2.AppearanceText.Options.UseFont = true;
            this.tileBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar2.Groups.Add(this.tileBarGroup3);
            this.tileBar2.Location = new System.Drawing.Point(0, 0);
            this.tileBar2.MaxId = 2;
            this.tileBar2.Name = "tileBar2";
            this.tileBar2.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar2.Size = new System.Drawing.Size(702, 120);
            this.tileBar2.TabIndex = 0;
            this.tileBar2.Text = "tileBar2";
            // 
            // tileBarGroup3
            // 
            this.tileBarGroup3.Items.Add(this.tileBarItem5);
            this.tileBarGroup3.Items.Add(this.tileBarItem6);
            this.tileBarGroup3.Name = "tileBarGroup3";
            // 
            // tileBarItem5
            // 
            this.tileBarItem5.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem5.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement19.Text = "Dịch vụ";
            tileItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem5.Elements.Add(tileItemElement19);
            this.tileBarItem5.Id = 0;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem5.Name = "tileBarItem5";
            // 
            // tileBarItem6
            // 
            this.tileBarItem6.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem6.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem6.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement29.Text = "Loại dịch vụ";
            tileItemElement29.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem6.Elements.Add(tileItemElement29);
            this.tileBarItem6.Id = 1;
            this.tileBarItem6.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem6.Name = "tileBarItem6";
            this.tileBarItem6.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem_LoaiDV_ItemClick);
            // 
            // menuBaocao
            // 
            this.menuBaocao.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.menuBaocao.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuBaocao.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement30.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement30.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement30.ImageOptions.ImageSize = new System.Drawing.Size(40, 40);
            tileItemElement30.Text = "Báo cáo";
            this.menuBaocao.Elements.Add(tileItemElement30);
            this.menuBaocao.Id = 5;
            this.menuBaocao.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuBaocao.Name = "menuBaocao";
            // 
            // PageControl
            // 
            this.PageControl.Appearance.BackColor = System.Drawing.Color.White;
            this.PageControl.Appearance.Options.UseBackColor = true;
            this.PageControl.Controls.Add(this.pageTinhtrangphong);
            this.PageControl.Controls.Add(this.pageQuanlyphong);
            this.PageControl.Controls.Add(this.pageKhachhang);
            this.PageControl.Controls.Add(this.pageNhanvien);
            this.PageControl.Controls.Add(this.pageDichvu);
            this.PageControl.Controls.Add(this.pageBaocao);
            this.PageControl.Controls.Add(this.pageLoaidichvu);
            this.PageControl.Controls.Add(this.pageLoaikhachhang);
            this.PageControl.Controls.Add(this.pageLoaiphong);
            this.PageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageControl.Location = new System.Drawing.Point(0, 187);
            this.PageControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PageControl.Name = "PageControl";
            this.PageControl.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageTinhtrangphong,
            this.pageQuanlyphong,
            this.pageKhachhang,
            this.pageNhanvien,
            this.pageDichvu,
            this.pageBaocao,
            this.pageLoaikhachhang,
            this.pageLoaidichvu,
            this.pageLoaiphong});
            this.PageControl.SelectedPage = this.pageTinhtrangphong;
            this.PageControl.Size = new System.Drawing.Size(1637, 633);
            this.PageControl.TabIndex = 5;
            this.PageControl.Text = "navigationFrame";
            this.PageControl.TransitionAnimationProperties.FrameCount = 5000;
            this.PageControl.TransitionAnimationProperties.FrameInterval = 1000;
            // 
            // pageTinhtrangphong
            // 
            this.pageTinhtrangphong.Caption = "pageTinhtrangphong";
            this.pageTinhtrangphong.Controls.Add(this.tileBarDropDownDichvu);
            this.pageTinhtrangphong.Controls.Add(this.tileBarDropDownContainer1);
            this.pageTinhtrangphong.Controls.Add(this.tileBarDropDownKhachhang);
            this.pageTinhtrangphong.Controls.Add(this.tinhTrangPhong1);
            this.pageTinhtrangphong.Name = "pageTinhtrangphong";
            this.pageTinhtrangphong.Size = new System.Drawing.Size(1637, 633);
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
            this.tinhTrangPhong1.Size = new System.Drawing.Size(1637, 633);
            this.tinhTrangPhong1.TabIndex = 0;
            this.tinhTrangPhong1.Load += new System.EventHandler(this.tinhTrangPhong1_Load);
            // 
            // pageQuanlyphong
            // 
            this.pageQuanlyphong.Caption = "pageQuanlyphong";
            this.pageQuanlyphong.Controls.Add(this.quanLyPhong1);
            this.pageQuanlyphong.Name = "pageQuanlyphong";
            this.pageQuanlyphong.Size = new System.Drawing.Size(1637, 633);
            // 
            // quanLyPhong1
            // 
            this.quanLyPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyPhong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyPhong1.Name = "quanLyPhong1";
            this.quanLyPhong1.Size = new System.Drawing.Size(1637, 633);
            this.quanLyPhong1.TabIndex = 0;
            // 
            // pageKhachhang
            // 
            this.pageKhachhang.Caption = "pageKhachhang";
            this.pageKhachhang.Controls.Add(this.khachHang1);
            this.pageKhachhang.Name = "pageKhachhang";
            this.pageKhachhang.Size = new System.Drawing.Size(1637, 633);
            // 
            // khachHang1
            // 
            this.khachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHang1.Location = new System.Drawing.Point(0, 0);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1637, 633);
            this.khachHang1.TabIndex = 0;
            // 
            // pageNhanvien
            // 
            this.pageNhanvien.Caption = "pageNhanvien";
            this.pageNhanvien.Controls.Add(this.nhanVien1);
            this.pageNhanvien.Name = "pageNhanvien";
            this.pageNhanvien.Size = new System.Drawing.Size(1637, 633);
            // 
            // nhanVien1
            // 
            this.nhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVien1.Location = new System.Drawing.Point(0, 0);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(1637, 633);
            this.nhanVien1.TabIndex = 0;
            // 
            // pageDichvu
            // 
            this.pageDichvu.Caption = "pageDichvu";
            this.pageDichvu.Controls.Add(this.dichVu1);
            this.pageDichvu.Name = "pageDichvu";
            this.pageDichvu.Size = new System.Drawing.Size(1637, 633);
            // 
            // dichVu1
            // 
            this.dichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dichVu1.Location = new System.Drawing.Point(0, 0);
            this.dichVu1.Name = "dichVu1";
            this.dichVu1.Size = new System.Drawing.Size(1637, 633);
            this.dichVu1.TabIndex = 0;
            // 
            // pageBaocao
            // 
            this.pageBaocao.Caption = "pageBaocao";
            this.pageBaocao.Controls.Add(this.filterControl1);
            this.pageBaocao.Controls.Add(this.buttonEdit2);
            this.pageBaocao.Name = "pageBaocao";
            this.pageBaocao.Size = new System.Drawing.Size(1637, 633);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Location = new System.Drawing.Point(418, 237);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(509, 297);
            this.filterControl1.TabIndex = 1;
            this.filterControl1.Text = "filterControl1";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit2.EditValue = "báo cáo";
            this.buttonEdit2.Location = new System.Drawing.Point(0, 0);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit2.Properties.Appearance.Options.UseFont = true;
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Size = new System.Drawing.Size(1637, 152);
            this.buttonEdit2.TabIndex = 0;
            // 
            // pageLoaidichvu
            // 
            this.pageLoaidichvu.Caption = "pageLoaidichvu";
            this.pageLoaidichvu.Controls.Add(this.loaiDichVu1);
            this.pageLoaidichvu.Name = "pageLoaidichvu";
            this.pageLoaidichvu.Size = new System.Drawing.Size(1637, 633);
            // 
            // loaiDichVu1
            // 
            this.loaiDichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiDichVu1.Location = new System.Drawing.Point(0, 0);
            this.loaiDichVu1.Name = "loaiDichVu1";
            this.loaiDichVu1.Size = new System.Drawing.Size(1637, 633);
            this.loaiDichVu1.TabIndex = 0;
            // 
            // pageLoaikhachhang
            // 
            this.pageLoaikhachhang.Caption = "pageLoaikhachhang";
            this.pageLoaikhachhang.Controls.Add(this.loaiKhachHang1);
            this.pageLoaikhachhang.Name = "pageLoaikhachhang";
            this.pageLoaikhachhang.Size = new System.Drawing.Size(1637, 633);
            // 
            // loaiKhachHang1
            // 
            this.loaiKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiKhachHang1.Location = new System.Drawing.Point(0, 0);
            this.loaiKhachHang1.Name = "loaiKhachHang1";
            this.loaiKhachHang1.Size = new System.Drawing.Size(1637, 633);
            this.loaiKhachHang1.TabIndex = 0;
            // 
            // pageLoaiphong
            // 
            this.pageLoaiphong.Caption = "pageLoaiphong";
            this.pageLoaiphong.Controls.Add(this.loaiPhong1);
            this.pageLoaiphong.Name = "pageLoaiphong";
            this.pageLoaiphong.Size = new System.Drawing.Size(1637, 633);
            // 
            // loaiPhong1
            // 
            this.loaiPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiPhong1.Location = new System.Drawing.Point(0, 0);
            this.loaiPhong1.Name = "loaiPhong1";
            this.loaiPhong1.Size = new System.Drawing.Size(1637, 633);
            this.loaiPhong1.TabIndex = 0;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.LightGray;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đặt phòng", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.layoutControl1.Controls.Add(this.gaugeControl1);
            this.layoutControl1.Controls.Add(this.gaugeControl2);
            this.layoutControl1.Controls.Add(this.picNV);
            this.layoutControl1.Controls.Add(this.bntDangXuat);
            this.layoutControl1.Location = new System.Drawing.Point(1084, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(553, 145);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.lbUser,
            this.layoutControlItem1,
            this.lbLoaiNV,
            this.emptySpaceItem2,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(553, 145);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // picNV
            // 
            this.picNV.Location = new System.Drawing.Point(192, 16);
            this.picNV.Name = "picNV";
            this.picNV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.picNV.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picNV.Size = new System.Drawing.Size(89, 78);
            this.picNV.StyleController = this.layoutControl1;
            this.picNV.TabIndex = 4;
            // 
            // bntDangXuat
            // 
            this.bntDangXuat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangXuat.Appearance.Options.UseFont = true;
            this.bntDangXuat.Location = new System.Drawing.Point(192, 100);
            this.bntDangXuat.Name = "bntDangXuat";
            this.bntDangXuat.Size = new System.Drawing.Size(89, 29);
            this.bntDangXuat.StyleController = this.layoutControl1;
            this.bntDangXuat.TabIndex = 5;
            this.bntDangXuat.Text = "Đăng xuất";
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.Clock});
            this.gaugeControl1.LayoutPadding = new DevExpress.XtraGauges.Core.Base.Thickness(0);
            this.gaugeControl1.Location = new System.Drawing.Point(287, 16);
            this.gaugeControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(250, 69);
            this.gaugeControl1.TabIndex = 6;
            // 
            // Clock
            // 
            this.Clock.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EEECDF");
            this.Clock.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#524E48");
            this.Clock.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.Clock.Bounds = new System.Drawing.Rectangle(0, 0, 250, 69);
            this.Clock.DigitCount = 6;
            this.Clock.Name = "Clock";
            this.Clock.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.Clock.Text = "10:20:35";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(313.775F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style18;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.Date});
            this.gaugeControl2.LayoutPadding = new DevExpress.XtraGauges.Core.Base.Thickness(0);
            this.gaugeControl2.Location = new System.Drawing.Point(287, 88);
            this.gaugeControl2.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(250, 41);
            this.gaugeControl2.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem4.Control = this.gaugeControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(271, 75);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 0, 3);
            this.layoutControlItem4.Size = new System.Drawing.Size(256, 44);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Date
            // 
            this.Date.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E9EFF3");
            this.Date.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0F89B8");
            this.Date.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent2});
            this.Date.Bounds = new System.Drawing.Rectangle(0, 0, 250, 41);
            this.Date.DigitCount = 10;
            this.Date.Name = "Date";
            this.Date.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.Date.Text = "05 31 2018";
            // 
            // digitalBackgroundLayerComponent2
            // 
            this.digitalBackgroundLayerComponent2.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(505.625F, 99.9625F);
            this.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style18;
            this.digitalBackgroundLayerComponent2.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gaugeControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(271, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(256, 75);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // lbUser
            // 
            this.lbUser.AllowHotTrack = false;
            this.lbUser.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.AppearanceItemCaption.Options.UseFont = true;
            this.lbUser.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lbUser.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbUser.Location = new System.Drawing.Point(0, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(176, 30);
            this.lbUser.Text = "TANPHAT123";
            this.lbUser.TextSize = new System.Drawing.Size(134, 24);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bntDangXuat;
            this.layoutControlItem1.Location = new System.Drawing.Point(176, 84);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(95, 35);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lbLoaiNV
            // 
            this.lbLoaiNV.AllowHotTrack = false;
            this.lbLoaiNV.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiNV.AppearanceItemCaption.ForeColor = System.Drawing.Color.Gray;
            this.lbLoaiNV.AppearanceItemCaption.Options.UseFont = true;
            this.lbLoaiNV.AppearanceItemCaption.Options.UseForeColor = true;
            this.lbLoaiNV.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lbLoaiNV.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbLoaiNV.Location = new System.Drawing.Point(0, 30);
            this.lbLoaiNV.Name = "lbLoaiNV";
            this.lbLoaiNV.Size = new System.Drawing.Size(176, 29);
            this.lbLoaiNV.Text = "NHANVIEN";
            this.lbLoaiNV.TextSize = new System.Drawing.Size(134, 23);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 49);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(176, 70);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.picNV;
            this.layoutControlItem2.Location = new System.Drawing.Point(176, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(95, 84);
            this.layoutControlItem2.Text = "TANPHAT123";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1637, 820);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.PageControl);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Doc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileBarDropDownContainer1)).EndInit();
            this.tileBarDropDownContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tileBarDropDownKhachhang)).EndInit();
            this.tileBarDropDownKhachhang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tileBarDropDownDichvu)).EndInit();
            this.tileBarDropDownDichvu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PageControl)).EndInit();
            this.PageControl.ResumeLayout(false);
            this.pageTinhtrangphong.ResumeLayout(false);
            this.pageQuanlyphong.ResumeLayout(false);
            this.pageKhachhang.ResumeLayout(false);
            this.pageNhanvien.ResumeLayout(false);
            this.pageDichvu.ResumeLayout(false);
            this.pageBaocao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
            this.pageLoaidichvu.ResumeLayout(false);
            this.pageLoaikhachhang.ResumeLayout(false);
            this.pageLoaiphong.ResumeLayout(false);
            this.windowsUIButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLoaiNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        private void MenuBar_ClickItem(object sender, TileItemEventArgs e)
        {
           // PageControl.SelectedPageIndex = GroupMenu.Items.IndexOf(e.Item);

            switch(e.Item.Name)
            {
                case "menuTinhtrangphong":
                    PageControl.SelectedPage = pageTinhtrangphong;
                    tinhTrangPhong1.RefreshDataBinding();
                    tinhTrangPhong1.GoToPage(0);
                    break;
                case "menuQuanlyphong":
                    PageControl.SelectedPage = pageQuanlyphong;
                    quanLyPhong1.RefreshDataBinding();
                    quanLyPhong1.GoToPage(0);
                    break;
                case "menuKhachhang":
                    PageControl.SelectedPage = pageKhachhang;
                    khachHang1.RefreshDataBinding();
                    khachHang1.GoToPage(0);
                    break;
                case "menuNhanvien":
                    PageControl.SelectedPage = pageNhanvien;
                    //khachHang1.RefreshDataBinding();
                   // khachHang1.GoToPage(0);
                    break;
                case "menuDichvu":
                    PageControl.SelectedPage = pageDichvu;
                    dichVu1.RefreshDataBinding();
                    dichVu1.GoToPage(0);
                    break;
                case "menuBaocao":
                    PageControl.SelectedPage = pageBaocao;
                   // khachHang1.RefreshDataBinding();
                   // khachHang1.GoToPage(0);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tinhTrangPhong1.UpdateTime();
            Clock.Text = DateTime.Now.ToString("hh:mm:ss");
            Date.Text = DateTime.Now.ToString("dd MM yyyy");
        }

        private void tileItem_LoaiDV_ItemClick(object sender, TileItemEventArgs e)
        {
            
            MenuBar.HideDropDownWindow();

            GoToHomeLoaiDichVu();


        }

        public void GoToHomeLoaiDichVu()
        {
            loaiDichVu1.RefreshDataBinding();
            loaiDichVu1.GoToHomePageWithoutAnimation();
            PageControl.SelectedPage = pageLoaidichvu;
        }

        public void GoToHomeDichVu()
        {
            dichVu1.RefreshDataBinding();
            dichVu1.GoToPage(0);
            PageControl.SelectedPage = pageDichvu;
        }

        private void tileBarItem_LoaiKH_ItemClick(object sender, TileItemEventArgs e)
        {
            MenuBar.HideDropDownWindow();
            PageControl.SelectedPage = pageLoaikhachhang;

        }

        private void tileBarItem_LoaiPhong_ItemClick(object sender, TileItemEventArgs e)
        {
            MenuBar.HideDropDownWindow();
            PageControl.SelectedPage = pageLoaiphong;
        }
    }
}