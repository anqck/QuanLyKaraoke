using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace GUI.folderHeThong
{
    public partial class NgayLe : XtraUserControl
    {
        public Action actionBack { get; set; }
        DataTable dtNgayLe;

        public NgayLe()
        {
            InitializeComponent();
        }

        public void RefeshDataBinding()
        {
            gridControl1.DataSource = dtNgayLe = NgayLeBUS.LayTatCaNgayLe_DataTable();


        }

        private void wbntSuaphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            // set required Input Box options 
            args.Caption = "Thêm ngày lễ";
            args.Prompt = "Ngày:";
            args.DefaultButtonIndex = 0;
            args.Showing += Args_Showing;
            // initialize a DateEdit editor with custom settings 
            DateEdit editor = new DateEdit();
            editor.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            editor.Properties.Mask.EditMask = "dd - MM";
            args.Editor = editor;
            
            switch (e.Button.Properties.Tag.ToString())
            {

                case "Thêm Ngày Lễ":
                    args.DefaultResponse = DateTime.Now;
                    if (XtraInputBox.Show(args) != null)
                    {
                        DateTime dt = new DateTime(2000,editor.DateTime.Month, editor.DateTime.Day);
                   
                        if(NgayLeBUS.KiemTraNgayLeTonTai(dt))
                        {
                            XtraMessageBox.Show("Ngày lễ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                           
                        NgayLeBUS.ThemNgayLe(new DTO.NgayLeDTO(NgayLeBUS.PhatSinhMaNgayLe(), editor.DateTime));
                        XtraMessageBox.Show("Thêm ngày lễ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefeshDataBinding();
                    }
                    break;
                case "Xóa Ngày Lễ":
                    if(XtraMessageBox.Show("Xác nhận xóa ngày lễ '"+ ((DateTime)dtNgayLe.Rows[gridView1.GetFocusedDataSourceRowIndex()]["NgayLe"]).ToString("dd - MM")+ "'?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        NgayLeBUS.XoaNgayLe((int)dtNgayLe.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaNgayLe"]);
                        RefeshDataBinding();
                    }
                    break;
                case "Sửa Ngày Lễ":
                    args.DefaultResponse =  (DateTime)dtNgayLe.Rows[gridView1.GetFocusedDataSourceRowIndex()]["NgayLe"];
                    if (XtraInputBox.Show(args) != null)
                    {
                        DateTime dt = new DateTime(2000, editor.DateTime.Month, editor.DateTime.Day);

                        if (NgayLeBUS.KiemTraNgayLeTonTai(dt))
                        {
                            XtraMessageBox.Show("Ngày lễ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                        NgayLeBUS.SuaNgayLe(new DTO.NgayLeDTO((int)dtNgayLe.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaNgayLe"], editor.DateTime));
                        XtraMessageBox.Show("Sửa ngày lễ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefeshDataBinding();
                    }

                    break;
                case "Trở Lại":
                    actionBack();
                    break;
            }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Lưu";
            e.Buttons[DialogResult.Cancel].Text = "Hủy";
            //e.Form.Icon = this.Icon;

        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            actionBack();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.RowCount == 0)
            {
                wbntSuaphong.Buttons[1].Properties.Visible = false;
                wbntSuaphong.Buttons[2].Properties.Visible = false;
            }

            if(e.FocusedRowHandle >= 1)
            {
                wbntSuaphong.Buttons[1].Properties.Visible = true;
                wbntSuaphong.Buttons[2].Properties.Visible = true;
            }
        }
    }
}
