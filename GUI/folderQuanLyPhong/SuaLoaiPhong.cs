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
using DTO;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;
using BUS;
using static DTO.LoaiPhongDTO;

namespace GUI.folderQuanLyPhong
{
    public partial class SuaLoaiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiPhongDTO loaiPhong;

        public SuaLoaiPhong()
        {
            InitializeComponent();

            //Init spreadsheet     
            spreadsheetControl1.WorksheetDisplayArea.SetSize(0, 8, 24);
            spreadsheetControl1.Document.Worksheets[0].DefaultColumnWidthInPixels = 165;

            spreadsheetControl1.Document.Worksheets[0]["A1:H25"].NumberFormat = "###,###,##0";
        }

        public void RefreshDataBinding(LoaiPhongDTO loaiPhongDTO)
        {
            loaiPhong = loaiPhongDTO;

            

            Dictionary<string, LoaiPhongDTO.DonGiaTheoNgay> donGia = DonGia_LoaiPhongBUS.LayDonGia(loaiPhongDTO);
            for(int i = 0; i < donGia.Keys.Count; i++)
            {
                foreach(LoaiPhongDTO.DonGiaTheoKhoangThoiGian donGiaNgay in donGia.Values.ToList()[i].listDonGiaTheoKhoangThoiGian)
                {
                    for(int k = donGiaNgay.GioBatDau.hour; k < donGiaNgay.GioKetThuc.hour; k++ )
                    {
                        spreadsheetControl1.Document.Worksheets[0].Cells[k, i].Value = donGiaNgay.DonGia;
                    }
                }               
            }

            txtTenLoaiPhong.Text = loaiPhongDTO.TenLoaiPhong;
            txtMaLoaiPhong.Text = loaiPhongDTO.MaLoaiPhong.ToString();

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
                        e.Graphics.DrawString("Chủ nhật", headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
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
            string text = settingsSheet.Cells[e.RowIndex, 9].DisplayText;
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

        private void textEdit1_Properties_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenLoaiPhong.Text == "")
            {
                txtTenLoaiPhong.ErrorText = "Tên loại phòng không được để trống";
            }
            else
            {
                txtTenLoaiPhong.ErrorText = "";
            }
        }

        private void txtTenLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Lưu":
                    if (txtTenLoaiPhong.Text == "")
                    {
                        txtTenLoaiPhong.ErrorText = "Tên loại phòng không được để trống";
                        return;
                    }

                    DonGia_LoaiPhongBUS.XoaCacDonGiaPhong(loaiPhong);

                    DonGiaTheoTuan giaTheoTuan = new DonGiaTheoTuan();
                    giaTheoTuan.MaLoaiPhong = Convert.ToInt32(loaiPhong.MaLoaiPhong);

                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 24; j++)
                        {
                            if (spreadsheetControl1.Document.Worksheets[0].Cells[j, i].Value.ToString() == "")
                            {
                                //Thông báo có cell trống
                                //BÌNH

                                return;
                            }
                        }
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        DonGiaTheoNgay donGiaNgay = new DonGiaTheoNgay();
                        donGiaNgay.SetNgayTrongTuan(i);

                        DonGiaTheoKhoangThoiGian donGia = new DonGiaTheoKhoangThoiGian(new DTO.ThongTinThanhToanTheoNgay.Gio(0, 0, 0), new DTO.ThongTinThanhToanTheoNgay.Gio(1, 0, 0), Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[0, i].Value.ToString()));

                        for (int j = 1; j < 24; j++)
                        {
                            if (donGia.DonGia == Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[j, i].Value.ToString()))
                            {
                                donGia.GioKetThuc.AddHour(1);
                            }
                            else
                            {
                                donGiaNgay.listDonGiaTheoKhoangThoiGian.Add(donGia);

                                donGia = new DonGiaTheoKhoangThoiGian(new DTO.ThongTinThanhToanTheoNgay.Gio(j, 0, 0), new DTO.ThongTinThanhToanTheoNgay.Gio(j + 1, 0, 0), Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[0, i].Value.ToString()));


                                donGia.DonGia = Convert.ToInt32(spreadsheetControl1.Document.Worksheets[0].Cells[j, i].Value.ToString());
                            }
                            //spreadsheetControl1.Document.Worksheets[0].Cells[j, i].NumberFormat = "##.000";
                        }

                        donGiaNgay.listDonGiaTheoKhoangThoiGian.Add(donGia);

                        giaTheoTuan.listDonGiaTheoNgay.Add(donGiaNgay);

                    }
                    BUS.DonGia_LoaiPhongBUS.ThemDonGiaTheoKhoangThoiGian(giaTheoTuan);

                    //Thông báo thành công
                    //BÌNH
                    break;
                case "Hủy":
                    break;

            }

        }
    }
}
