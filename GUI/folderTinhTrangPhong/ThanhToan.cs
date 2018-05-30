using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThanhToan : DevExpress.XtraEditors.XtraUserControl
    {
        private PhongDTO phong;
        private KhachHangDTO khachHang;
        private HoaDonDTO hoaDon;
        private ThuePhongDTO thuePhong;

        DataTable tienGio ;
        DataTable dichVuPhong ;

        public ThanhToan()
        {
            InitializeComponent();

            //snapControl.DataSource = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
            //snapControl.LoadDocument("C:\\Users\\Public\\Documents\\DevExpress Demos 17.1\\Components\\WinForms\\DevExpress.HybridApp.Win\\CS\\DevExpress.HybridApp.Win\\Resources\\MailMerge\\1.snx", DevExpress.Snap.Core.API.SnapDocumentFormat.Snap);
            //snapControl.ReadOnly = true;

            //snapControl.Document.DataSource = ds;
        }
        public void RefreshDataBinding(PhongDTO phongDTO)
        {
            this.phong = phongDTO;
            this.thuePhong = BUS.ThuePhongBUS.LayThongTinPhongDangThue(phongDTO);
            this.hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhong.MaHoaDon);
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);
             dichVuPhong = BUS.DichVuPhongBUS.LayTatCaDichVuPhong_DichVu(thuePhong);

            RefreshDataBindingDichVuPhong();

            ThanhToanBUS.ThongTinThanhToan t = ThanhToanBUS.TinhTienThuePhong(phong, DateTime.Now);
            tienGio = new DataTable();
            tienGio.Columns.Add(new DataColumn("Ngay"));
            tienGio.Columns.Add(new DataColumn("KhoangThoiGian"));
            tienGio.Columns.Add(new DataColumn("DonGia"));
            tienGio.Columns.Add(new DataColumn("SoLuong"));
            tienGio.Columns.Add(new DataColumn("GioBD", typeof(double)));          

            foreach(DTO.ThongTinThanhToanTheoNgay ngay in t.listThongTin)
            {
              
                foreach(LoaiPhongDTO.DonGiaTheoKhoangThoiGian dongia in ngay.listDonGiaTheoKhoangThoiGian)
                {
                    DataRow dr = tienGio.NewRow();

                    dr["Ngay"] = ngay.ngay.Thu + " (" + ngay.ngay.date.ToString("dd-MM-yyyy") + ")" ;
                    dr["KhoangThoiGian"] = dongia.GioBatDau + " - " + dongia.GioKetThuc;
                    dr["GioBD"] = dongia.GioBatDau.hour * 3600 + dongia.GioBatDau.minute * 60 + dongia.GioBatDau.second; 
                    dr["DonGia"] = dongia.DonGia ;
                    dr["SoLuong"] = ThongTinThanhToanTheoNgay.Gio.CalcTimeSpan(dongia.GioBatDau, dongia.GioKetThuc).TotalHours;

                    tienGio.Rows.Add(dr);
                }                   
               
                //if(ngay.ngay.date.DayOfYear == )
            }
            textEdit9.Properties.DataSource = tienGio;


           

           textEdit9.Properties.DisplayMember = t.TongThanhTien.ToString("###,###,###,##0 VNĐ");
            textEdit9.Properties.ValueMember = t.TongThanhTien.ToString("###,###,###,##0 VNĐ");
            textEdit9.Properties.NullText = t.TongThanhTien .ToString("###,###,###,##0 VNĐ");
            //gridView1.group

            //doc.Document.DataSource = BUS.PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
        }

        void RefreshDataBindingDichVuPhong()
        {
            dichVuPhong = DichVuPhongBUS.LayTatCaDichVuPhong_DichVu(thuePhong);
            dichVuPhong.Columns.Add(new DataColumn("colType"));
            foreach (DataRow row in dichVuPhong.Rows)
            {
                row["colType"] = "Dịch Vụ";
            }

            gridControl1.DataSource = dichVuPhong;

            //if (gridView1.RowCount == 0)
            //    wbntQuanlyphong.Buttons[1].Properties.Visible = false;
            //else
            //    wbntQuanlyphong.Buttons[1].Properties.Visible = true;

            gridView1.ExpandAllGroups();
        }

        private void wbntQuanlyphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm Dịch Vụ":
                    folderDichVu.ChonDichVu chonDichVu = new folderDichVu.ChonDichVu();

                    XtraDialogArgs args = new XtraDialogArgs(caption: "Chọn dịch vụ", content: chonDichVu, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
                    args.Showing += Args_Showing;


                    if (XtraDialog.Show(args) == DialogResult.OK)
                    {
                        foreach (int dichVu_Key in chonDichVu.GetSelectedDichVu().Keys)
                        {
                            DichVuPhongBUS.LuuThongTinDichVuPhong(new DichVuPhongDTO(DichVuPhongBUS.PhatSinhMaDichVuPhong(), thuePhong.MaThuePhong, dichVu_Key, DateTime.Now, chonDichVu.GetSelectedDichVu()[dichVu_Key], DichVuBUS.LayThongTinDichVu(dichVu_Key).DonGia));
                            //DichVuBUS.LayThongTinDichVu(dichVu_Key);
                        }

                        RefreshDataBindingDichVuPhong();
                    }
                    break;

                case "Thanh toán":

                    break;
            }
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }



        private void gridView1_GroupRowCollapsing(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            e.Allow = false;
        }


        private void textEdit9_Properties_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit grid = (GridLookUpEdit)sender;
            grid.Properties.View.ExpandAllGroups();
        }

        private void gridLookUpEdit1View_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colThanhTien")
            {
                if (e.IsGetData)
                {
                    e.Value =( Double.Parse(tienGio.Rows[e.ListSourceRowIndex]["SoLuong"].ToString()) * Double.Parse(tienGio.Rows[e.ListSourceRowIndex]["DonGia"].ToString())) ;
                }
            }
           
        }

        private void textEdit9_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colSoLuong")
            {
                if (e.IsGetData)
                {
                    e.Value = dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"];
                }
                if (e.IsSetData)
                {
                    DichVuPhongBUS.UpdateDichVuPhong(new DichVuPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaThuePhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDV"], DateTime.Parse(dichVuPhong.Rows[e.ListSourceRowIndex]["ThoiGian"].ToString()), Convert.ToDouble(e.Value), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"]));
                    RefreshDataBindingDichVuPhong();
                }

            }
            else if (e.Column.FieldName == "colDonGia")
            {
                if (e.IsGetData)
                {
                    e.Value = Convert.ToInt32(dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"]);
                }
                if (e.IsSetData)
                {
                    DichVuPhongBUS.UpdateDichVuPhong(new DichVuPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaThuePhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDV"], DateTime.Parse(dichVuPhong.Rows[e.ListSourceRowIndex]["ThoiGian"].ToString()), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"], Convert.ToDouble(e.Value)));
                    RefreshDataBindingDichVuPhong();
                }

            }
            else if (e.Column.FieldName == "colThanhTien")
            {
                if (e.IsGetData)
                {
                    e.Value = Convert.ToInt32(dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"]) * (double)dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"];
                }


            }
        }

       
        
    }


}
