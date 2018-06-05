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
using DevExpress.XtraBars.Docking2010;

namespace GUI.folderTinhTrangPhong
{
    public partial class ThanhToan : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dsHoaDon;
        DataSet dsDichVuPhong;

        private KhachHangDTO khachHang;
        private HoaDonDTO hoaDon;
        private ThuePhongDTO thuePhong;

        reportHoaDon reportHoaDon;

        bool ReadOnlyMode;

       
        public Action goBackHome { get; set; }

       

        public ThanhToan()
        {
            InitializeComponent();

            reportHoaDon = new reportHoaDon();

            dsDichVuPhong = new DataSet();

        }
        public void RefreshDataBinding(ThuePhongDTO thuePhongDTO)
        {
            ReadOnlyMode = false;

            wbntQuanlyphong.Buttons[0].Properties.Visible = true;
            wbntQuanlyphong.Buttons[1].Properties.Visible = true;
            wbntQuanlyphong.Buttons[2].Properties.Visible = true;
            wbntQuanlyphong.Buttons[4].Properties.Visible = true;

            this.hoaDon = BUS.HoaDonBUS.LayThongTinHoaDonDangThue(thuePhongDTO.MaHoaDon);
            this.thuePhong = thuePhongDTO;
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            hoaDon.NgayThanhToan = DateTime.Now;
            

            dsHoaDon = new DataSet();
            dsHoaDon.Tables.Add(HoaDonBUS.LayThongTinHoaDon_DataTable(hoaDon.MaHoaDon));
            dsHoaDon.Tables.Add(HoaDonBUS.LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(hoaDon.MaHoaDon));
            dsHoaDon.Tables[1].Columns.Add(new DataColumn("TienPhong",typeof(double)));
            dsHoaDon.Tables[1].Columns.Add(new DataColumn("TienGioTamTinh", typeof(double)));
            dsHoaDon.Relations.Add("Danh sách thuê phòng", dsHoaDon.Tables[0].Columns["MaHoaDon"], dsHoaDon.Tables[1].Columns["MaHoaDon"]);



            this.tabbedControlGroup1.Clear();
            List<ThuePhongDTO> listThuePhong = HoaDonBUS.LayTatCaCacThuePhong(hoaDon.MaHoaDon);
            for (int i = 0; i < listThuePhong.Count; i ++)
            {
                ChiTietThanhToanPhong chiTietThanhToanPhongThanhToan = new ChiTietThanhToanPhong();
                DevExpress.XtraLayout.LayoutControlGroup layoutGrp = new DevExpress.XtraLayout.LayoutControlGroup();
                DevExpress.XtraLayout.LayoutControlItem layoutItem = new DevExpress.XtraLayout.LayoutControlItem();
                chiTietThanhToanPhongThanhToan.CalcTongTienAction = CalcTongTien_UpdateHoaDon;
                chiTietThanhToanPhongThanhToan.AddButtonXoaDichVu((WindowsUIButton)wbntQuanlyphong.Buttons[1]);
                chiTietThanhToanPhongThanhToan.RefreshDataBinding(listThuePhong[i], khachHang);
                dsHoaDon.Tables[1].Rows[i]["GioTraPhong"] = chiTietThanhToanPhongThanhToan.thuePhong.GioTraPhong;
                


                //thongTinChiTietPhong.SetActionThanhToanButton(goToThanhToan);
                //DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // chiTietThanhToanPhongThanhToan
                // 
                chiTietThanhToanPhongThanhToan.Location = new System.Drawing.Point(37, 187);
                chiTietThanhToanPhongThanhToan.Name = "chiTietThanhToanPhong1";
                chiTietThanhToanPhongThanhToan.Size = new System.Drawing.Size(867, 414);
                chiTietThanhToanPhongThanhToan.TabIndex = 25;
                // 
                // layoutItem
                // 
                layoutItem.Control = chiTietThanhToanPhongThanhToan;
                layoutItem.Location = new System.Drawing.Point(0, 0);
                layoutItem.Name = "layoutControlItem8";
                layoutItem.Size = new System.Drawing.Size(873, 420);
                layoutItem.TextSize = new System.Drawing.Size(0, 0);
                layoutItem.TextVisible = false;
                // 
                // layoutGrp
                // 
                layoutGrp.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutItem });
                layoutGrp.Location = new System.Drawing.Point(0, 0);
                layoutGrp.Name = "layoutControlGroup2";
                layoutGrp.OptionsItemText.TextToControlDistance = 4;
                layoutGrp.Size = new System.Drawing.Size(873, 420);
                layoutGrp.Text = PhongBUS.LayThongTinPhong(listThuePhong[i].MaPhong).TenPhong;
                layoutGrp.Tag = chiTietThanhToanPhongThanhToan;


