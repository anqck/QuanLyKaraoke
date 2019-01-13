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
using DevExpress.XtraBars.Docking2010.Customization;
using BUS;
using DTO;

namespace GUI.folderTinhTrangPhong
{
    public partial class DatPhong : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable dataSource_KhachHang;
        private DataTable dtPhong;
        Dictionary<int, PhongDTO> selectedPhong;

        private KhachHangDTO khachHang;


        private Action<DatPhongDTO> onDatPhongSuccess;

        public DatPhong(Action<DatPhongDTO> onDatPhongSuccess)
        {
            InitializeComponent();

            this.onDatPhongSuccess = onDatPhongSuccess;

            selectedPhong = new Dictionary<int, PhongDTO>();
            khachHang = null;

            RefreshDataBinding();

       
        }

        public void RefreshDataBinding()
        {
            txtGioVao.EditValue = DateTime.Now;
            txtGioVao.Time = DateTime.Now;

             txtKhachHang.Properties.DisplayMember = "TenKH";
            txtKhachHang.Properties.ValueMember = "MaKH";

            dataSource_KhachHang = KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
            dataSource_KhachHang.Rows.RemoveAt(0);

            txtKhachHang.Properties.DataSource = dataSource_KhachHang;
            khachHang = KhachHangBUS.LayTatCaKhachHang()[0];
            txtKhachHang.EditValue = 1;


        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Đặt":
                   
                    DatPhongDTO datPhong = new DatPhongDTO(DatPhongBUS.PhatSinhMaDatPhong(), txtGioVao.Time, Convert.ToDouble(txtTienTraTruoc.EditValue), (this.ParentForm.Owner as MainForm).nhanVien.MaNhanVien, khachHang.MaKH, txtGhiChu.EditValue.ToString(), 1);
                    DatPhongBUS.LuuThongTinDatPhong(datPhong);

                    foreach(PhongDTO phong in selectedPhong.Values)
                    {
                        ChiTietDatPhongBUS.LuuThongTinDatPhong(new ChiTietDatPhongDTO(ChiTietDatPhongBUS.PhatSinhMaChiTietDatPhong(),phong.MaPhong, datPhong.MaDatPhong));
                    }
                    

                    XtraMessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    onDatPhongSuccess(datPhong);

                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                case "Hủy":
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                default:
                    break;
            }
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int idxSelected = gridLookUpEdit1View.GetFocusedDataSourceRowIndex();
            if(idxSelected >=0)
            khachHang = new KhachHangDTO((int)dataSource_KhachHang.Rows[idxSelected]["MaKH"], dataSource_KhachHang.Rows[idxSelected]["TenKH"].ToString(), dataSource_KhachHang.Rows[idxSelected]["CMND"].ToString(), dataSource_KhachHang.Rows[idxSelected]["SDT"].ToString(), dataSource_KhachHang.Rows[idxSelected]["DiaChi"].ToString(), (int)dataSource_KhachHang.Rows[idxSelected]["MaLoaiKH"], (double)dataSource_KhachHang.Rows[idxSelected]["DiemTichLuy"], (dataSource_KhachHang.Rows[0]["NgaySinh"].ToString() == "") ? (DateTime.MinValue) : ((DateTime)dataSource_KhachHang.Rows[0]["NgaySinh"]));


        }

        private void txtPhong_Properties_Popup(object sender, EventArgs e)
        {

        }
        private void txtPhong_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            (sender as GridLookUpEdit).LookAndFeel.UpdateStyleSettings();

        }

        private void txtPhong_Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (dtPhong.Rows.Count == 0)
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                txtPhong.ErrorText = "Không có phòng trống";
                return;

            }
                var editor = sender as GridLookUpEdit;
            var view = editor.Properties.View;
            var selectedRowsCount = view.GetSelectedRows().Count();



            e.DisplayText = "";

            if (selectedPhong.Count == 0)
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                txtPhong.ErrorText = "Không có phòng nào được chọn";
                return;
            }
            else
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
                txtPhong.ErrorText = "";
            }



            for (int i = 0; i < selectedPhong.Values.Count; i++)
            {

                e.DisplayText += selectedPhong.Values.ToList()[i].TenPhong;
                if (i != selectedPhong.Values.Count - 1)
                    e.DisplayText += "; ";
            }
        }

        private void txtGioVao_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtPhong.Properties.DataSource = dtPhong =  DatPhongBUS.LayCacPhongConTrongTrongThoiGian(txtGioVao.Time, ThamSoBUS.LayKhoangThoiGianToiThieuGiuaHaiLanThue());
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
                
                selectedPhong.Remove((int)gridView1.GetRowCellValue(e.ControllerRow, gridColumn1));
            else if (e.Action == CollectionChangeAction.Add)
            {
                if (e.ControllerRow < 0)
                    return;
                if (!selectedPhong.Keys.Contains((int)gridView1.GetRowCellValue(e.ControllerRow, gridColumn1)))
                    selectedPhong.Add((int)gridView1.GetRowCellValue(e.ControllerRow, gridColumn1), new PhongDTO((int)gridView1.GetRowCellValue(e.ControllerRow, gridColumn1), gridView1.GetRowCellValue(e.ControllerRow, gridColumn2).ToString(), (int)gridView1.GetRowCellValue(e.ControllerRow, colMaLP)));

            }
        }

        private void bntChonKH_Click(object sender, EventArgs e)
        {
            folderKhachHang.ChonKhachHang chonKhachHang = new folderKhachHang.ChonKhachHang(false);
            XtraDialogArgs args = new XtraDialogArgs(caption: "Caption", content: chonKhachHang, buttons: new DialogResult[] { DialogResult.OK, DialogResult.Cancel });
            args.Showing += Args_Showing;
            args.Caption = "Default Text";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };


            switch (XtraDialog.Show(args))
            {
                case DialogResult.OK:
                    dataSource_KhachHang = KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
                    txtKhachHang.Properties.DataSource = dataSource_KhachHang;

                    khachHang = chonKhachHang.LayKhachHangDaChon();
                    txtKhachHang.EditValue = khachHang.MaKH;


                    break;
                case DialogResult.Cancel:


                    break;
                default:
                    break;
            }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Text = "Chọn khách hàng";
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }

        private void txtGioVao_Validating(object sender, CancelEventArgs e)
        {
            if(txtGioVao.Time < DateTime.Now)
            {
                (sender as TimeEdit).ErrorText = "Thời gian đặt không được nhỏ hơn thời gian hiện tại";
                e.Cancel = true;

            }
            else

            {
                (sender as TimeEdit).ErrorText = "";
            }
        }
    }
}
