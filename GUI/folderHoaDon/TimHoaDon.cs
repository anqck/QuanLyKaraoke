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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace GUI.folderHoaDon
{
    public partial class TimHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dsHoaDon;
        DataTable dtHoaDon;
        DataTable dtChiTietHoaDon;

        FilterControlDialog filterDialog;
        String strFilterDialog;

        public TimHoaDon()
        {
            InitializeComponent();

            rangeControl1.RangeChanged += OnRangeChanged;

            
        }

        public void RefreshDataBinding()
        {
            dtHoaDon = HoaDonBUS.LayTatCaCacHoaDon_KhachHang();
            dtHoaDon.TableName = "hoadon";


            dtChiTietHoaDon = HoaDonBUS.LayTatCaDichVu_Phong_DichVuPhong();
            dtChiTietHoaDon.TableName = "chitiethoadon";

            dsHoaDon = new DataSet();
            dsHoaDon.Tables.Add(dtHoaDon);
            dsHoaDon.Tables.Add(dtChiTietHoaDon);


            dsHoaDon.Relations.Add("Thông tin chi tiết hóa đơn", dsHoaDon.Tables["hoadon"].Columns["MaHoaDon"], dsHoaDon.Tables["chitiethoadon"].Columns["MaHoaDon"]);

            GridControlHoaDon.DataSource = dsHoaDon.Tables["hoadon"];
            GridControlHoaDon.LevelTree.Nodes.Add("Thông tin chi tiết hóa đơn", gridViewChiTietHoaDon);


            // Generate a data table and bind the date-time client to it.
            dateTimeChartRangeControlClient1.DataProvider.DataSource = dtHoaDon;

            // Specify data members to bind the client.
            dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = "NgayThanhToan";
            dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = "TongTienThanhToan";

            //dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = "MaHoaDon";



            //// Specify the chart range control client view.       
            //AreaChartRangeControlClientView areaView = new AreaChartRangeControlClientView();
            //dateTimeChartRangeControlClient1.DataProvider.TemplateView = areaView;


            



            

                Dictionary < int, double > doanhThuThang = HoaDonBUS.GetTongDoanhThuTheoThang(DateTime.Now.Year);
            for (int i = 1; i <= 12; i++)
            {
                if(doanhThuThang.ContainsKey(i))
                {
                    chartControl.Series[1].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Tháng " +i, doanhThuThang[i]));
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

        private void gridViewHoaDon_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if(e.Column.FieldName == "colTinhTrangHoaDon")
            {
                if(e.IsGetData)
                {
                    if(dtHoaDon.Rows[e.ListSourceRowIndex]["TongTienThanhToan"].ToString() == "")
                    {
                        e.Value = "Chưa thanh toán";
                    }
                    else
                    {
                        e.Value = "Đã thanh toán";
                    }
                }
            }
        }

        private void gridViewChiTietHoaDon_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
            if(e.Column.FieldName == "colType")
            {
                if(e.IsGetData)
                {
                    if((int)((DataRowView)e.Row)["MaLDV"] == 3)
                    {
                        e.Value = "Khuyến mãi";
                    }
                    else
                    {
                        e.Value = "Dịch vụ";
                    }
                }
            }
            else if (e.Column.FieldName == "colThanhTien")
            {
                if (e.IsGetData)
                {
                    e.Value = (double)((DataRowView)e.Row)["SoLuong"] * (double)((DataRowView)e.Row)["Gia"];
                }
            }
        }

        private void wbntHoadon_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Bộ Lọc":
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = "BỘ LỌC", Description = "Close the application?" };
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Lọc", Result = System.Windows.Forms.DialogResult.Yes };
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Hủy", Result = System.Windows.Forms.DialogResult.No };
                    action.Commands.Add(command1);
                    action.Commands.Add(command2);
                    FlyoutProperties properties = new FlyoutProperties();
                    properties.ButtonSize = new Size(160, 50);
                    properties.Style = FlyoutStyle.MessageBox;

                    filterDialog = new FilterControlDialog(GridControlHoaDon, gridViewHoaDon.ActiveFilterString.ToString());

                    if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.FindForm(), filterDialog, action, properties) == DialogResult.Yes)
                    {
                        if (filterDialog.GetFilterString() == "")
                            return;

                        gridViewHoaDon.ActiveFilterString = strFilterDialog = filterDialog.GetFilterString();
                        

                    }
                    break;
            }
        }

        private void dateTimeChartRangeControlClient1_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }
        void OnRangeChanged(object sender, RangeControlRangeEventArgs range)
        {
            if ((DateTime)range.Range.Minimum == DateTime.MinValue)
                return;
            
            gridViewHoaDon.ActiveFilterString = "[NgayThanhToan] Between (#"+((DateTime)range.Range.Minimum).ToString("yyyy-MM-dd HH:mm:ss.fff") + "#, #" + ((DateTime)range.Range.Maximum).ToString("yyyy-MM-dd HH:mm:ss.fff") + "#)";
        }

        private void gridViewHoaDon_ColumnFilterChanged(object sender, EventArgs e)
        {
            if(gridViewHoaDon.ActiveFilterString == "")
            {
                rangeControl1.SelectAll();
                gridViewHoaDon.ActiveFilterString = "";
            }
        }

        private void gridViewHoaDon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (e.FocusedRowHandle == -1)
            //    return;

            //foreach (DevExpress.XtraCharts.Series series in chartControl.Series)
            //{
            //    series.Visible = false;
            //}
            //chartControl.Series["Doanh thu theo thuê phòng"].Visible = true;
            //chartControl.Animate();
        }
    }
}
