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
    public partial class DoanhThuDichVuTheoNam : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dsHoaDon;
        DataTable dtHoaDon;
        DataTable dtChiTietDichVu;
        public DoanhThuDichVuTheoNam()
        {
            InitializeComponent();
        }
        public void iInit()
        {
            datepickerNam.DateTime = DateTime.Now;
            RefreshDataBinding();
        }
        public void RefreshDataBinding()
        {
            dtHoaDon = DichVuPhongBUS.LayThongKeTatCaCacDichVu_TrongThang(datepickerNam.DateTime);
            dtHoaDon.TableName = "hoadon";

            dtChiTietDichVu = DichVuPhongBUS.LayTatCaCacDichVu_TrongNam(datepickerNam.DateTime);
            dtChiTietDichVu.TableName = "chitiet";

              dsHoaDon = new DataSet();
            dsHoaDon.Tables.Add(dtHoaDon);
            dsHoaDon.Tables.Add(dtChiTietDichVu);

            dsHoaDon.Relations.Add("Thông tin chi tiết", dsHoaDon.Tables["hoadon"].Columns["Thang"], dsHoaDon.Tables["chitiet"].Columns["Thang"]);

            GridControlHoaDon.DataSource = dsHoaDon.Tables["hoadon"];
             GridControlHoaDon.LevelTree.Nodes.Add("Thông tin chi tiết", gridView1);


            chartControl.Series[1].Points.Clear();
            Dictionary<int, double> doanhThuNam = DichVuPhongBUS.GetTongDoanhThuTheoThang(datepickerNam.DateTime);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GridControlHoaDon.ShowPrintPreview();
        }

        private void datepickerNam_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshDataBinding();
        }
    }
}
