namespace GUI.folderBaoCao
{
    public partial class BaoCao : DevExpress.XtraEditors.XtraUserControl
    {
        public BaoCao()
        {
            InitializeComponent();

            Gotohomepage();

        }
        public void Init()
        {
            doanhThuNam1.iInit();
            doanhThuThang1.iInit();
            doanhThuDichVuTheoNam1.iInit();
        }
        private void wbntBaoCao_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {

            switch (e.Button.Properties.Tag.ToString())
            {
                case "Doanh thu tháng":
                    doanhThuThang1.RefreshDataBinding();
                    BaoCaoPageControl.SelectedPage = PageDoanhThuThang;
                    break;
                case "Doanh thu năm":
                    doanhThuNam1.RefreshDataBinding();
                    BaoCaoPageControl.SelectedPage = PageDoanhThuNam;
                    break;
                case "Doanh thu dịch vụ":
                    doanhThuDichVuTheoNam1.RefreshDataBinding();
                    BaoCaoPageControl.SelectedPage = PageDoanhthuDV;
                    break;

            }
        }

        private void BaoCaoPageControl_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {

            if (e.Page == PageDoanhThuNam)
            {
                wbntBaoCao.Buttons["Doanh thu tháng"].Properties.Enabled = false;
                wbntBaoCao.Buttons["Doanh thu ngày"].Properties.Enabled = true;
                wbntBaoCao.Buttons["Doanh thu dịch vụ"].Properties.Enabled = true;
                return;
            }
            if (e.Page == PageDoanhThuThang)
            {
                wbntBaoCao.Buttons["Doanh thu ngày"].Properties.Enabled = false;
                wbntBaoCao.Buttons["Doanh thu tháng"].Properties.Enabled = true;
                wbntBaoCao.Buttons["Doanh thu dịch vụ"].Properties.Enabled = true;
                return;
            }
            if (e.Page == PageDoanhthuDV)
            {
                wbntBaoCao.Buttons["Doanh thu ngày"].Properties.Enabled = true;
                wbntBaoCao.Buttons["Doanh thu tháng"].Properties.Enabled = true;
                wbntBaoCao.Buttons["Doanh thu dịch vụ"].Properties.Enabled = false;
                return;
            }
        }
        public void Gotohomepage()
        {
            BaoCaoPageControl.SelectedPage = PageDoanhThuThang;
            wbntBaoCao.Buttons["Doanh thu ngày"].Properties.Enabled = false;
            wbntBaoCao.Buttons["Doanh thu tháng"].Properties.Enabled = true;
            wbntBaoCao.Buttons["Doanh thu dịch vụ"].Properties.Enabled = true;
        }

    }
}
