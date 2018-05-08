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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
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
            this.pageDichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dichVu1 = new GUI.folderDichVu.DichVu();
            this.pageBaocao = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.nhanVien1 = new GUI.folderNhanVien.NhanVien();
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
            this.Doc.Size = new System.Drawing.Size(1280, 40);
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
            this.MenuBar.Size = new System.Drawing.Size(1280, 147);
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
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "Màn hình chính";
            this.menuTinhtrangphong.Elements.Add(tileItemElement1);
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
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement4.Text = "Quản lý phòng";
            this.menuQuanlyphong.Elements.Add(tileItemElement4);
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
            tileItemElement2.Text = "Loại phòng";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem3.Elements.Add(tileItemElement2);
            this.tileBarItem3.Id = 0;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            // 
            // tileBarItem4
            // 
            this.tileBarItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem4.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Cái gì đó";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem4.Elements.Add(tileItemElement3);
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
            tileItemElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement7.Text = "Khách hàng";
            this.menuKhachhang.Elements.Add(tileItemElement7);
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
            tileItemElement5.Text = "Loại khách hàng";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem1.Elements.Add(tileItemElement5);
            this.tileBarItem1.Id = 0;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "Cái gì đó";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem2.Elements.Add(tileItemElement6);
            this.tileBarItem2.Id = 1;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            // 
            // menuNhanvien
            // 
            this.menuNhanvien.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(195)))), ((int)(((byte)(96)))));
            this.menuNhanvien.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuNhanvien.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement8.Text = "Nhân viên";
            this.menuNhanvien.Elements.Add(tileItemElement8);
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
            tileItemElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement11.Text = "Dịch vụ";
            this.menuDichvu.Elements.Add(tileItemElement11);
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
            tileItemElement9.Text = "Loại dịch vụ";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem5.Elements.Add(tileItemElement9);
            this.tileBarItem5.Id = 0;
            this.tileBarItem5.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem5.Name = "tileBarItem5";
            // 
            // tileBarItem6
            // 
            this.tileBarItem6.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem6.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem6.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.Text = "Cái gì đó";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem6.Elements.Add(tileItemElement10);
            this.tileBarItem6.Id = 1;
            this.tileBarItem6.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem6.Name = "tileBarItem6";
            // 
            // menuBaocao
            // 
            this.menuBaocao.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.menuBaocao.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuBaocao.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement12.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement12.ImageOptions.ImageSize = new System.Drawing.Size(40, 40);
            tileItemElement12.Text = "Báo cáo";
            this.menuBaocao.Elements.Add(tileItemElement12);
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
            this.pageBaocao});
            this.PageControl.SelectedPage = this.pageTinhtrangphong;
            this.PageControl.Size = new System.Drawing.Size(1280, 633);
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
            this.pageTinhtrangphong.Size = new System.Drawing.Size(1280, 633);
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
            this.tinhTrangPhong1.Size = new System.Drawing.Size(1280, 633);
            this.tinhTrangPhong1.TabIndex = 0;
            this.tinhTrangPhong1.Load += new System.EventHandler(this.tinhTrangPhong1_Load);
            // 
            // pageQuanlyphong
            // 
            this.pageQuanlyphong.Caption = "pageQuanlyphong";
            this.pageQuanlyphong.Controls.Add(this.quanLyPhong1);
            this.pageQuanlyphong.Name = "pageQuanlyphong";
            this.pageQuanlyphong.Size = new System.Drawing.Size(1280, 633);
            // 
            // quanLyPhong1
            // 
            this.quanLyPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyPhong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyPhong1.Name = "quanLyPhong1";
            this.quanLyPhong1.Size = new System.Drawing.Size(1280, 633);
            this.quanLyPhong1.TabIndex = 0;
            // 
            // pageKhachhang
            // 
            this.pageKhachhang.Caption = "pageKhachhang";
            this.pageKhachhang.Controls.Add(this.khachHang1);
            this.pageKhachhang.Name = "pageKhachhang";
            this.pageKhachhang.Size = new System.Drawing.Size(1280, 633);
            // 
            // khachHang1
            // 
            this.khachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHang1.Location = new System.Drawing.Point(0, 0);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1280, 633);
            this.khachHang1.TabIndex = 0;
            // 
            // pageNhanvien
            // 
            this.pageNhanvien.Caption = "pageNhanvien";
            this.pageNhanvien.Controls.Add(this.nhanVien1);
            this.pageNhanvien.Name = "pageNhanvien";
            this.pageNhanvien.Size = new System.Drawing.Size(1280, 633);
            // 
            // pageDichvu
            // 
            this.pageDichvu.Caption = "pageDichvu";
            this.pageDichvu.Controls.Add(this.dichVu1);
            this.pageDichvu.Name = "pageDichvu";
            this.pageDichvu.Size = new System.Drawing.Size(1280, 633);
            // 
            // dichVu1
            // 
            this.dichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dichVu1.Location = new System.Drawing.Point(0, 0);
            this.dichVu1.Name = "dichVu1";
            this.dichVu1.Size = new System.Drawing.Size(1280, 633);
            this.dichVu1.TabIndex = 0;
            // 
            // pageBaocao
            // 
            this.pageBaocao.Caption = "pageBaocao";
            this.pageBaocao.Controls.Add(this.buttonEdit2);
            this.pageBaocao.Name = "pageBaocao";
            this.pageBaocao.Size = new System.Drawing.Size(1280, 633);
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
            this.buttonEdit2.Size = new System.Drawing.Size(1280, 152);
            this.buttonEdit2.TabIndex = 0;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.LightGray;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Thêm mới", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Đặt phòng", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
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
            // nhanVien1
            // 
            this.nhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVien1.Location = new System.Drawing.Point(0, 0);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(1280, 633);
            this.nhanVien1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1280, 820);
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
            this.windowsUIButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
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
                   // khachHang1.RefreshDataBinding();
                   // khachHang1.GoToPage(0);
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
    }
}