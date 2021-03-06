﻿using System;
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
        public DTO.NhanVienDTO nhanVien { get; set; }
        public MainForm()
        {         




            InitializeComponent();

            Login frmLogin = new Login();
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            frmLogin.ShowDialog();

            if (frmLogin.nhanVien == null)
            {
                Environment.Exit(-1);
            }
                
            else
                nhanVien = frmLogin.nhanVien;

            try
            {
                layoutControlItem1.Text = nhanVien.TenNhanVien;
                pictureEdit1.Image = nhanVien.HinhAnh;
                simpleLabelItem1.Text = BUS.NhanVienBUS.LayLoaiNhanVien(nhanVien.MaLoaiTaiKhoan);
            }
            catch(Exception e)
            {

            }


           // toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
            PhanQuyenTruyCap();
            

            tinhTrangPhong1.RefreshDataBinding();

            dichVu1.AddGoToLoaiDichVu(GoToHomeLoaiDichVu);
            loaiDichVu1.AddGoToDichVu(GoToHomeDichVu);

            quanLyPhong1.goToQuanLyLoaiPhong = GoToHomeLoaiPhong;
            loaiPhong1.goToQuanLyPhong = GoToHomePhong;

            khachHang1.goToLoaiKhachHang = GoToHomeLoaiKhachHang;
            loaiKhachHang1.goToKhachHang = GoToHomeKhachHang;

            baoCao1.Init();
            tinhTrangPhong1.UpdateTimeNotify();
        }



        private void BntClose_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }
             
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
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
            this.tileBarManHinhChinh = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBar5 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup5 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem9 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuQuanlyphong = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarDropDownContainer1 = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBarDropDownQuanlyphong = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem3 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuKhachhang = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarDropDownKhachhang = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBar3 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup4 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem7 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuNhanvien = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuDichvu = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarDropDownDichvu = new DevExpress.XtraBars.Navigation.TileBarDropDownContainer();
            this.tileBar2 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup3 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem6 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuHoaDon = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuBaocao = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuKhuyenMai = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.menuHeThong = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
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
            this.baoCao1 = new GUI.folderBaoCao.BaoCao();
            this.pageLoaidichvu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.loaiDichVu1 = new GUI.folderDichVu.LoaiDichVu();
            this.pageLoaikhachhang = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.loaiKhachHang1 = new GUI.folderKhachHang.LoaiKhachHang();
            this.pageLoaiphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.loaiPhong1 = new GUI.folderQuanLyPhong.LoaiPhong();
            this.pageHoadon = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.timHoaDon1 = new GUI.folderHoaDon.TimHoaDon();
            this.pageHeThong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.heThong1 = new GUI.folderHeThong.HeThong();
            this.pageDatphong = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.quanLyDatPhong1 = new GUI.folderDatPhong.QuanLyDatPhong();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimedate = new System.Windows.Forms.Label();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tileBar4 = new DevExpress.XtraBars.Navigation.TileBar();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileBarManHinhChinh)).BeginInit();
            this.tileBarManHinhChinh.SuspendLayout();
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
            this.pageLoaidichvu.SuspendLayout();
            this.pageLoaikhachhang.SuspendLayout();
            this.pageLoaiphong.SuspendLayout();
            this.pageHoadon.SuspendLayout();
            this.pageHeThong.SuspendLayout();
            this.pageDatphong.SuspendLayout();
            this.windowsUIButtonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
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
            this.Doc.BackColor = System.Drawing.Color.White;
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
            this.Doc.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.Doc.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Red;
            this.Doc.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Doc.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(1798, 40);
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
            this.MenuBar.MaxId = 15;
            this.MenuBar.MaximumSize = new System.Drawing.Size(0, 150);
            this.MenuBar.MinimumSize = new System.Drawing.Size(117, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.MenuBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.MenuBar.SelectedItem = this.menuTinhtrangphong;
            this.MenuBar.SelectionBorderWidth = 2;
            this.MenuBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.MenuBar.Size = new System.Drawing.Size(1798, 147);
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
            this.GroupMenu.Items.Add(this.menuHoaDon);
            this.GroupMenu.Items.Add(this.menuBaocao);
            this.GroupMenu.Items.Add(this.menuKhuyenMai);
            this.GroupMenu.Items.Add(this.menuHeThong);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Text = "MENU";
            // 
            // menuTinhtrangphong
            // 
            this.menuTinhtrangphong.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.menuTinhtrangphong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuTinhtrangphong.DropDownControl = this.tileBarManHinhChinh;
            this.menuTinhtrangphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement2.Text = "Màn hình chính";
            this.menuTinhtrangphong.Elements.Add(tileItemElement2);
            this.menuTinhtrangphong.Id = 10;
            this.menuTinhtrangphong.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuTinhtrangphong.Name = "menuTinhtrangphong";
            // 
            // tileBarManHinhChinh
            // 
            this.tileBarManHinhChinh.Controls.Add(this.tileBar5);
            this.tileBarManHinhChinh.Location = new System.Drawing.Point(1037, 79);
            this.tileBarManHinhChinh.Name = "tileBarManHinhChinh";
            this.tileBarManHinhChinh.Size = new System.Drawing.Size(655, 120);
            this.tileBarManHinhChinh.TabIndex = 3;
            // 
            // tileBar5
            // 
            this.tileBar5.AllowDrag = false;
            this.tileBar5.AllowSelectedItem = true;
            this.tileBar5.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar5.AppearanceText.Options.UseFont = true;
            this.tileBar5.BackColor = System.Drawing.Color.Silver;
            this.tileBar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar5.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar5.Groups.Add(this.tileBarGroup5);
            this.tileBar5.Location = new System.Drawing.Point(0, 0);
            this.tileBar5.MaxId = 2;
            this.tileBar5.Name = "tileBar5";
            this.tileBar5.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar5.Size = new System.Drawing.Size(655, 120);
            this.tileBar5.TabIndex = 1;
            this.tileBar5.Text = "tileBar5";
            // 
            // tileBarGroup5
            // 
            this.tileBarGroup5.Items.Add(this.tileBarItem9);
            this.tileBarGroup5.Name = "tileBarGroup5";
            // 
            // tileBarItem9
            // 
            this.tileBarItem9.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem9.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem9.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "Đặt phòng";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem9.Elements.Add(tileItemElement1);
            this.tileBarItem9.Id = 0;
            this.tileBarItem9.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem9.Name = "tileBarItem9";
            this.tileBarItem9.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarDatPhong_ItemClick);
            // 
            // menuQuanlyphong
            // 
            this.menuQuanlyphong.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.menuQuanlyphong.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuQuanlyphong.DropDownControl = this.tileBarDropDownContainer1;
            this.menuQuanlyphong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement4.Text = "Phòng";
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
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // tileBarItem3
            // 
            this.tileBarItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Loại phòng";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem3.Elements.Add(tileItemElement3);
            this.tileBarItem3.Id = 0;
            this.tileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem3.Name = "tileBarItem3";
            this.tileBarItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem_LoaiPhong_ItemClick);
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
            this.tileBarDropDownKhachhang.Controls.Add(this.tileBar3);
            this.tileBarDropDownKhachhang.Controls.Add(this.tileBar1);
            this.tileBarDropDownKhachhang.Location = new System.Drawing.Point(307, 79);
            this.tileBarDropDownKhachhang.Name = "tileBarDropDownKhachhang";
            this.tileBarDropDownKhachhang.Size = new System.Drawing.Size(702, 120);
            this.tileBarDropDownKhachhang.TabIndex = 1;
            // 
            // tileBar3
            // 
            this.tileBar3.AllowDrag = false;
            this.tileBar3.AllowSelectedItem = true;
            this.tileBar3.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar3.AppearanceText.Options.UseFont = true;
            this.tileBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar3.Groups.Add(this.tileBarGroup4);
            this.tileBar3.Location = new System.Drawing.Point(0, 0);
            this.tileBar3.MaxId = 2;
            this.tileBar3.Name = "tileBar3";
            this.tileBar3.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar3.Size = new System.Drawing.Size(702, 120);
            this.tileBar3.TabIndex = 1;
            this.tileBar3.Text = "tileBar3";
            this.tileBar3.Click += new System.EventHandler(this.tileBar3_Click);
            // 
            // tileBarGroup4
            // 
            this.tileBarGroup4.Items.Add(this.tileBarItem7);
            this.tileBarGroup4.Name = "tileBarGroup4";
            // 
            // tileBarItem7
            // 
            this.tileBarItem7.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem7.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem7.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "Loại khách hàng";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem7.Elements.Add(tileItemElement5);
            this.tileBarItem7.Id = 0;
            this.tileBarItem7.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem7.Name = "tileBarItem7";
            this.tileBarItem7.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem7_ItemClick);
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
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "Loại khách hàng";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem1.Elements.Add(tileItemElement6);
            this.tileBarItem1.Id = 0;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            this.tileBarItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem_LoaiKH_ItemClick);
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
            tileItemElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement10.Text = "Dịch vụ";
            this.menuDichvu.Elements.Add(tileItemElement10);
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
            this.tileBarGroup3.Items.Add(this.tileBarItem6);
            this.tileBarGroup3.Name = "tileBarGroup3";
            // 
            // tileBarItem6
            // 
            this.tileBarItem6.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarItem6.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarItem6.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.Text = "Loại dịch vụ";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarItem6.Elements.Add(tileItemElement9);
            this.tileBarItem6.Id = 1;
            this.tileBarItem6.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem6.Name = "tileBarItem6";
            this.tileBarItem6.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem_LoaiDV_ItemClick);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement11.Text = "Hóa đơn";
            this.menuHoaDon.Elements.Add(tileItemElement11);
            this.menuHoaDon.Id = 12;
            this.menuHoaDon.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuHoaDon.Name = "menuHoaDon";
            // 
            // menuBaocao
            // 
            this.menuBaocao.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.menuBaocao.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuBaocao.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            tileItemElement12.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement12.ImageOptions.ImageSize = new System.Drawing.Size(40, 40);
            tileItemElement12.Text = "Báo cáo";
            this.menuBaocao.Elements.Add(tileItemElement12);
            this.menuBaocao.Id = 5;
            this.menuBaocao.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuBaocao.Name = "menuBaocao";
            // 
            // menuKhuyenMai
            // 
            this.menuKhuyenMai.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuKhuyenMai.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuKhuyenMai.AppearanceItem.Normal.Options.UseBackColor = true;
            this.menuKhuyenMai.AppearanceItem.Normal.Options.UseFont = true;
            this.menuKhuyenMai.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement13.Text = "Chương trình khuyến mãi";
            this.menuKhuyenMai.Elements.Add(tileItemElement13);
            this.menuKhuyenMai.Id = 14;
            this.menuKhuyenMai.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuKhuyenMai.Name = "menuKhuyenMai";
            this.menuKhuyenMai.Visible = false;
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement14.Text = "Hệ thống";
            this.menuHeThong.Elements.Add(tileItemElement14);
            this.menuHeThong.Id = 13;
            this.menuHeThong.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.menuHeThong.Name = "menuHeThong";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBarItem2.Name = "tileBarItem2";
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
            this.PageControl.Controls.Add(this.pageHoadon);
            this.PageControl.Controls.Add(this.pageHeThong);
            this.PageControl.Controls.Add(this.pageDatphong);
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
            this.pageLoaiphong,
            this.pageHoadon,
            this.pageHeThong,
            this.pageDatphong});
            this.PageControl.SelectedPage = this.pageTinhtrangphong;
            this.PageControl.Size = new System.Drawing.Size(1798, 633);
            this.PageControl.TabIndex = 5;
            this.PageControl.Text = "navigationFrame";
            this.PageControl.TransitionAnimationProperties.FrameCount = 5000;
            this.PageControl.TransitionAnimationProperties.FrameInterval = 1000;
            // 
            // pageTinhtrangphong
            // 
            this.pageTinhtrangphong.Caption = "pageTinhtrangphong";
            this.pageTinhtrangphong.Controls.Add(this.tileBarManHinhChinh);
            this.pageTinhtrangphong.Controls.Add(this.tileBarDropDownDichvu);
            this.pageTinhtrangphong.Controls.Add(this.tileBarDropDownContainer1);
            this.pageTinhtrangphong.Controls.Add(this.tileBarDropDownKhachhang);
            this.pageTinhtrangphong.Controls.Add(this.tinhTrangPhong1);
            this.pageTinhtrangphong.Name = "pageTinhtrangphong";
            this.pageTinhtrangphong.Size = new System.Drawing.Size(1798, 633);
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
            this.tinhTrangPhong1.Size = new System.Drawing.Size(1798, 633);
            this.tinhTrangPhong1.TabIndex = 0;
            this.tinhTrangPhong1.Load += new System.EventHandler(this.tinhTrangPhong1_Load);
            // 
            // pageQuanlyphong
            // 
            this.pageQuanlyphong.Caption = "pageQuanlyphong";
            this.pageQuanlyphong.Controls.Add(this.quanLyPhong1);
            this.pageQuanlyphong.Name = "pageQuanlyphong";
            this.pageQuanlyphong.Size = new System.Drawing.Size(1798, 633);
            // 
            // quanLyPhong1
            // 
            this.quanLyPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyPhong1.goToQuanLyLoaiPhong = null;
            this.quanLyPhong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyPhong1.Name = "quanLyPhong1";
            this.quanLyPhong1.Size = new System.Drawing.Size(1798, 633);
            this.quanLyPhong1.TabIndex = 0;
            // 
            // pageKhachhang
            // 
            this.pageKhachhang.Caption = "pageKhachhang";
            this.pageKhachhang.Controls.Add(this.khachHang1);
            this.pageKhachhang.Name = "pageKhachhang";
            this.pageKhachhang.Size = new System.Drawing.Size(1798, 633);
            // 
            // khachHang1
            // 
            this.khachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachHang1.goToLoaiKhachHang = null;
            this.khachHang1.Location = new System.Drawing.Point(0, 0);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1798, 633);
            this.khachHang1.TabIndex = 0;
            // 
            // pageNhanvien
            // 
            this.pageNhanvien.Caption = "pageNhanvien";
            this.pageNhanvien.Controls.Add(this.nhanVien1);
            this.pageNhanvien.Name = "pageNhanvien";
            this.pageNhanvien.Size = new System.Drawing.Size(1798, 633);
            // 
            // nhanVien1
            // 
            this.nhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVien1.Location = new System.Drawing.Point(0, 0);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(1798, 633);
            this.nhanVien1.TabIndex = 0;
            // 
            // pageDichvu
            // 
            this.pageDichvu.Caption = "pageDichvu";
            this.pageDichvu.Controls.Add(this.dichVu1);
            this.pageDichvu.Name = "pageDichvu";
            this.pageDichvu.Size = new System.Drawing.Size(1798, 633);
            // 
            // dichVu1
            // 
            this.dichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dichVu1.Location = new System.Drawing.Point(0, 0);
            this.dichVu1.Name = "dichVu1";
            this.dichVu1.Size = new System.Drawing.Size(1798, 633);
            this.dichVu1.TabIndex = 0;
            // 
            // pageBaocao
            // 
            this.pageBaocao.Caption = "pageBaocao";
            this.pageBaocao.Controls.Add(this.baoCao1);
            this.pageBaocao.Name = "pageBaocao";
            this.pageBaocao.Size = new System.Drawing.Size(1798, 633);
            // 
            // baoCao1
            // 
            this.baoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baoCao1.Location = new System.Drawing.Point(0, 0);
            this.baoCao1.Name = "baoCao1";
            this.baoCao1.Size = new System.Drawing.Size(1798, 633);
            this.baoCao1.TabIndex = 0;
            // 
            // pageLoaidichvu
            // 
            this.pageLoaidichvu.Caption = "pageLoaidichvu";
            this.pageLoaidichvu.Controls.Add(this.loaiDichVu1);
            this.pageLoaidichvu.Name = "pageLoaidichvu";
            this.pageLoaidichvu.Size = new System.Drawing.Size(1798, 633);
            // 
            // loaiDichVu1
            // 
            this.loaiDichVu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiDichVu1.Location = new System.Drawing.Point(0, 0);
            this.loaiDichVu1.Name = "loaiDichVu1";
            this.loaiDichVu1.Size = new System.Drawing.Size(1798, 633);
            this.loaiDichVu1.TabIndex = 0;
            // 
            // pageLoaikhachhang
            // 
            this.pageLoaikhachhang.Caption = "pageLoaikhachhang";
            this.pageLoaikhachhang.Controls.Add(this.loaiKhachHang1);
            this.pageLoaikhachhang.Name = "pageLoaikhachhang";
            this.pageLoaikhachhang.Size = new System.Drawing.Size(1798, 633);
            // 
            // loaiKhachHang1
            // 
            this.loaiKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiKhachHang1.goToKhachHang = null;
            this.loaiKhachHang1.Location = new System.Drawing.Point(0, 0);
            this.loaiKhachHang1.Name = "loaiKhachHang1";
            this.loaiKhachHang1.Size = new System.Drawing.Size(1798, 633);
            this.loaiKhachHang1.TabIndex = 0;
            // 
            // pageLoaiphong
            // 
            this.pageLoaiphong.Caption = "pageLoaiphong";
            this.pageLoaiphong.Controls.Add(this.loaiPhong1);
            this.pageLoaiphong.Name = "pageLoaiphong";
            this.pageLoaiphong.Size = new System.Drawing.Size(1798, 633);
            // 
            // loaiPhong1
            // 
            this.loaiPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiPhong1.goToQuanLyPhong = null;
            this.loaiPhong1.Location = new System.Drawing.Point(0, 0);
            this.loaiPhong1.Name = "loaiPhong1";
            this.loaiPhong1.Size = new System.Drawing.Size(1798, 633);
            this.loaiPhong1.TabIndex = 0;
            // 
            // pageHoadon
            // 
            this.pageHoadon.Caption = "pageHoadon";
            this.pageHoadon.Controls.Add(this.timHoaDon1);
            this.pageHoadon.Name = "pageHoadon";
            this.pageHoadon.Size = new System.Drawing.Size(1798, 633);
            // 
            // timHoaDon1
            // 
            this.timHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timHoaDon1.Location = new System.Drawing.Point(0, 0);
            this.timHoaDon1.Name = "timHoaDon1";
            this.timHoaDon1.Size = new System.Drawing.Size(1798, 633);
            this.timHoaDon1.TabIndex = 0;
            // 
            // pageHeThong
            // 
            this.pageHeThong.Caption = "pageHeThong";
            this.pageHeThong.Controls.Add(this.heThong1);
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Size = new System.Drawing.Size(1798, 633);
            // 
            // heThong1
            // 
            this.heThong1.Appearance.BackColor = System.Drawing.Color.White;
            this.heThong1.Appearance.Options.UseBackColor = true;
            this.heThong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heThong1.Location = new System.Drawing.Point(0, 0);
            this.heThong1.Name = "heThong1";
            this.heThong1.Size = new System.Drawing.Size(1798, 633);
            this.heThong1.TabIndex = 0;
            // 
            // pageDatphong
            // 
            this.pageDatphong.Caption = "pageDatphong";
            this.pageDatphong.Controls.Add(this.quanLyDatPhong1);
            this.pageDatphong.Name = "pageDatphong";
            this.pageDatphong.Size = new System.Drawing.Size(1798, 633);
            // 
            // quanLyDatPhong1
            // 
            this.quanLyDatPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyDatPhong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyDatPhong1.Name = "quanLyDatPhong1";
            this.quanLyDatPhong1.Size = new System.Drawing.Size(1798, 633);
            this.quanLyDatPhong1.TabIndex = 0;
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
            this.searchControl.Size = new System.Drawing.Size(315, 30);
            this.searchControl.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimedate
            // 
            this.lbTimedate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimedate.AutoSize = true;
            this.lbTimedate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTimedate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimedate.ForeColor = System.Drawing.Color.White;
            this.lbTimedate.Location = new System.Drawing.Point(1415, 5);
            this.lbTimedate.Name = "lbTimedate";
            this.lbTimedate.Size = new System.Drawing.Size(233, 32);
            this.lbTimedate.TabIndex = 7;
            this.lbTimedate.Text = "11:29:23   31/5/2018";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Location = new System.Drawing.Point(1691, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(107, 145);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.pictureEdit1.Properties.ReadOnly = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(101, 59);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 115);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Đăng xuất";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleLabelItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(107, 145);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(107, 89);
            this.layoutControlItem1.Text = "TAN PHAT";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 20);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(107, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.DimGray;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 89);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(107, 23);
            this.simpleLabelItem1.Text = "Nhân viên";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(76, 17);
            // 
            // tileBar4
            // 
            this.tileBar4.AllowDrag = false;
            this.tileBar4.AllowSelectedItem = true;
            this.tileBar4.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar4.AppearanceText.Options.UseFont = true;
            this.tileBar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileBar4.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar4.Location = new System.Drawing.Point(0, 0);
            this.tileBar4.Name = "tileBar4";
            this.tileBar4.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar4.Size = new System.Drawing.Size(240, 150);
            this.tileBar4.TabIndex = 0;
            // 
            // timerNotify
            // 
            this.timerNotify.Enabled = true;
            this.timerNotify.Interval = 30000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "0cf87b7f-7445-4e2d-a81b-179f23ef6aaa";
            this.toastNotificationsManager1.ApplicationName = "GUI";
            this.toastNotificationsManager1.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("bbcda021-85e1-4f65-be88-feda0ef80a40", null, "Pellentesque lacinia tellus eget volutpat a", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Long, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04)});
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1798, 820);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.lbTimedate);
            this.Controls.Add(this.PageControl);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Doc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileBarManHinhChinh)).EndInit();
            this.tileBarManHinhChinh.ResumeLayout(false);
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
            this.pageLoaidichvu.ResumeLayout(false);
            this.pageLoaikhachhang.ResumeLayout(false);
            this.pageLoaiphong.ResumeLayout(false);
            this.pageHoadon.ResumeLayout(false);
            this.pageHeThong.ResumeLayout(false);
            this.pageDatphong.ResumeLayout(false);
            this.windowsUIButtonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
                    quanLyPhong1.GoToPage_WithoutAnimation(0);
                    break;
                case "menuKhachhang":
                    PageControl.SelectedPage = pageKhachhang;
                    khachHang1.RefreshDataBinding();
                    khachHang1.GoToPage(0);
                    break;
                case "menuNhanvien":
                    PageControl.SelectedPage = pageNhanvien;
                    nhanVien1.RefreshDataBinding();
                    nhanVien1.GoToPage_WithoutAnimation(0);
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
                case "menuHeThong":
                    
                    heThong1.RefreshDataBinding();
                    heThong1.GoToPage_WithoutAnimation(0);
                    PageControl.SelectedPage = pageHeThong;
                    break;
                case "menuHoaDon":
                    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitForm1));
                    timHoaDon1.RefreshDataBinding();
                    timHoaDon1.GoToPage_WithoutAnimation(0);
                    PageControl.SelectedPage = pageHoadon;
                    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
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
            lbTimedate.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") ;
            //Clock.Text = DateTime.Now.ToString("hh:mm:ss");
            // Date.Text = DateTime.Now.ToString("dd MM yyyy");
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

        public void GoToHomeKhachHang()
        {
            khachHang1.RefreshDataBinding();
            khachHang1.GoToHomePageWithoutAnimation();
            PageControl.SelectedPage = pageKhachhang;
        }

        public void GoToHomeLoaiKhachHang()
        {
            loaiKhachHang1.RefreshDataBinding();
            loaiKhachHang1.GoToHomePageWithoutAnimation();
            PageControl.SelectedPage = pageLoaikhachhang;
        }

        public void GoToHomeDichVu()
        {
            dichVu1.RefreshDataBinding();
            dichVu1.GoToPage(0);
            PageControl.SelectedPage = pageDichvu;
        }

        public void GoToHomePhong()
        {
            quanLyPhong1.RefreshDataBinding();
            quanLyPhong1.GoToPage_WithoutAnimation(0);
            PageControl.SelectedPage = pageQuanlyphong;
        }
        public void GoToHomeLoaiPhong()
        {
            loaiPhong1.RefreshDataBinding();
            loaiPhong1.GoToPage_WithoutAnimation(0);
            PageControl.SelectedPage = pageLoaiphong;
        }

        private void tileBarItem_LoaiKH_ItemClick(object sender, TileItemEventArgs e)
        {
            MenuBar.HideDropDownWindow();
            GoToHomeLoaiKhachHang();
            PageControl.SelectedPage = pageLoaikhachhang;

        }

        private void tileBarItem_LoaiPhong_ItemClick(object sender, TileItemEventArgs e)
        {
            MenuBar.HideDropDownWindow();
            loaiPhong1.GoToPage_WithoutAnimation(0);
            loaiPhong1.RefreshDataBinding();
            PageControl.SelectedPage = pageLoaiphong;
        }

        private void tileBarDatPhong_ItemClick(object sender, TileItemEventArgs e)
        {
            MenuBar.HideDropDownWindow();
            quanLyDatPhong1.RefreshDataBinding();
            quanLyDatPhong1.GoToPage_WithoutAnimation(0); 
            PageControl.SelectedPage = pageDatphong;
        }

        public void HienThiThongTinDatPhong(int maDatPhong)
        {
            quanLyDatPhong1.HienThiThongTinDatPhong(maDatPhong);
            PageControl.SelectedPage = pageDatphong;
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {

            NotifyTimer_Tick();
        }

        public void NotifyTimer_Tick()
        {
            tinhTrangPhong1.UpdateTimeNotify();
        }

        public DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager GeToastNotifications()
        {
            return toastNotificationsManager1;
        }

        public void HienThiThongTinPhong(DTO.ThuePhongDTO dto)
        {
            tinhTrangPhong1.RefreshDataBinding();
            tinhTrangPhong1.HienThiThongTinPhong(dto);
            PageControl.SelectedPage = pageTinhtrangphong;
        }

        public void HienThiThongTinDatPhong(DTO.DatPhongDTO dto)
        {
            quanLyDatPhong1.RefreshDataBinding();
            quanLyDatPhong1.HienThiThongTinDatPhong(dto);
            PageControl.SelectedPage = pageDatphong;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;

            nhanVien = null;
            Login frmLogin = new Login();
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            frmLogin.ShowDialog();

            if (frmLogin.nhanVien == null)
            {
                Environment.Exit(-1);
            }

            else
                nhanVien = frmLogin.nhanVien;

            try
            {
                layoutControlItem1.Text = nhanVien.TenNhanVien;
                pictureEdit1.Image = nhanVien.HinhAnh;
                simpleLabelItem1.Text = BUS.NhanVienBUS.LayLoaiNhanVien(nhanVien.MaLoaiTaiKhoan);
            }
            catch (Exception ex)
            {

            }


            PhanQuyenTruyCap();

            PageControl.SelectedPage = pageTinhtrangphong;
        }
        void PhanQuyenTruyCap()
        {
            if (nhanVien.MaLoaiTaiKhoan != 2)
            {
                menuNhanvien.Visible = false;
                menuHeThong.Visible = false;
                menuBaocao.Visible = false;
                menuQuanlyphong.Visible = false;
                menuDichvu.Visible = false;
                tileBar3.Visible = false;
                tileBar2.Visible = false;
                tileBarDropDownQuanlyphong.Visible = false;
                tileBarGroup2.Visible = false;
            }
            else
            {
                menuNhanvien.Visible = true;
                menuHeThong.Visible = true;
                menuBaocao.Visible = true;
                menuQuanlyphong.Visible = true;
                menuDichvu.Visible = true;
                tileBar3.Visible = true;
                tileBar2.Visible = true;
                tileBarDropDownQuanlyphong.Visible = true;
                tileBarGroup2.Visible = true;
            }
        }

        private void tileBar3_Click(object sender, EventArgs e)
        {

        }

        private void tileBarItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            MenuBar.HideDropDownWindow();
            loaiKhachHang1.GoToHomePageWithoutAnimation();
            loaiKhachHang1.RefreshDataBinding();
            PageControl.SelectedPage = pageLoaikhachhang;
        }
    }
}