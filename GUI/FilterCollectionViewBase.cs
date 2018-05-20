using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering.Helpers;

namespace GUI
{
    public partial class FilterCollectionViewBase : UserControl
    {
        public FilterCollectionViewBase()
        {
            InitializeComponent();

            
        }

        public FilterCollectionViewBase(GridControl source) : this()
        {
            InitializeComponent();

            filterControl1.SourceControl = source;
            filterEditorControl1.SourceControl = DAL.DichVuDAL.LayTatCaDichVu_DataTable();

          filterControl2.SourceControl = null;
            filterControl2.FilterColumns.Add(new UnboundFilterColumn("Name", "Field1", typeof(string), new RepositoryItemTextEdit(), FilterColumnClauseClass.String));

            filterControl2.FilterColumns.Add(new UnboundFilterColumn("Age", "Field2", typeof(int), new RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic));
            filterControl1.ApplyFilter();



        }

        DataTable GetData(int rows)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("LOANMASTER|FIELD", typeof(string));
            for (int i = 0; i < rows; i++)
            {
                dt.Rows.Add(i, "Info" + i);
            }
            return dt;
        }

        private void filterControl1_PopupMenuShowing(object sender, DevExpress.XtraEditors.Filtering.PopupMenuShowingEventArgs e)
        {
            //for (int i = e.Menu.Items.Count - 1; i >= 0; i--)
            //{
            //    DXMenuItem item = e.Menu.Items[i];
            //    if (!(item is DXSubMenuItem))
            //    {
            //        Type type = ((FilterColumn)item.Tag).ColumnType;
            //        OperandProperty firstOperand = ((ClauseNode)e.CurrentNode).FirstOperand;
            //        if (((FilterControl)sender).FilterColumns[firstOperand].ColumnType != type)
            //        {
            //            e.Menu.Items.RemoveAt(i); //remove the item instead of changing the visible property
            //        }
            //    }
            //}
        }
    }
}
