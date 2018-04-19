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
                       
            spreadsheetControl1.WorksheetDisplayArea.SetSize(0, 8, 24);
            spreadsheetControl1.Document.Worksheets[0].DefaultColumnWidthInPixels=165;
            for (int i = 0; i < 8; i++)
            {
                
                for (int j = 0; j < 24; j++)
                {
                    spreadsheetControl1.Document.Worksheets[0].Cells[j, i].Value = 0000;
                    spreadsheetControl1.Document.Worksheets[0].Cells[j, i].NumberFormat = "##.000";
                }
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
            //if (text != String.Empty)
            {
                StringFormat formatHeaderText = new StringFormat();
                formatHeaderText.LineAlignment = StringAlignment.Center;
                formatHeaderText.Alignment = StringAlignment.Center;
                formatHeaderText.Trimming = StringTrimming.EllipsisCharacter;
                              
                switch (e.ColumnIndex)
                {
                    case 6:
                        e.Graphics.DrawString("Chủ nhật" , headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
                        break;
                    case 7:
                        e.Graphics.DrawString("Ngày lễ", headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
                        break;
                    default:
                        e.Graphics.DrawString("Thứ " + (e.ColumnIndex + 2).ToString(), headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
                        break;
                }

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
            //if (text != String.Empty)
            {
                StringFormat formatHeaderText = new StringFormat();
                formatHeaderText.LineAlignment = StringAlignment.Center;
                formatHeaderText.Alignment = StringAlignment.Center;
                formatHeaderText.Trimming = StringTrimming.EllipsisCharacter;
                e.Graphics.DrawString((e.RowIndex + "h - " + (e.RowIndex + 1) + "h").ToString(), headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
            }
        }
    }
}
