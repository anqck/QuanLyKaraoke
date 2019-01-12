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
    public partial class DoanhThuNam : DevExpress.XtraEditors.XtraUserControl
    {

        DataSet dsHoaDon;
        DataTable dtHoaDon;
        DataTable dtChiTietHoaDon;
        public DoanhThuNam()
        {
            InitializeComponent();
            //datepickerNam.DateTime = DateTime.Now;
            //RefreshDataBinding();
        }
        public void iInit()
        {
            datepickerNam.DateTime = DateTime.Now;
            RefreshDataBinding();
        }
        public void RefreshDataBinding()
        {
            dtHoaDon = HoaDonBUS.LayDoanhThuTheoNam(datepickerNam.DateTime.Year);
            dtHoaDon.TableName = "hoadon";


            dtChiTietHoaDon = HoaDonBUS.LayTatCaCacHoaDon_KhachHang_DaThanhToan_TheoNam(datepickerNam.DateTime);
            dtChiTietHoaDon.TableName = "chitiethoadon";

            dsHoaDon = new DataSet();
            dsHoaDon.Tables.Add(dtHoaDon);
            dsHoaDon.Tables.Add(dtChiTietHoaDon);


            dsHoaDon.Relations.Add("Thông tin chi tiết ", dsHoaDon.Tables["hoadon"].Columns["Thang"], dsHoaDon.Tables["chitiethoadon"].Columns["Month"]);

            GridControlHoaDon.DataSource = dsHoaDon.Tables["hoadon"];
            // GridControlHoaDon.LevelTree.Nodes.Add("Thông tin chi tiết hóa đơn", gridViewChiTietHoaDon);


            chartControl.Series[1].Points.Clear();
            Dictionary<int, double> doanhThuNam = HoaDonBUS.GetTongDoanhThuTheoThang(datepickerNam.DateTime);
            for (int i = 1; i <= 12; i++)
            {
                if (doanhThuNam.ContainsKey(i))
                {
                    chartControl.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Tháng " + i, doanhThuNam[i]));
                }
                else
                {
                    chartControl.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Tháng " + i, 0));
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

        private void datepickerNam_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshDataBinding();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GridControlHoaDon.ShowPrintPreview();
        }
    }
}
