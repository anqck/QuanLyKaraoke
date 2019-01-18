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
using DTO;
using BUS;

namespace GUI.folderTinhTrangPhong
{
    public partial class TachHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dtThuePhong;
        Dictionary<int, ThuePhongDTO> selectedThuePhong;

        private Action callBackSuccess;
        HoaDonDTO hoaDon;

        public TachHoaDon()
        {
            InitializeComponent();

            
        }
        public TachHoaDon(HoaDonDTO hoaDonDTO, Action callBackSuccess) : this()
        {
            this.hoaDon = HoaDonBUS.LayThongTinHoaDon(hoaDonDTO.MaHoaDon);
            this.callBackSuccess = callBackSuccess;

            selectedThuePhong = new Dictionary<int, ThuePhongDTO>();

            RefreshDataBinding();


            ValidateChildren();


        }

  

        private void RefreshDataBinding()
        {
            txtPhong_2.Properties.DataSource = dtThuePhong= HoaDonBUS.LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(hoaDon.MaHoaDon);

            txtMaHoaDon_Goc.Text = hoaDon.MaHoaDon.ToString();
            txtTienTraTruoc_Goc.EditValue = hoaDon.TienTraTruoc;
            txtKhachHang_Goc.Text = KhachHangBUS.LayKhachHang(hoaDon.MaKH).TenKH;
            txtGhiChu_Goc.Text = hoaDon.GhiChu;

            foreach (DataRow dr in dtThuePhong.Rows)
            {
                
                    txtPhong_Goc.Text += PhongBUS.LayThongTinPhong((int)dr["MaPhong"]).TenPhong;

                    txtPhong_Goc.Text += "; ";
                
            }

            txtMaHoaDon_1.Text = txtMaHoaDon_Goc.Text;
            txtTienTraTruoc_1.EditValue = txtTienTraTruoc_Goc.EditValue;
            txtKhachHang_1.Text = txtKhachHang_Goc.Text;
            txtGhiChu_1.Text = txtGhiChu_Goc.Text;

            txtMaHoaDon_2.Text = HoaDonBUS.PhatSinhMaHoaDon().ToString();
            txtKhachHang_2.Text = txtKhachHang_Goc.Text;
            txtGhiChu_2.Text = txtGhiChu_Goc.Text;
            txtTienTraTruoc_2.Properties.MaxValue = Convert.ToDecimal(hoaDon.TienTraTruoc);
        }
       


        private void txtPhong_Properties_Validating(object sender, CancelEventArgs e)
        {
            if(gridView2.GetSelectedRows().Count()==0)
            {
                txtPhong_1.ErrorText = "Không có phòng nào được chọn";
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                txtGhiChu_1.ReadOnly = true;
            }
            else
            {
                txtPhong_1.ErrorText = "";
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
                txtGhiChu_1.ReadOnly = true;
            }
        }

        private void txtPhong_EditValueChanged(object sender, EventArgs e)
        {
            ValidateChildren();

            if (gridView2.GetSelectedRows().Count() != 0)
            {
                //int sourceIdx = gridView1.GetDataSourceRowIndex(gridView1.GetSelectedRows().ElementAt(0));
                //txtMaPhong.EditValue = dtPhong.Rows[sourceIdx]["MaPhong"];
                //txtLoaiPhong.EditValue = dtPhong.Rows[sourceIdx]["TenLoaiPhong"];
                //txtTang.EditValue = dtPhong.Rows[sourceIdx]["Tang"];
                //txtGhiChu.EditValue = dtPhong.Rows[sourceIdx]["GhiChu"];

            }
        }

        private void txtGhiChu_EditValueChanged(object sender, EventArgs e)
        {
            //PhongBUS.CapNhatGhiChu((int)txtMaPhong.EditValue, txtGhiChu.EditValue.ToString());
        }

