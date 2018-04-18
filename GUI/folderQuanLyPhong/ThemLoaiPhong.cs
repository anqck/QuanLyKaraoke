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
using DevExpress.XtraScheduler;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;

namespace GUI.folderQuanLyPhong
{
    public partial class ThemLoaiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemLoaiPhong()
        {
            InitializeComponent();
            Worksheet settingsSheet = spreadsheetControl1.Document.Worksheets[0];
            settingsSheet.Cells[30, 0].SetValue("THỨ 2");
            settingsSheet.Cells[30, 1].SetValue("THỨ 3");
            settingsSheet.Cells[30, 2].SetValue("THỨ 4");
            settingsSheet.Cells[30, 3].SetValue("THỨ 5");
            settingsSheet.Cells[30, 4].SetValue("THỨ 6");
            settingsSheet.Cells[30, 5].SetValue("THỨ 7");
            settingsSheet.Cells[30, 6].SetValue("CHỦ NHẬT");
            settingsSheet.Cells[30, 7].SetValue("NGÀY LỄ");
           
            spreadsheetControl1.WorksheetDisplayArea.SetSize(0, 8, 24);
            for (int i = 0; i < 24; i++)
            {
                settingsSheet.Cells[i, 9].SetValue(i+"h - "+(i+1)+"h");
            }
          
        }

        private void spreadsheetControl1_CustomDrawColumnHeader(object sender, DevExpress.XtraSpreadsheet.CustomDrawColumnHeaderEventArgs e)
        {
            e.Handled = true;
            Color foreColor = Color.Black;
            Rectangle textBounds = e.Bounds;
            Font headingFont = new Font(e.Font, FontStyle.Regular);
            Worksheet settingsSheet = spreadsheetControl1.Document.Worksheets[0];
            string text = settingsSheet.Cells[30, e.ColumnIndex].DisplayText;
            //string text = "cai gi do";
            if (text != String.Empty)
            {
                StringFormat formatHeaderText = new StringFormat();
                formatHeaderText.LineAlignment = StringAlignment.Center;
                formatHeaderText.Alignment = StringAlignment.Center;
                formatHeaderText.Trimming = StringTrimming.EllipsisCharacter;
                e.Graphics.DrawString(text, headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
            }
            
        }

        private void spreadsheetControl1_CustomDrawRowHeader(object sender, CustomDrawRowHeaderEventArgs e)
        {
            e.Handled = true;
            Color foreColor = Color.Black;
            Rectangle textBounds = e.Bounds;
            Font headingFont = new Font(e.Font, FontStyle.Regular);
            Worksheet settingsSheet = spreadsheetControl1.Document.Worksheets[0];
            string text = settingsSheet.Cells[e.RowIndex,9 ].DisplayText;
            //string text = "cai gi do";
            if (text != String.Empty)
            {
                StringFormat formatHeaderText = new StringFormat();
                formatHeaderText.LineAlignment = StringAlignment.Center;
                formatHeaderText.Alignment = StringAlignment.Center;
                formatHeaderText.Trimming = StringTrimming.EllipsisCharacter;
                e.Graphics.DrawString(text, headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
            }
        }
    }
}
