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
using DevExpress.Spreadsheet.Export;
using static DTO.LoaiPhongDTO;

namespace GUI.folderQuanLyPhong
{
    public partial class ThemLoaiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemLoaiPhong()
        {
            InitializeComponent();
                  
            //Init spreadsheet     
            spreadsheetControl1.WorksheetDisplayArea.SetSize(0, 8, 24);
            spreadsheetControl1.Document.Worksheets[0].DefaultColumnWidthInPixels=165;


           
        }

        internal void Initialize()
        {
            spreadsheetControl1.Document.Worksheets[0]["A1:H25"].Value = 1000;

            //Phát sinh mã loại phòng
            textEdit2.Text = BUS.LoaiPhongBUS.PhatSinhLoaiMaPhong().ToString();

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

        private void LuuLoaiPhong()
        {
            Range range = spreadsheetControl1.Document.Worksheets[0]["A1:H25"];
            DataTable dataTable = spreadsheetControl1.Document.Worksheets[0].CreateDataTable(range, true);

            DataTableExporter exporter =    spreadsheetControl1.Document.Worksheets[0].CreateDataTableExporter(range, dataTable, true);
            exporter.Export();
            return;
            
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                DonGiaTheoNgay donGiaNgay = new DonGiaTheoNgay();

                DonGiaTheoKhoangThoiGian donGia = new DonGiaTheoKhoangThoiGian();
                donGia.GioBatDau = 0;
                donGia.GioKetThuc = 1;
                donGia.DonGia = Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[0, i].Value.ToString());
                for (int j = 1; j < 24; j++)
                {
                    if(donGia.DonGia == Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[j, i].Value.ToString()))
                    {
                        donGia.GioKetThuc ++;
                    }
                    else
                    {
                        donGiaNgay.listDonGiaTheoKhoangThoiGian.Add(donGia);

                        donGia = new DonGiaTheoKhoangThoiGian();
                        donGia.GioBatDau = j;
                        donGia.GioKetThuc = j+1;
                        donGia.DonGia = Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[j, i].Value.ToString());
                    }
                    //spreadsheetControl1.Document.Worksheets[0].Cells[j, i].NumberFormat = "##.000";
                }

                donGiaNgay.listDonGiaTheoKhoangThoiGian.Add(donGia);
                return;
            }
        }
    }
}
