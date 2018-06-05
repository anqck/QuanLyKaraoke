using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.folderTinhTrangPhong;

namespace GUI
{
    public partial class ReportViewer : XtraUserControl
    {
        private reportHoaDon reportHoaDon;

        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(reportHoaDon reportHoaDon):this()
        {
            this.reportHoaDon = reportHoaDon;
            //reportHoaDon.CreateDocument();
            documentViewer1.DocumentSource = reportHoaDon;
            documentViewer1.Zoom = 0.83f;
        }
    }
}
