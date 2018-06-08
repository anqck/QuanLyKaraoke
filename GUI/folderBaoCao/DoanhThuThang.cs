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
using BUS;

namespace GUI.folderBaoCao
{
    public partial class DoanhThuThang : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dsHoaDon;
        DataTable dtHoaDon;
        DataTable dtChiTietHoaDon;
        public DoanhThuThang()
        {

            InitializeComponent();
           // datepickerThang.Text = DateTime.Now.ToString("MM-yyyy");
          //  RefreshDataBinding();
        }
        public void iInit()
        {
            datepickerThang.Text = DateTime.Now.ToString("MM-yyyy");
            RefreshDataBinding();
        }
        public void RefreshDataBinding()
        {
            dtHoaDon = HoaDonBUS.LayTatCaCacHoaDon_KhachHang_DaThanhToan(datepickerThang.DateTime);
            dtHoaDon.TableName = "hoadon";


           // dtChiTietHoaDon = HoaDonBUS.LayTatCaDichVu_Phong_DichVuPhong_DaThanhToan(datepickerThang.DateTime);
            //dtChiTietHoaDon.TableName = "chitiethoadon";

            dsHoaDon = new DataSet();
            dsHoaDon.Tables.Add(dtHoaDon);
            //dsHoaDon.Tables.Add(dtChiTietHoaDon);


           // dsHoaDon.Relations.Add("Thông tin chi tiết hóa đơn", dsHoaDon.Tables["hoadon"].Columns["MaHoaDon"], dsHoaDon.Tables["chitiethoadon"].Columns["MaHoaDon"]);

            GridControlHoaDon.DataSource = dsHoaDon.Tables["hoadon"];
             GridControlHoaDon.LevelTree.Nodes.Add("Thông tin chi tiết hóa đơn", gridViewChiTietHoaDon);

            chartControl.Series[1].Points.Clear();
            Dictionary<int, double> doanhThuThang = HoaDonBUS.GetTongDoanhThuTheoNgay(datepickerThang.DateTime);
            for (int i =1; i<= DateTime.DaysInMonth(datepickerThang.DateTime.Year, datepickerThang.DateTime.Month);i++)
            {
                if (doanhThuThang.ContainsKey(i))
                {
                    chartControl.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ngày " + i, doanhThuThang[i]));
                }
                else
                {
                    chartControl.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ngày " + i, 0));
                }
            }




            //rangeControl1.SelectAll();
            gridViewHoaDon.ActiveFilterString = "";

            gridViewHoaDon.ExpandAllGroups();
            gridViewHoaDon.FocusedRowHandle = -1;

            //foreach (DevExpress.XtraCharts.Series series in chartControl.Series)
            //{
            //    series.Visible = false;
            //}
            //chartControl.Series["Doanh thu theo tháng"].Visible = true;
            chartControl.Animate();
        }

        private void datepickerThang_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshDataBinding();
        }

        private void bntIn_Click(object sender, EventArgs e)
        {
            this.gridViewHoaDon.ShowPrintPreview();
        }
    }
}
