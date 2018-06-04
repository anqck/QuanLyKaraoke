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
using DevExpress.XtraEditors.ButtonPanel;
using DTO;
using BUS;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Docking2010;

namespace GUI.folderTinhTrangPhong
{
    public partial class ChiTietThanhToanPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public ThuePhongDTO thuePhong { get; set; }

        DataTable tienGio;
        DataTable dichVuPhong;

        LoaiKhachHangDTO loaiKhachHang;

        Dictionary<int, DichVuPhongDTO> listKhuyenMai;

        double TongTien ;

        public Action CalcTongTienAction { get; set; }
        public WindowsUIButton ButtonXoaDichVu { get; set; }
        public ChiTietThanhToanPhong()
        {
            InitializeComponent();

            
            
        }

       
        public void RefreshDataBinding(ThuePhongDTO thuePhongDTO, KhachHangDTO khachHangDTO)
        {
            this.thuePhong = thuePhongDTO;

            txtGioVao.Time = thuePhong.GioThuePhong;
            txtGioRa.Time = (thuePhong.GioTraPhong == DateTime.MinValue) ?DateTime.Now : thuePhong.GioTraPhong;

            thuePhong.GioTraPhong = txtGioRa.Time;

            listKhuyenMai = new Dictionary<int, DichVuPhongDTO>();

            RefreshDataBindingTienGio();
      

             loaiKhachHang = LoaiKhachHangBUS.LayLoaiKhachHang(khachHangDTO);

            DichVuPhongDTO dichVuPhongDTO;
            //Kiểm tra các ngày đặt biệt
            foreach (DTO.ThongTinThanhToanTheoNgay ngay in ThanhToanBUS.TinhTienThuePhong(thuePhong, DateTime.Now).listThongTin)
            {
                
                //Sinh nhật
                if (ngay.ngay.date.Day == khachHangDTO.NgaySinh.Day && ngay.ngay.date.Month == khachHangDTO.NgaySinh.Month && khachHangDTO.MaKH != 0)
                {
                    
                    if (TongTien * loaiKhachHang.PhanTramGiamGiaSinhNhat > loaiKhachHang.SoTienGiamGiaSinhNhat_Max)
                        dichVuPhongDTO = new DichVuPhongDTO(-1, thuePhong.MaThuePhong, 1, DateTime.Now, 1.0, loaiKhachHang.SoTienGiamGiaSinhNhat_Max);
                    else if ((TongTien * loaiKhachHang.PhanTramGiamGiaSinhNhat < loaiKhachHang.SoTienGiamGiaSinhNhat_Min))
                        dichVuPhongDTO = new DichVuPhongDTO(-1, thuePhong.MaThuePhong, 1, DateTime.Now, 1.0, loaiKhachHang.SoTienGiamGiaSinhNhat_Min);
                    else
                        dichVuPhongDTO = new DichVuPhongDTO(-1, thuePhong.MaThuePhong, 1, DateTime.Now, 1.0, TongTien * loaiKhachHang.PhanTramGiamGiaSinhNhat);

                    if (dichVuPhongDTO.DonGia != 0)
                        listKhuyenMai.Add(dichVuPhongDTO.MaDVP, dichVuPhongDTO);
                }

             
            }

            //KM Loại KH
            if (TongTien * loaiKhachHang.PhanTramGiamGia > loaiKhachHang.SoTienGiamGia_Max)
                dichVuPhongDTO = new DichVuPhongDTO(-(listKhuyenMai.Count+1), thuePhong.MaThuePhong, 2, DateTime.Now, 1.0, loaiKhachHang.SoTienGiamGia_Max);
            else if ((TongTien * loaiKhachHang.PhanTramGiamGia < loaiKhachHang.SoTienGiamGia_Min))
                dichVuPhongDTO = new DichVuPhongDTO(-(listKhuyenMai.Count + 1), thuePhong.MaThuePhong, 2, DateTime.Now, 1.0, loaiKhachHang.SoTienGiamGia_Min);
            else
                dichVuPhongDTO = new DichVuPhongDTO(-(listKhuyenMai.Count + 1), thuePhong.MaThuePhong, 2, DateTime.Now, 1.0, TongTien * loaiKhachHang.PhanTramGiamGia);

            if(dichVuPhongDTO.DonGia != 0 && khachHangDTO.MaKH != 0)
                listKhuyenMai.Add(dichVuPhongDTO.MaDVP, dichVuPhongDTO);

            RefreshDataBindingDichVuPhong();




        }
        public void RefreshDataBinding_ReadOnly(ThuePhongDTO thuePhong)
        {
            this.thuePhong = thuePhong;

            txtGioVao.Time = thuePhong.GioThuePhong;
            txtGioRa.Time = (thuePhong.GioTraPhong == DateTime.MinValue) ? DateTime.Now : thuePhong.GioTraPhong;
            //txtTienGio.EditValue = (double)thuePhong

            dichVuPhong = DichVuPhongBUS.LayTatCaDichVuPhong_DichVu(thuePhong);
            dichVuPhong.Columns.Add(new DataColumn("colType"));
            foreach (DataRow row in dichVuPhong.Rows)
            {
                if((int)row["MaLDV"] == 3 )
                    row["colType"] = "Khuyến mãi";
                else
                    row["colType"] = "Dịch vụ";
            }

            gridControl1.DataSource = dichVuPhong;
        }
        void RefreshDataBindingTienGio()
        {
            tienGio = new DataTable();
            tienGio.Columns.Add(new DataColumn("Ngay"));
            tienGio.Columns.Add(new DataColumn("KhoangThoiGian"));
            tienGio.Columns.Add(new DataColumn("DonGia"));
            tienGio.Columns.Add(new DataColumn("SoLuong"));
            tienGio.Columns.Add(new DataColumn("GioBD", typeof(double)));
            tienGio.Columns.Add(new DataColumn("Phong"));

            TongTien = 0;
            foreach (DTO.ThongTinThanhToanTheoNgay ngay in ThanhToanBUS.TinhTienThuePhong(thuePhong, txtGioRa.Time).listThongTin)
            {
                TongTien += ngay.TongThanhTien;
                foreach (LoaiPhongDTO.DonGiaTheoKhoangThoiGian dongia in ngay.listDonGiaTheoKhoangThoiGian)
                {
                    DataRow dr = tienGio.NewRow();

                    dr["Ngay"] = ngay.ngay.Thu + " (" + ngay.ngay.date.ToString("dd-MM-yyyy") + ")";
                    dr["KhoangThoiGian"] = dongia.GioBatDau + " - " + dongia.GioKetThuc;
                    dr["GioBD"] = dongia.GioBatDau.hour * 3600 + dongia.GioBatDau.minute * 60 + dongia.GioBatDau.second;
                    dr["DonGia"] = dongia.DonGia;
                    dr["SoLuong"] = ThongTinThanhToanTheoNgay.Gio.CalcTimeSpan(dongia.GioBatDau, dongia.GioKetThuc).TotalHours;
                    dr["Phong"] = PhongBUS.LayThongTinPhong(thuePhong.MaPhong).TenPhong;
                    tienGio.Rows.Add(dr);
                }


            }

            txtTienGio.Properties.DataSource = tienGio;
            txtTienGio.Properties.NullText = TongTien.ToString("###,###,###,##0 VNĐ");
        }