        private void txtGhiChu_Old_EditValueChanged(object sender, EventArgs e)
        {
            //PhongBUS.CapNhatGhiChu((int)txtMaPhong_Old.EditValue, txtGhiChu_Old.EditValue.ToString());
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Hủy":
                    ((FlyoutDialog)this.Parent).DialogResult = DialogResult.Cancel;
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                case "Tách":
                    //Tạo Hóa Đơn mới
                    HoaDonBUS.LuuThongTinHoaDon(new HoaDonDTO(Convert.ToInt32(txtMaHoaDon_2.Text), -1, Double.NaN, Convert.ToDouble(txtTienTraTruoc_2.EditValue), DateTime.MinValue, Double.NaN, txtGhiChu_2.Text, hoaDon.MaKH, hoaDon.MaDatPhong));

                    //Cập nhật hóa đơn cũ
                    HoaDonBUS.CapNhatGhiChu(hoaDon.MaHoaDon, txtGhiChu_1.Text);
                    HoaDonBUS.CapNhatTienTraTruoc(hoaDon, Convert.ToDouble(txtTienTraTruoc_2.EditValue));


                    //Sửa các thuê phòng 
                    foreach (DataRow dr in dtThuePhong.Rows)
                    {
                        if (selectedThuePhong.ContainsKey((int)dr["MaThuePhong"]))
                        {
                            ThuePhongBUS.CapNhatHoaDon((int)dr["MaThuePhong"], Convert.ToInt32(txtMaHoaDon_2.Text));

                        }
                        
                      
                    }
                    XtraMessageBox.Show("Tách hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    callBackSuccess();

                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                default:
                    break;
            }
        }

        private void txtPhong_Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            var editor = sender as GridLookUpEdit;
            var view = editor.Properties.View;
            var selectedRowsCount = view.GetSelectedRows().Count();



            e.DisplayText = "";

            if (selectedThuePhong.Count == 0)
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                txtPhong_2.ErrorText = "Không có thuê phòng nào được chọn";
                return;
            }
            else if(selectedThuePhong.Count == dtThuePhong.Rows.Count)
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                txtPhong_1.ErrorText = "Thuê phòng không được rỗng";
            }
            else
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
                txtPhong_2.ErrorText = "";
            }



            for (int i = 0; i < selectedThuePhong.Values.Count; i++)
            {

                e.DisplayText += PhongBUS.LayThongTinPhong(selectedThuePhong.Values.ToList()[i].MaPhong).TenPhong;
                if (i != selectedThuePhong.Values.Count - 1)
                    e.DisplayText += "; ";
            }

            txtPhong_1.Text = "";

            foreach (DataRow dr in dtThuePhong.Rows)
            {
                if (!selectedThuePhong.ContainsKey((int)dr["MaThuePhong"]))
                {
                    txtPhong_1.Text += PhongBUS.LayThongTinPhong((int)dr["MaPhong"]).TenPhong;

                    txtPhong_1.Text += "; ";
                }
            }

        }

        private void txtPhong1_Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            foreach (DataRow dr in dtThuePhong.Rows)
            {
                if (!selectedThuePhong.ContainsKey((int)dr["MaThuePhong"]))
                {
                    e.DisplayText += PhongBUS.LayThongTinPhong((int)dr["MaThuePhong"]).TenPhong;
                    
                        e.DisplayText += "; ";
                }
            }

        }

        private void txtPhong_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            (sender as GridLookUpEdit).LookAndFeel.UpdateStyleSettings();

        }

        private void txtPhong_Properties_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit edit = (GridLookUpEdit)sender;
            for (int i = 0; i < dtThuePhong.Rows.Count; i++)
            {
                foreach (ThuePhongDTO phong in selectedThuePhong.Values)
                {
                    if (phong.MaThuePhong == (int)gridView2.GetRowCellValue(i, colMaThuePhong))
                    {

                        edit.Properties.View.SelectRow(i);
                        break;
                    }
                }

            }

        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)

                selectedThuePhong.Remove((int)gridView2.GetRowCellValue(e.ControllerRow, colMaThuePhong));
            else if (e.Action == CollectionChangeAction.Add)
            {
                if (e.ControllerRow < 0)
                    return;
                if (!selectedThuePhong.Keys.Contains((int)gridView2.GetRowCellValue(e.ControllerRow, colMaThuePhong)))
                    selectedThuePhong.Add((int)gridView2.GetRowCellValue(e.ControllerRow, colMaThuePhong), new ThuePhongDTO((int)gridView2.GetRowCellValue(e.ControllerRow, colMaThuePhong), (int)gridView2.GetRowCellValue(e.ControllerRow, colMaPhong), DateTime.MinValue, DateTime.MinValue,hoaDon.MaHoaDon,0));

            }
        }

        private void spinEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtTienTraTruoc_1.EditValue =   Convert.ToDecimal(txtTienTraTruoc_Goc.EditValue) - Convert.ToDecimal(txtTienTraTruoc_2.EditValue);
        }
    }
}
