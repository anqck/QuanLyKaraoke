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
using DevExpress.XtraGrid;

namespace GUI
{
    public partial class FilterControlDialog : DevExpress.XtraEditors.XtraUserControl
    {
        public FilterControlDialog()
        {
            InitializeComponent();

        
        }

        public FilterControlDialog(GridControl source)
        {
            InitializeComponent();

            filterEditorControl1.SourceControl = source;
        }
    }
}