        internal void AddButtonXoaDichVu(WindowsUIButton windowsUIButton)
        {
            ButtonXoaDichVu = windowsUIButton;
          
        }

        void RefreshDataBindingDichVuPhong()
        {
            dichVuPhong = DichVuPhongBUS.LayTatCaDichVuPhong_DichVu(thuePhong);
            dichVuPhong.Columns.Add(new DataColumn("colType"));
            foreach (DataRow row in dichVuPhong.Rows)
            {
                row["colType"] = "Dịch vụ";
            }

            foreach (DichVuPhongDTO khuyenMai in listKhuyenMai.Values)
            {
                DataRow dr = dichVuPhong.NewRow();

                dr["MaDVP"] = khuyenMai.MaDVP;
                dr["MaThuePhong"] = khuyenMai.MaThuePhong;
                dr["MaDV"] = khuyenMai.MaDV;
                dr["ThoiGian"] = khuyenMai.ThoiGian;
                dr["SoLuong"] = khuyenMai.SoLuong;
                dr["Gia"] = khuyenMai.DonGia;

                DichVuDTO thongTinDichVu = DichVuBUS.LayThongTinDichVu(khuyenMai.MaDV);
                dr["TenDV"] = thongTinDichVu.TenDV;
                dr["DonVi"] = thongTinDichVu.DonVi;
                dr["MaLDV"] = thongTinDichVu.MaLoaiDV;
                dr["TenLDV"] = "Khuyến mãi";
                dr["colType"] = "Khuyến mãi";

                dichVuPhong.Rows.Add(dr);
            }

            gridControl1.DataSource = dichVuPhong;


           
            gridView1.ExpandAllGroups();
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
                    if (dichVuPhong.Rows[e.ListSourceRowIndex]["colType"].ToString() == "Dịch vụ")
                    {
                        DichVuPhongBUS.UpdateDichVuPhong(new DichVuPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaThuePhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDV"], DateTime.Parse(dichVuPhong.Rows[e.ListSourceRowIndex]["ThoiGian"].ToString()), Convert.ToDouble(e.Value), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"]));
                        RefreshDataBindingDichVuPhong();
                        
                    }
                    else if (dichVuPhong.Rows[e.ListSourceRowIndex]["colType"].ToString() == "Khuyến mãi")
                    {
                        dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"] = e.Value;
                        listKhuyenMai[(int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"]].SoLuong = Convert.ToDouble(e.Value);
                    }
                    CalcTongTienAction();
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
                    if (dichVuPhong.Rows[e.ListSourceRowIndex]["colType"].ToString() == "Dịch vụ")
                    {
                        DichVuPhongBUS.UpdateDichVuPhong(new DichVuPhongDTO((int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaThuePhong"], (int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDV"], DateTime.Parse(dichVuPhong.Rows[e.ListSourceRowIndex]["ThoiGian"].ToString()), (double)dichVuPhong.Rows[e.ListSourceRowIndex]["SoLuong"], Convert.ToDouble(e.Value)));
                        RefreshDataBindingDichVuPhong();
                    }
                    else if (dichVuPhong.Rows[e.ListSourceRowIndex]["colType"].ToString() == "Khuyến mãi")
                    {
                        dichVuPhong.Rows[e.ListSourceRowIndex]["Gia"] = e.Value;
                        listKhuyenMai[(int)dichVuPhong.Rows[e.ListSourceRowIndex]["MaDVP"]].DonGia = Convert.ToDouble(e.Value);
                    }
                    CalcTongTienAction();
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

        private void gridLookUpEdit1View_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colThanhTien")
            {
                if (e.IsGetData)
                {
                    e.Value = (Double.Parse(tienGio.Rows[e.ListSourceRowIndex]["SoLuong"].ToString()) * Double.Parse(tienGio.Rows[e.ListSourceRowIndex]["DonGia"].ToString()));
                }
            }

        }

        private void txtTienGio_Properties_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit grid = (GridLookUpEdit)sender;
            grid.Properties.View.ExpandAllGroups();

            
        }

        internal void CapNhatThongTinThuePhong()
        {
            ThuePhongBUS.CapNhatThongTinThuePhong(new ThuePhongDTO(thuePhong.MaThuePhong, thuePhong.MaPhong, txtGioVao.Time, txtGioRa.Time, thuePhong.MaHoaDon, TongTien));
        }

        private void txtTienGio_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            e.Cancel = true;
        }

        private void gridView1_GroupRowCollapsing(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (e.RowHandle != -1)
                e.Allow = false;
        }

        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            if(e.IsTotalSummary)
            {

            }
        }

        private void ChiTietThanhToanPhong_Load(object sender, EventArgs e)
        {
            
            
        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            GridSummaryItem summary = e.Info.SummaryItem;
            // Obtain the total summary's value. 
            txtTongTienPhong.EditValue = TongTien + Convert.ToDouble(summary.SummaryValue);



        }

       
        public double GetTongTienKhuyenMai()
        {
            double res = 0;
            foreach(DataRow row in dichVuPhong.Rows)
            {
                if(row["colType"].ToString() == "Khuyến mãi")
                {
                    res += (double)row["Gia"] * (double)row["SoLuong"];
                }
            }
            return res;
        }

        public double GetTongTienDichVu()
        {
            double res = 0;
            foreach (DataRow row in dichVuPhong.Rows)
            {
                if (row["colType"].ToString() == "Dịch vụ")
                {
                    res += (double)row["Gia"] * (double)row["SoLuong"];
                }
            }
            return res;
        }

        public double GetTongTienGio()
        {
            return TongTien;
        }
        public void ThemDichVu()
        {
            folderDichVu.ChonDichVu chonDichVu = new folderDichVu.ChonDichVu(true);

            XtraDialogArgs args = new XtraDialogArgs(caption: "Chọn dịch vụ", content: chonDichVu, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
            args.Showing += Args_Showing;


            if (XtraDialog.Show(args) == DialogResult.OK)
            {
                foreach (int dichVu_Key in chonDichVu.GetSelectedDichVu().Keys)
                {
                    if (DichVuBUS.LayThongTinDichVu(dichVu_Key).MaLoaiDV == 3)
                    {
                        listKhuyenMai.Add(-(listKhuyenMai.Count + 1), new DichVuPhongDTO(-(listKhuyenMai.Count + 1), thuePhong.MaThuePhong, dichVu_Key, DateTime.Now, chonDichVu.GetSelectedDichVu()[dichVu_Key], DichVuBUS.LayThongTinDichVu(dichVu_Key).DonGia));
                    }
                    else
                    {
                        DichVuPhongBUS.LuuThongTinDichVuPhong(new DichVuPhongDTO(DichVuPhongBUS.PhatSinhMaDichVuPhong(), thuePhong.MaThuePhong, dichVu_Key, DateTime.Now, chonDichVu.GetSelectedDichVu()[dichVu_Key], DichVuBUS.LayThongTinDichVu(dichVu_Key).DonGia));

                    }
                    //DichVuBUS.LayThongTinDichVu(dichVu_Key);
                }

                RefreshDataBindingDichVuPhong();
                CalcTongTienAction();
            }
        }
        public void XoaDichVu()
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa dịch vụ/khuyến mãi " + dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["TenDV"] + "' ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            if (dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["colType"].ToString() == "Khuyến mãi")
                listKhuyenMai.Remove((int)dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaDVP"]);
            else
                DichVuPhongBUS.XoaDichVuPhong((int)dichVuPhong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaDVP"]);


            RefreshDataBindingDichVuPhong();
            CalcTongTienAction();
        }
     

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount == 0 ) 
                ButtonXoaDichVu.Visible = false;
            else
                ButtonXoaDichVu.Visible = true;
        }
        public void LuuKhuyenMai()
        {
            foreach(DichVuPhongDTO dichVuPhong in listKhuyenMai.Values)
            {
                DichVuPhongBUS.LuuThongTinDichVuPhong(new DichVuPhongDTO(DichVuPhongBUS.PhatSinhMaDichVuPhong(), thuePhong.MaThuePhong, dichVuPhong.MaDV, dichVuPhong.ThoiGian, dichVuPhong.SoLuong, dichVuPhong.DonGia));

            }

        }
        public DataTable GetDichVuPhong_DataTable()
        {
            return dichVuPhong;
        }

    }
}
