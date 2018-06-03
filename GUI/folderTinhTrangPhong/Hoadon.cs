using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.Configuration;

namespace GUI.folderTinhTrangPhong
{
    public partial class reportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public reportHoaDon()
        {
            InitializeComponent();
        }

        public void BindingData(DataSet dsHoaDon)
        {
            DataSource = dsHoaDon.Tables[0];
            //DataMember =

            //detailTenDV.DataBindings.Add("Text", Nothing, dsHoaDon.Columns("clmSTT").Caption)

                // Specify labels' bindings depending on the report's data binding mode.
            if (Settings.Default.UserDesignerOptions.DataBindingMode == DataBindingMode.Bindings)
            {
                detailTenDV.DataBindings.Add("Text", null, "customQuery.CategoryName");
                //labelDetail.DataBindings.Add("Text", null, "customQuery.ProductName");
            }
            else
            {
                detailTenDV.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[CategoryName]"));
                
            }
        }

    }
}
