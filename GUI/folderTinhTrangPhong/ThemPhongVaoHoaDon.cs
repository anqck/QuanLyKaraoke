using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Customization;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThemPhongVaoHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable dtPhong;
        Dictionary<int, PhongDTO> selectedPhong;
        HoaDonDTO hoaDon;

        private Action onThuePhongSuccess;

        public ThemPhongVaoHoaDon()
        {
            InitializeComponent();

            selectedPhong = new Dictionary<int, PhongDTO>();
        }

        public ThemPhongVaoHoaDon(HoaDonDTO hoaDon,Action onThemPhongVaoHoaDonSuccess) : this()
        {
            this.hoaDon = hoaDon;
            this.onThuePhongSuccess = onThemPhongVaoHoaDonSuccess;

            RefreshDataBinding();

            txtGioVao.EditValue = DateTime.Now;
            txtMaHoaDon.EditValue = hoaDon.MaHoaDon;
        }

        private void txtPhong_Properties_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
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

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            if (e.Action == CollectionChangeAction.Remove)
                selectedPhong.Remove((int)dtPhong.Rows[e.ControllerRow]["MaPhong"]);
            else if (e.Action == CollectionChangeAction.Add)
            {
                if (!selectedPhong.Keys.Contains((int)dtPhong.Rows[e.ControllerRow]["MaPhong"]))
                    selectedPhong.Add((int)dtPhong.Rows[e.ControllerRow]["MaPhong"], new PhongDTO((int)dtPhong.Rows[e.ControllerRow]["MaPhong"], dtPhong.Rows[e.ControllerRow]["TenPhong"].ToString(), (int)dtPhong.Rows[e.ControllerRow]["MaLP"]));

            }

        }

        private void txtPhong_Properties_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit edit = (GridLookUpEdit)sender;
            for (int i = 0; i < dtPhong.Rows.Count; i++)
            {
                foreach (PhongDTO phong in selectedPhong.Values)
                {
                    if (phong.MaPhong == (int)dtPhong.Rows[i]["MaPhong"])
                    {

                        edit.Properties.View.SelectRow(i);
                        break;
                    }
                }

            }

        }
        private void txtPhong_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            (sender as GridLookUpEdit).LookAndFeel.UpdateStyleSettings();

        }

        public void RefreshDataBinding()
        {
           
            txtPhong.Properties.DataSource = dtPhong = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong_CoSan();

          

        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Hủy":
                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                case "Thuê":


                    //NOTE Tài khoản thanh toán
                    //BÌNH

                    foreach (PhongDTO phong in selectedPhong.Values)
                    {
                        if (PhongBUS.LayThongTinPhong(phong.MaPhong).MaTinhTrangPhong != 0)
                        {
                            XtraMessageBox.Show("Phòng " + phong.TenPhong + " hiện không có sẵn! Vui lòng chọn lại phòng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            txtPhong.Properties.DataSource = dtPhong = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong_CoSan();


                            selectedPhong.Clear();
                            txtPhong.Refresh();
                            return;
                        }

                    }


                    ThuePhongDTO tp = null;
                    foreach (PhongDTO phong in selectedPhong.Values)
                    {
                        tp = new ThuePhongDTO(ThuePhongBUS.PhatSinhMaThuePhong(), phong.MaPhong, (DateTime)txtGioVao.EditValue, DateTime.MinValue, hoaDon.MaHoaDon, double.NaN);
                        ThuePhongBUS.LuuThongTinThuePhong(tp);
                        PhongBUS.CapNhatTinhTrangPhong(phong, 1);
                    }



                    //Thông báo thành công
                    onThuePhongSuccess();

                    ((FlyoutDialog)this.Parent).Hide();



                    break;
                default:
                    break;
            }
        }
    }
}
