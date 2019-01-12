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
using DevExpress.XtraBars.Docking2010.Customization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BUS;
using DevExpress.Utils;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThuePhong : DevExpress.XtraEditors.XtraUserControl
    {
        Dictionary<int,PhongDTO> selectedPhong;

        private KhachHangDTO khachHang;

        private DataTable dataSource_KhachHang;
        private DataTable dtPhong;
        private Action<ThuePhongDTO> onThuePhongSuccess;

        public ThuePhong()
        {
            InitializeComponent();

            khachHang = null;


            selectedPhong = new Dictionary<int, PhongDTO>();


        }

        public ThuePhong(List<PhongDTO> listPhong, Action<ThuePhongDTO> onThuePhongSuccess) : this()
        {
            //this.phong = phong;

            this.onThuePhongSuccess = onThuePhongSuccess;

            //txtMaPhong.Text = phong.MaPhong.ToString();
            //txtTenPhong.Text = phong.TenPhong;
            //txtLoaiPhong.Text = LoaiPhongBUS.LayLoaiPhong(phong).TenLoaiPhong;

            RefreshDataBinding();

            txtKhachHang.Properties.DisplayMember = "TenKH";
            txtKhachHang.Properties.ValueMember = "MaKH";


            txtGioVao.EditValue = DateTime.Now;

            khachHang = KhachHangBUS.LayTatCaKhachHang()[0];

            foreach (PhongDTO phong in listPhong)
            {
                selectedPhong.Add(phong.MaPhong, phong);
            }

           

            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
                //var rowHandle = gridView1.GetVisibleRowHandle(i);
                //var row = gridView1.GetRow(rowHandle);

                //if (selectedPhong.Values.Contains())
                //{
                //    gvMainEditView.SelectRow(i);
                //}

            
        }

        public void RefreshDataBinding()
        {
            dataSource_KhachHang = KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();
            txtPhong.Properties.DataSource = dtPhong = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong_CoSan();

            txtKhachHang.Properties.DataSource = dataSource_KhachHang;

            txtKhachHang.EditValue = 0;           
            
        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Hủy":

                    ((FlyoutDialog)this.Parent).Hide();
                    break;
                case "Thuê":
                    //Kiểm tra khách hàng
                    if (khachHang == null)
                    {
                        XtraMessageBox.Show("Không có khách hàng nào được chọn!", "Lỗi", MessageBoxButtons.OK);
                        return;
                    }

                    //NOTE Tài khoản thanh toán
                    //BÌNH

                    
                    //Phát sinh hóa đơn
                    HoaDonDTO hoaDon = new HoaDonDTO(HoaDonBUS.PhatSinhMaHoaDon(), -1, Double.NaN, Convert.ToDouble(txtTienTraTruoc.EditValue), DateTime.MinValue, Double.NaN, txtGhiChu.Text, khachHang.MaKH,-1);
                    HoaDonBUS.LuuThongTinHoaDon(hoaDon);

                    ThuePhongDTO tp = null;
                    foreach(PhongDTO phong in selectedPhong.Values)
                    {
                        tp = new ThuePhongDTO(ThuePhongBUS.PhatSinhMaThuePhong(), phong.MaPhong, (DateTime)txtGioVao.EditValue, DateTime.MinValue, hoaDon.MaHoaDon, double.NaN);
                        ThuePhongBUS.LuuThongTinThuePhong(tp);
                        PhongBUS.CapNhatTinhTrangPhong(phong, 1);
                    }

                   
                    
                        //Thông báo thành công
                        onThuePhongSuccess(tp);

                        ((FlyoutDialog)this.Parent).Hide();
                    
                 

                    break;
                default:
                    break;
            }
        }

        private void bntChonKH_Click(object sender, EventArgs e)
        {

            folderKhachHang.ChonKhachHang chonKhachHang = new folderKhachHang.ChonKhachHang();
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
           


            //FlyoutDialog.Show(this.FindForm(), new folderKhachHang.ChonKhachHang());
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Text = "Chọn khách hàng";
            e.Buttons[DialogResult.OK].Text = "Chọn";
            e.Buttons[DialogResult.Cancel].Text = "Hủy bỏ";
        }

        private void txtKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view =

            txtKhachHang.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;

           
            //khachHang = new KhachHangDTO((int)dataSource_KhachHang.Rows[idxSelected]["MaKH"], dataSource_KhachHang.Rows[idxSelected]["TenKH"].ToString(), dataSource_KhachHang.Rows[idxSelected]["CMND"].ToString(), dataSource_KhachHang.Rows[idxSelected]["SDT"].ToString(), dataSource_KhachHang.Rows[idxSelected]["DiaChi"].ToString(), (int)dataSource_KhachHang.Rows[idxSelected]["MaLoaiKH"], (int)dataSource_KhachHang.Rows[idxSelected]["DiemTichLuy"]);
           
            
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int idxSelected = gridLookUpEdit1View.GetFocusedDataSourceRowIndex();
            khachHang = new KhachHangDTO((int)dataSource_KhachHang.Rows[idxSelected]["MaKH"], dataSource_KhachHang.Rows[idxSelected]["TenKH"].ToString(), dataSource_KhachHang.Rows[idxSelected]["CMND"].ToString(), dataSource_KhachHang.Rows[idxSelected]["SDT"].ToString(), dataSource_KhachHang.Rows[idxSelected]["DiaChi"].ToString(), (int)dataSource_KhachHang.Rows[idxSelected]["MaLoaiKH"], (double)dataSource_KhachHang.Rows[idxSelected]["DiemTichLuy"], (dataSource_KhachHang.Rows[0]["NgaySinh"].ToString() == "") ? (DateTime.MinValue) : ((DateTime)dataSource_KhachHang.Rows[0]["NgaySinh"]));


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

        private void txtPhong_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            (sender as GridLookUpEdit).LookAndFeel.UpdateStyleSettings();

        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if(e.Column.FieldName == "colCheck")
            //{
            //    if (e.IsGetData)
            //        e.Value = selectedPhong.Keys.Contains((int)dtPhong.Rows[e.ListSourceRowIndex]["MaPhong"]);

            //    if (e.IsSetData)
            //    {
            //        if (selectedPhong.Keys.Contains((int)dtPhong.Rows[e.ListSourceRowIndex]["MaPhong"]))
            //            selectedPhong.Remove((int)dtPhong.Rows[e.ListSourceRowIndex]["MaPhong"]);
            //        else
            //            selectedPhong.Add((int)dtPhong.Rows[e.ListSourceRowIndex]["MaPhong"],new PhongDTO((int)dtPhong.Rows[e.ListSourceRowIndex]["MaPhong"], dtPhong.Rows[e.ListSourceRowIndex]["TenPhong"].ToString(), (int)dtPhong.Rows[e.ListSourceRowIndex]["MaLP"]));
            //    }
                   
                    
            //}
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            if (e.Action == CollectionChangeAction.Remove)
                selectedPhong.Remove((int)dtPhong.Rows[e.ControllerRow]["MaPhong"]);
            else if (e.Action == CollectionChangeAction.Add)
            {
                if (e.ControllerRow < 0)
                    return;
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


    }
}


