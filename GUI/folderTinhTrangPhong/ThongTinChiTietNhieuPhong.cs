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
using DevExpress.XtraTab;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThongTinChiTietNhieuPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public Action goBackHome { get; set; }
        private HoaDonDTO hoaDon;

        private Action goToThanhToan;
        private ThuePhongDTO thuePhongDTO;

        public ThongTinChiTietNhieuPhong()
        {
            InitializeComponent();

            //this.TabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //this.TabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //this.TabControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            //this.TabControl.LookAndFeel.UseDefaultLookAndFeel = false;
        }

        private void thongTinChiTietPhong1_Load(object sender, EventArgs e)
        {

        }
        public void RefreshDataBinding(ThuePhongDTO thuePhongDTO,Action goToThanhToan)
        {
            this.goToThanhToan = goToThanhToan;
            this.thuePhongDTO = thuePhongDTO;

            TabControl.TabPages.Clear();

            this.hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhongDTO.MaHoaDon);


            foreach (ThuePhongDTO thuePhong in HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon))
            {
                ThongTinChiTietPhong thongTinChiTietPhong = new ThongTinChiTietPhong();
                thongTinChiTietPhong.RefreshDataBinding(PhongBUS.LayThongTinPhong(thuePhong.MaPhong), thuePhong);
                thongTinChiTietPhong.SetActionThanhToanButton(goToThanhToan);
                DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // thongTinChiTietPhong1
                // 
                thongTinChiTietPhong.Appearance.BackColor = System.Drawing.Color.White;
                thongTinChiTietPhong.Appearance.Options.UseBackColor = true;
                thongTinChiTietPhong.Dock = System.Windows.Forms.DockStyle.Fill;
                thongTinChiTietPhong.Location = new System.Drawing.Point(0, 0);
                thongTinChiTietPhong.Name = "thongTinChiTietPhong1";
                thongTinChiTietPhong.Size = new System.Drawing.Size(989, 591);
                thongTinChiTietPhong.TabIndex = 0;
                thongTinChiTietPhong.Load += new System.EventHandler(this.thongTinChiTietPhong1_Load);

                // 
                // tab1
                // 
                xtraTab.Controls.Add(thongTinChiTietPhong);
                xtraTab.Name = thongTinChiTietPhong.phong.MaPhong.ToString();
                xtraTab.Size = new System.Drawing.Size(989, 591);
                xtraTab.Text = thongTinChiTietPhong.phong.TenPhong;
                xtraTab.Tag = thongTinChiTietPhong.phong.MaPhong;
                // 
                this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTab });

            }

            foreach(XtraTabPage tab in this.TabControl.TabPages)
            {
                if((int)tab.Tag == thuePhongDTO.MaPhong)
                {
                    this.TabControl.SelectedTabPage = tab;
                    break;
                }
            }
        }

        public void RefreshDataBinding(PhongDTO phongDTO, Action goToThanhToan)
        {
            TabControl.TabPages.Clear();

            

       
                ThongTinChiTietPhong thongTinChiTietPhong = new ThongTinChiTietPhong();
                thongTinChiTietPhong.RefreshDataBinding(phongDTO);
                thongTinChiTietPhong.SetActionThanhToanButton(goToThanhToan);
                DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // thongTinChiTietPhong1
                // 
                thongTinChiTietPhong.Appearance.BackColor = System.Drawing.Color.White;
                thongTinChiTietPhong.Appearance.Options.UseBackColor = true;
                thongTinChiTietPhong.Dock = System.Windows.Forms.DockStyle.Fill;
                thongTinChiTietPhong.Location = new System.Drawing.Point(0, 0);
                thongTinChiTietPhong.Name = "thongTinChiTietPhong1";
                thongTinChiTietPhong.Size = new System.Drawing.Size(989, 591);
                thongTinChiTietPhong.TabIndex = 0;
                thongTinChiTietPhong.Load += new System.EventHandler(this.thongTinChiTietPhong1_Load);

                // 
                // tab1
                // 
                xtraTab.Controls.Add(thongTinChiTietPhong);
                xtraTab.Name = thongTinChiTietPhong.phong.MaPhong.ToString();
                xtraTab.Size = new System.Drawing.Size(989, 591);
                xtraTab.Text = thongTinChiTietPhong.phong.TenPhong;
                xtraTab.Tag = thongTinChiTietPhong.phong.MaPhong;
                // 
                this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTab });

      
        }
        public void UpdateTime()
        {
            ((ThongTinChiTietPhong)TabControl.SelectedTabPage.Controls[0]).UpdateTime();
        }

        private void TabControl_SelectedPageChanging(object sender, TabPageChangingEventArgs e)
        {
            ((ThongTinChiTietPhong)e.Page.Controls[0]).UpdateOnPageChange();
        }
        public void OnXoaPhong()
        {
            if (HoaDonBUS.DemSoLuongThuePhong(hoaDon.MaHoaDon) == 0)
            {
                goBackHome();
            }
            else
            {
                RefreshDataBinding(thuePhongDTO, goToThanhToan);
            }

        }
    }
}
