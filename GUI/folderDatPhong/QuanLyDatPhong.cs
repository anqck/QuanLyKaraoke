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
using DevExpress.XtraScheduler;
using BUS;
using DTO;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace GUI.folderDatPhong
{
    public partial class QuanLyDatPhong : XtraUserControl
    {
        DataSet dsDatPhong;
        DataTable dtDatPhong,dtChiTietDatPhong, dtDatPhong_ChiTietDatPhong, dtPhong;

        FilterControlDialog filterDialog;
        String strFilterDialog;

        public QuanLyDatPhong()
        {
            InitializeComponent();

            schedulerControl1.GoToToday();
            thongTinChiTietDatNhieuPhong1.goToHome = GoToHomePage;
            
        }
        public void RefreshDataBinding()
        {
            dsDatPhong = new DataSet();
            dtDatPhong = DatPhongBUS.LayTatCaDatPhong_TinhTrangPhong_KhachHang_NhanVien_DataTable();
            dtDatPhong.TableName = "datphong";
            dtChiTietDatPhong = ChiTietDatPhongBUS.LayTatCaChiTietDatPhong_DataTable();
            dtChiTietDatPhong.TableName = "chitietdatphong";
            dsDatPhong.Tables.Add(dtDatPhong);
            dsDatPhong.Tables.Add(dtChiTietDatPhong);
            dsDatPhong.Relations.Add(new DataRelation("thongtinchitietdatphong", dtDatPhong.Columns["MaDatPhong"], dtChiTietDatPhong.Columns["MaDatPhong"]));

            gridControl1.LevelTree.Nodes.Add("thongtinchitietdatphong", gridViewThongTinChiTietDatPhong);

            dtDatPhong_ChiTietDatPhong = DatPhongBUS.LayTatCaDatPhong_ChiTietDatPhong_DataTable();
            dtDatPhong_ChiTietDatPhong.Columns.Add("END_DATE");
            dtDatPhong_ChiTietDatPhong.Columns.Add("MaTinhTrangDatPhong_1",typeof(int));
            int thoiGianToiThieu = ThamSoBUS.LayKhoangThoiGianToiThieuGiuaHaiLanThue();
            foreach(DataRow row in dtDatPhong_ChiTietDatPhong.Rows)
            {
                row["END_DATE"] = DateTime.Parse(row["ThoiGianDatPhong"].ToString()).AddMinutes(thoiGianToiThieu);
                if((int)row["MaTinhTrangDatPhong"] ==1)
                    row["MaTinhTrangDatPhong_1"] = 3;
                else if ((int)row["MaTinhTrangDatPhong"] == 2)
                    row["MaTinhTrangDatPhong_1"] = 2;
                else
                    row["MaTinhTrangDatPhong_1"] = 1;
            }

            
            schedulerStorage1.Appointments.DataSource = dtDatPhong_ChiTietDatPhong;
            schedulerStorage1.Resources.DataSource = dtPhong = PhongBUS.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
            dtPhong.TableName = "phong";
            dsDatPhong.Tables.Add(dtPhong);
            dsDatPhong.Relations.Add(new DataRelation("thongtinphong", dtPhong.Columns["MaPhong"], dtChiTietDatPhong.Columns["MaPhong"]));


            schedulerStorage1.Appointments.Mappings.Subject = "MaDatPhong";
            schedulerStorage1.Appointments.Mappings.Label = "MaTinhTrangDatPhong_1";
            schedulerStorage1.Appointments.Mappings.Start =  "ThoiGianDatPhong";
            schedulerStorage1.Appointments.Mappings.End =  "END_DATE";
            schedulerStorage1.Appointments.Mappings.ResourceId = "MaPhong";

           schedulerStorage1.Resources.Mappings.Id = "MaPhong";
            schedulerStorage1.Resources.Mappings.Caption = "TenPhong";


            //Grid
            gridControl1.DataSource = dsDatPhong.Tables[0];


        }

        private void wbntHoadon_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Chi Tiết Đặt Phòng":
                    if(schedulerControl1.SelectedAppointments.Count > 0)    
                        (this.ParentForm as MainForm).HienThiThongTinDatPhong(int.Parse(schedulerControl1.SelectedAppointments[0].Subject));

                    break;
                case "Hiển Thị Dạng Bảng":
                    navigationFrame1.SelectedPage = navigationPage2;
                    break;
            }
        }

        public void GoToPage_WithoutAnimation(int v)
        {
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            navigationFrame1.SelectedPageIndex = v;
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void gridViewDatPhong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = false;
                windowsUIButtonPanel1.Buttons[1].Properties.Visible = false;
            }
               
            else
            {
                windowsUIButtonPanel1.Buttons[0].Properties.Visible = true;
                windowsUIButtonPanel1.Buttons[1].Properties.Visible = true;
            }
               
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
           
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Chi Tiết Đặt Phòng":
                   
                        (this.ParentForm as MainForm).HienThiThongTinDatPhong((int)dtDatPhong.Rows[gridViewDatPhong.GetFocusedDataSourceRowIndex()]["MaDatPhong"]);

                    break;
                case "Hiển Thị Dạng Biểu Đồ":
                    navigationFrame1.SelectedPage = navigationPage1;
                    break;
                case "Bộ Lọc":
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = "BỘ LỌC", Description = "Close the application?" };
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Lọc", Result = System.Windows.Forms.DialogResult.Yes };
                    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Hủy", Result = System.Windows.Forms.DialogResult.No };
                    action.Commands.Add(command1);
                    action.Commands.Add(command2);
                    FlyoutProperties properties = new FlyoutProperties();
                    properties.ButtonSize = new Size(160, 50);
                    properties.Style = FlyoutStyle.MessageBox;

                    filterDialog = new FilterControlDialog(gridControl1, gridViewDatPhong.ActiveFilterString.ToString());

                    if (DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.FindForm(), filterDialog, action, properties) == DialogResult.Yes)
                    {
                        if (filterDialog.GetFilterString() == "")
                            return;

                        gridViewDatPhong.ActiveFilterString = strFilterDialog = filterDialog.GetFilterString();
                        

                    }

                    break;
            }
        }

        public void GoToHomePage()
        {
            navigationFrame1.SelectedPageIndex = 0;
            RefreshDataBinding();
        }

       

        public void HienThiThongTinDatPhong(int maDatPhong)
        {
            thongTinChiTietDatNhieuPhong1.RefreshDataBinding(maDatPhong);
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            navigationFrame1.SelectedPageIndex = 2;
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void schedulerControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            System.Drawing.Point pos = new System.Drawing.Point(e.X, e.Y);
            DevExpress.XtraScheduler.Drawing.SchedulerViewInfoBase viewInfo = schedulerControl1.ActiveView.ViewInfo;
            DevExpress.XtraScheduler.Drawing.SchedulerHitInfo hitInfo = viewInfo.CalcHitInfo(pos, false);

            if (hitInfo.HitTest == DevExpress.XtraScheduler.Drawing.SchedulerHitTest.AppointmentContent)
            {
                (this.ParentForm as MainForm).HienThiThongTinDatPhong(int.Parse(schedulerControl1.SelectedAppointments[0].Subject));
            }
        }
        public void HienThiThongTinDatPhong(DatPhongDTO dto)
        {
            if (dto == null)
                return;

            thongTinChiTietDatNhieuPhong1.RefreshDataBinding(dto.MaDatPhong);
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            navigationFrame1.SelectedPageIndex = 2;
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