                this.tabbedControlGroup1.AddTabPage(layoutGrp);
            }
       
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;

            CalcTongTien_UpdateHoaDon();

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;
            txtMaKhachHang.EditValue = khachHang.MaKH;
            txtTenKhachHang.EditValue = khachHang.TenKH;
            txtGhiChu.EditValue = hoaDon.GhiChu;

            txtTienTraTruoc.ReadOnly = false;
            txtGhiChu.ReadOnly = false;



        }

        public void RefreshDataBinding_ReadOnly(HoaDonDTO hoaDonDTO)
        {
            ReadOnlyMode = true;
            this.hoaDon = hoaDonDTO;       
            this.khachHang = BUS.KhachHangBUS.LayKhachHang(hoaDon.MaKH);

            //dsHoaDon = new DataSet();
            //dsHoaDon.Tables.Add(HoaDonBUS.LayThongTinHoaDon_DataTable(hoaDon.MaHoaDon));
            //dsHoaDon.Tables.Add(HoaDonBUS.LayTatCaCacThuePhong_DataTable(hoaDon.MaHoaDon));

           

            wbntQuanlyphong.Buttons[0].Properties.Visible = false;
            wbntQuanlyphong.Buttons[1].Properties.Visible = false;
            wbntQuanlyphong.Buttons[2].Properties.Visible = false;      
            wbntQuanlyphong.Buttons[4].Properties.Visible = false;

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            hoaDon.NgayThanhToan = DateTime.Now;


            dsHoaDon = new DataSet();
            dsHoaDon.Tables.Add(HoaDonBUS.LayThongTinHoaDon_DataTable(hoaDon.MaHoaDon));
            dsHoaDon.Tables.Add(HoaDonBUS.LayTatCaCacThuePhong_Phong_LoaiPhong_DataTable(hoaDon.MaHoaDon));
            dsHoaDon.Tables[1].Columns.Add(new DataColumn("TienPhong", typeof(double)));
            dsHoaDon.Tables[1].Columns.Add(new DataColumn("TienGioTamTinh", typeof(double)));
            dsHoaDon.Relations.Add("Danh sách thuê phòng", dsHoaDon.Tables[0].Columns["MaHoaDon"], dsHoaDon.Tables[1].Columns["MaHoaDon"]);



            this.tabbedControlGroup1.Clear();
            List<ThuePhongDTO> listThuePhong = HoaDonBUS.LayTatCaCacThuePhong(hoaDonDTO.MaHoaDon);
            for (int i = 0; i < listThuePhong.Count; i++)
            {
                ChiTietThanhToanPhong chiTietThanhToanPhongThanhToan = new ChiTietThanhToanPhong();
                DevExpress.XtraLayout.LayoutControlGroup layoutGrp = new DevExpress.XtraLayout.LayoutControlGroup();
                DevExpress.XtraLayout.LayoutControlItem layoutItem = new DevExpress.XtraLayout.LayoutControlItem();
                chiTietThanhToanPhongThanhToan.CalcTongTienAction = CalcTongTien_UpdateHoaDon;
                chiTietThanhToanPhongThanhToan.AddButtonXoaDichVu((WindowsUIButton)wbntQuanlyphong.Buttons[1]);
                chiTietThanhToanPhongThanhToan.RefreshDataBinding_ReadOnly(listThuePhong[i]);
                dsHoaDon.Tables[1].Rows[i]["GioTraPhong"] = chiTietThanhToanPhongThanhToan.thuePhong.GioTraPhong;



                //thongTinChiTietPhong.SetActionThanhToanButton(goToThanhToan);
                //DevExpress.XtraTab.XtraTabPage xtraTab = new DevExpress.XtraTab.XtraTabPage();

                // 
                // chiTietThanhToanPhongThanhToan
                // 
                chiTietThanhToanPhongThanhToan.Location = new System.Drawing.Point(37, 187);
                chiTietThanhToanPhongThanhToan.Name = "chiTietThanhToanPhong1";
                chiTietThanhToanPhongThanhToan.Size = new System.Drawing.Size(867, 414);
                chiTietThanhToanPhongThanhToan.TabIndex = 25;
                // 
                // layoutItem
                // 
                layoutItem.Control = chiTietThanhToanPhongThanhToan;
                layoutItem.Location = new System.Drawing.Point(0, 0);
                layoutItem.Name = "layoutControlItem8";
                layoutItem.Size = new System.Drawing.Size(873, 420);
                layoutItem.TextSize = new System.Drawing.Size(0, 0);
                layoutItem.TextVisible = false;
                // 
                // layoutGrp
                // 
                layoutGrp.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutItem });
                layoutGrp.Location = new System.Drawing.Point(0, 0);
                layoutGrp.Name = "layoutControlGroup2";
                layoutGrp.OptionsItemText.TextToControlDistance = 4;
                layoutGrp.Size = new System.Drawing.Size(873, 420);
                layoutGrp.Text = PhongBUS.LayThongTinPhong(listThuePhong[i].MaPhong).TenPhong;
                layoutGrp.Tag = chiTietThanhToanPhongThanhToan;


                this.tabbedControlGroup1.AddTabPage(layoutGrp);
            }

            this.tabbedControlGroup1.SelectedTabPageIndex = 0;

            CalcTongTien_UpdateHoaDon();

            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNgayThanhToan.Time = DateTime.Now;
            txtTienTraTruoc.EditValue = hoaDon.TienTraTruoc;
            txtMaKhachHang.EditValue = khachHang.MaKH;
            txtTenKhachHang.EditValue = khachHang.TenKH;
            txtGhiChu.EditValue = hoaDon.GhiChu;

            txtTienTraTruoc.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
        }


        
        public void CalcTongTien_UpdateHoaDon()
        {
            double TongTienGio = 0, TongTienKhuyenMai = 0, TongTienDichVu = 0;
            dsDichVuPhong.Tables.Clear();
           

            for(int i = 0; i < this.tabbedControlGroup1.TabPages.Count; i++)
            {
                TongTienGio += ((ChiTietThanhToanPhong)this.tabbedControlGroup1.TabPages[i].Tag).GetTongTienGio();
                TongTienKhuyenMai += ((ChiTietThanhToanPhong)this.tabbedControlGroup1.TabPages[i].Tag).GetTongTienKhuyenMai();
                TongTienDichVu += ((ChiTietThanhToanPhong)this.tabbedControlGroup1.TabPages[i].Tag).GetTongTienDichVu();

                dsHoaDon.Tables[1].Rows[i]["TienPhong"] = TongTienGio + TongTienDichVu +TongTienKhuyenMai;
                
                dsDichVuPhong.Tables.Add(((ChiTietThanhToanPhong)tabbedControlGroup1.TabPages[i].Tag).GetDichVuPhong_DataTable());
            }
          

            DataTable MergedDataTable = new DataTable("dichvuphong");
            MergedDataTable.Merge(dsDichVuPhong.Tables[0]);
            if (!ReadOnlyMode) //ReadOnly Mode
            {
                for (int i = 1; i < dsDichVuPhong.Tables.Count; i++)
                {
                    foreach (DataRow dr in dsDichVuPhong.Tables[i].Rows)
                    {
                        DataRow row = MergedDataTable.NewRow();
                        row["MaDVP"] = MergedDataTable.Rows.Count;
                        row["MaThuePhong"] = dr["MaThuePhong"];
                        row["MaDV"] = dr["MaDV"];
                        row["ThoiGian"] = dr["ThoiGian"];
                        row["SoLuong"] = dr["SoLuong"];
                        row["Gia"] = dr["Gia"];
                        row["TenDV"] = dr["TenDV"];
                        row["DonVi"] = dr["DonVi"];
                        row["colType"] = dr["colType"];
                        MergedDataTable.Rows.Add(row);

                    }
                }
            }
            else
            {
                for (int i = 1; i < dsDichVuPhong.Tables.Count; i++)
                {
                    MergedDataTable.Merge(dsDichVuPhong.Tables[i]);
                }
            }
            

            if (dsHoaDon.Tables.Count == 3)
            {
                dsHoaDon.Relations.RemoveAt(1);
                dsHoaDon.Tables[2].Constraints.Clear();
                dsHoaDon.Tables.RemoveAt(2);

            }
            dsHoaDon.Tables.Add(MergedDataTable);
            dsHoaDon.Relations.Add("chitietdichvu", dsHoaDon.Tables[1].Columns["MaThuePhong"], dsHoaDon.Tables[2].Columns["MaThuePhong"]);



            txtTongTienGio.EditValue = TongTienGio;
            txtTongTienKhuyenMai.EditValue = TongTienKhuyenMai;
            txtTongTienDichVu.EditValue = TongTienDichVu;
            txtTongTienThanhToan.EditValue = TongTienGio + TongTienKhuyenMai + TongTienDichVu - Convert.ToDouble(txtTienTraTruoc.EditValue);

    
            hoaDon.MaNhanVienThanhToan = (this.ParentForm as MainForm).nhanVien.MaNhanVien;
            hoaDon.TongTienThanhToan = (double)txtTongTienThanhToan.EditValue;
            hoaDon.NgayThanhToan = txtNgayThanhToan.Time;
            hoaDon.SoTienKhuyenMai = (double)txtTongTienKhuyenMai.EditValue;

            reportHoaDon.BindingData(dsHoaDon, khachHang,hoaDon,TongTienGio, TongTienKhuyenMai, TongTienDichVu, Convert.ToDouble(txtTienTraTruoc.EditValue),txtGhiChu.Text);
            

            reportHoaDon.CreateDocument();
            documentViewer1.DocumentSource = reportHoaDon;
            documentViewer1.Zoom= 0.83f;
        }

       

        private void wbntQuanlyphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm Dịch Vụ":
                    ((ChiTietThanhToanPhong)tabbedControlGroup1.SelectedTabPage.Tag).ThemDichVu();
                    break;
                case "Xóa Dịch Vụ":
                    ((ChiTietThanhToanPhong)tabbedControlGroup1.SelectedTabPage.Tag).XoaDichVu();
                    break;

                case "Thanh toán":
             
                    //hoaDon.TienGio = (double)txtTongTienGio.EditValue;

                    HoaDonBUS.CapNhatHoaDonDaThanhToan(hoaDon);
                    foreach (DevExpress.XtraLayout.LayoutControlGroup layoutGroup in this.tabbedControlGroup1.TabPages)
                    {
                        ((ChiTietThanhToanPhong)layoutGroup.Tag).LuuKhuyenMai();
                        ((ChiTietThanhToanPhong)layoutGroup.Tag).CapNhatThongTinThuePhong();
                        PhongBUS.CapNhatTinhTrangPhong(((ChiTietThanhToanPhong)layoutGroup.Tag).thuePhong.MaPhong,0);
                    }

                    if(khachHang.MaLoaiKH != 0)
                    {
                        KhachHangBUS.CapNhatDiemTichLuy(khachHang.MaKH, khachHang.DiemTichLuy + ThamSoBUS.QuyDoiDiem((double)txtTongTienThanhToan.EditValue));
                        khachHang.DiemTichLuy = khachHang.DiemTichLuy + ThamSoBUS.QuyDoiDiem((double)txtTongTienThanhToan.EditValue);

                        LoaiKhachHangDTO loaiKhachHangCoThe = KhachHangBUS.LayLoaiKhachHangCoTheDatDuoc(khachHang);
                        if (khachHang.MaLoaiKH != loaiKhachHangCoThe.MaLoaiKH)
                        {
                            KhachHangBUS.CapNhatLoaiKhachHang(khachHang.MaKH, loaiKhachHangCoThe.MaLoaiKH);
                            XtraMessageBox.Show("Khách hàng được cập nhật lên loại '" + loaiKhachHangCoThe.TenLoaiKH + "'! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    

                    goBackHome();

                    break;
                case "In hóa đơn":
       
                    XtraDialogArgs args = new XtraDialogArgs(caption: "Chọn dịch vụ", content: new ReportViewer(reportHoaDon), buttons: new DialogResult[] { DialogResult.OK });
                    XtraDialog.Show(args);

                   // DevExpress.XtraBars.Docking2010.Customization.FlyoutDialog.Show(this.FindForm(),new ReportViewer(reportHoaDon));
                    break;
            }
        }

        private void windowsUIButtonPanel2_Click(object sender, EventArgs e)
        {
            goBackHome();
        }

        private void txtTienTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            
            HoaDonBUS.CapNhatTienTraTruoc(hoaDon, Convert.ToDouble(txtTienTraTruoc.EditValue));
            CalcTongTien_UpdateHoaDon();
        }

        private void txtGhiChu_EditValueChanged(object sender, EventArgs e)
        {
            HoaDonBUS.CapNhatGhiChu(hoaDon.MaHoaDon, txtGhiChu.EditValue.ToString());
            CalcTongTien_UpdateHoaDon();

        }
    }


}
