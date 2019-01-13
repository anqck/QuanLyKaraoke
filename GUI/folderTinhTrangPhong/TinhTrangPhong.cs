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
using GUI.folderTinhTrangPhong;
using DTO;
using BUS;

namespace GUI.TinhTrangPhong
{
    public partial class TinhTrangPhong : DevExpress.XtraEditors.XtraUserControl
    {
        Dictionary<int,ThuePhongDTO> listPhongDangThue;
        Dictionary<int, PhongDTO> listDanhSachPhongDangDat, listPhongSapDuocDat;
        Dictionary<int, ChiTietDatPhongDTO> listChiTietDatPhong;
        Dictionary<int, DateTime> listThoiGianDat; //MaDatPhong , ThoiGian

        DataTable danhSachPhong;
        DataTable dtLoaiPhong;
        private List<int> checkedRows;
        public TinhTrangPhong()
        {
            InitializeComponent();

            thanhToan1.goBackHome = GoToHome;
            thongTinChiTietNhieuPhong1.goBackHome = GoToHome;

            btnThuePhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Thuê phòng"];
            btnThuePhong.Click += OnClickBtnThuePhong;

            btnXemPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Xem phòng"];
            btnXemPhong.Click += OnClickBtnXemPhong;

            btnDonDep = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Đã dọn dẹp"];
            btnDonDep.Click += OnClickBtnDonDep;

            btnDatPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Đặt phòng"];
            btnDatPhong.Click += OnClickBtnDatPhong;

            btnChuyenPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Chuyển phòng"];
            btnChuyenPhong.Click += OnClickBtnChuyenPhong;

            btnThanhToan = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Thanh toán"];
            btnThanhToan.Click += OnClickBtnThanhToan;

            btnXemDatPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Xem thông tin đặt phòng"];
            btnXemDatPhong.Click += OnClickBtnXemDatPhong;


            checkedRows = new List<int>();
            var colCheck = tileView1.Columns.AddVisible("Check");
            colCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            tileView1.ColumnSet.CheckedColumn = colCheck;



        }

             

        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(this.wbntBack.Buttons[0]))
            {
                this.TinhtrangPagecontrol.SelectedPage = PageTinhtrang;
            }
        }


        public void RefreshDataBinding()
        {

           
            gridControl.DataSource = danhSachPhong = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong_KhaDung();

                //Tính giờ
                listPhongDangThue = BUS.ThuePhongBUS.LayThongTinCacPhongDangDuocThue();              



                tileAll.Elements[1].Text = danhSachPhong.Rows.Count.ToString();
                tileAvailable.Elements[1].Text = PhongBUS.DemSoLuongPhong(0).ToString();
                tileRented.Elements[1].Text = PhongBUS.DemSoLuongPhong(1).ToString();
                tileSapDat.Elements[1].Text = (PhongBUS.DemSoLuongPhong(4) + PhongBUS.DemSoLuongPhong(6)).ToString();
                tileDonDep.Elements[1].Text = (PhongBUS.DemSoLuongPhong(5) + PhongBUS.DemSoLuongPhong(6)).ToString();


            dtLoaiPhong = BUS.LoaiPhongBUS.LayTatCaLoaiPhong_DataTable_GroupByName();

            if(dtLoaiPhong.Rows.Count == grpLoaiPhong.Items.Count)
            {
                bool flagSame = true;
                for(int i = 0; i < grpLoaiPhong.Items.Count; i ++)
                {
                    if(dtLoaiPhong.Rows[i]["TenLoaiPhong"].ToString() != grpLoaiPhong.Items[i].Name)
                    {
                        flagSame = false;
                        break;
                    }
                }
                if(!flagSame)
                {
                    grpLoaiPhong.Items.Clear();
                    foreach (DataRow row in BUS.LoaiPhongBUS.LayTatCaLoaiPhong_DataTable_GroupByName().Rows)
                    {
                        grpLoaiPhong.Items.Add(NewTileItem(row["TenLoaiPhong"].ToString()));

                    }
                }
            }
            else
            {
                grpLoaiPhong.Items.Clear();
                foreach (DataRow row in BUS.LoaiPhongBUS.LayTatCaLoaiPhong_DataTable_GroupByName().Rows)
                {                    
                    grpLoaiPhong.Items.Add(NewTileItem(row["TenLoaiPhong"].ToString()));

                }
            }
                
               


                List<String> listLoaiPhongChecked = new List<string>();
                foreach (TileItem i in grpLoaiPhong.Items)
                {
                    if (i.Checked)
                        listLoaiPhongChecked.Add(i.Name);
                }

            if (listLoaiPhongChecked.Count != 0)
            {
                strFilterLoaiPhong = BUS.TinhTrangPhongBUS.GetFilterString_LoaiPhong(listLoaiPhongChecked);
               
            }
            else
            {
                strFilterLoaiPhong = "[TenLoaiPhong] = null";
            }
            //strFilterLoaiPhong = BUS.TinhTrangPhongBUS.GetFilterString_LoaiPhong(listLoaiPhongChecked);

                DisplayBottomButtonWithSelectedTile();

                listPhongSapDuocDat = new Dictionary<int, PhongDTO>();
                listDanhSachPhongDangDat = PhongBUS.LayCacPhongDangDuocDat();

                listThoiGianDat = new Dictionary<int, DateTime>();
            foreach(PhongDTO phong in listDanhSachPhongDangDat.Values)
            {
                listThoiGianDat.Add(phong.MaPhong, DatPhongBUS.LayThongTinThuePhongCuaPhongDangDat(phong.MaPhong, DateTime.Now).ThoiGianDatPhong);
            }


        }

        internal void GoToPage(int v)
        {
            TinhtrangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            TinhtrangPagecontrol.SelectedPageIndex = v;
            TinhtrangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        internal void GoToHome()
        {
            RefreshDataBinding();
            TinhtrangPagecontrol.SelectedPageIndex = 0;

        }



        #region Types
        private TileItem NewTileItem(String name)
        {
            TileItem t = new TileItem();

            t.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            t.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            t.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           t.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Gray;
           t.AppearanceItem.Normal.Options.UseBackColor = true;
           t.AppearanceItem.Normal.Options.UseBorderColor = true;
           t.AppearanceItem.Normal.Options.UseFont = true;
           t.AppearanceItem.Normal.Options.UseForeColor = true;
           
           //t.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
           //t.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           //t.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
           //t.AppearanceItem.Selected.Options.UseBackColor = true;
           //t.AppearanceItem.Selected.Options.UseFont = true;
           //t.AppearanceItem.Selected.Options.UseForeColor = true;



           t.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
           t.Name = name;
            t.Text = name;
            t.Checked = true;

            t.ItemClick += tileLoaiPhong_ItemClick;
            return t;
        }

        TileItem preSelect;
        String strFilterTinhTrangPhong = "", strFilterLoaiPhong = "";
        private void tileControl2_ItemPress(object sender, TileItemEventArgs e)
        {

            switch (e.Item.Name)
            {
                case "tileAll":
                    //tileView1.ActiveFilterEnabled = false;
                    strFilterTinhTrangPhong = "";
                    if(strFilterLoaiPhong != "[TenLoaiPhong] = null")
                    {
                        tileView1.ActiveFilterString = strFilterLoaiPhong;
                    }
                    else
                    {
                        //tileView1.ActiveFilterEnabled = false;
                    }
                    preSelect = tileAll;
                    break;
                case "tileAvailable":
                    preSelect = tileAvailable;

                        strFilterTinhTrangPhong = "[TinhTrangPhong] = 'Còn trống'";
                        tileView1.ActiveFilterString = "(" + strFilterLoaiPhong + ") and " + strFilterTinhTrangPhong;

                    break;
                case "tileRented":
                    preSelect = tileRented;

                        strFilterTinhTrangPhong = "[TinhTrangPhong] = 'Đang sử dụng'";
                        tileView1.ActiveFilterString = "(" +strFilterLoaiPhong + ") and " + strFilterTinhTrangPhong;
                 
                    break;
                case "tileSapDat":
                    preSelect = tileSapDat;

                    strFilterTinhTrangPhong = "[TinhTrangPhong] = 'Đã đặt trước' or [TinhTrangPhong] = 'Chờ dọn dẹp - Đã đặt trước'";
                    tileView1.ActiveFilterString = "(" + strFilterLoaiPhong + ") and " + strFilterTinhTrangPhong;

                    break;
                case "tileDonDep":
                    preSelect = tileDonDep;

                    strFilterTinhTrangPhong = "[TinhTrangPhong] = 'Chờ dọn dẹp' or [TinhTrangPhong] = 'Chờ dọn dẹp - Đã đặt trước'";
                    tileView1.ActiveFilterString = "(" + strFilterLoaiPhong + ") and " + strFilterTinhTrangPhong;

                    break;
                default:
                   

                    return;
            }
            
            
           //tileView1.ActiveFilterString = "[TenLoaiPhong] = 'VIP 1'";
        }

        
        private void tileLoaiPhong_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = (TileItem)sender;

            if (tileItem.Checked)
                tileItem.Checked = false;
            else
                tileItem.Checked = true;

            List<String> listLoaiPhongChecked = new List<string>();
            foreach (TileItem i in grpLoaiPhong.Items)
            {
                if (i.Checked)
                    listLoaiPhongChecked.Add(i.Name);
            }
            

            if (listLoaiPhongChecked.Count != 0)
            {
                strFilterLoaiPhong = BUS.TinhTrangPhongBUS.GetFilterString_LoaiPhong(listLoaiPhongChecked);
                if (strFilterTinhTrangPhong != "")
                    tileView1.ActiveFilterString = "(" + strFilterLoaiPhong + ") and " + strFilterTinhTrangPhong;
                else
                    tileView1.ActiveFilterString = strFilterLoaiPhong;
            }               
            else
            {
                strFilterLoaiPhong = "[TenLoaiPhong] = null";
                tileView1.ActiveFilterString = strFilterLoaiPhong;
            }
               
        }

        #endregion

        private void tileView1_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            DisplayTinhTrangPhongWithSelectedTile();
        }
        private void tileView1_ItemPress(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            checkedRows.Clear();
            tileView1.RefreshData();
            //checkedRows.Add(tileView1.GetFocusedDataSourceRowIndex());
            
        }

        private void tileControl2_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            if (preSelect == null)
                tileControl2.SelectedItem = tileAll;
            else
                tileControl2.SelectedItem = preSelect;
        }
        

      

        #region Time
        internal void UpdateTime()
        {
            if (listPhongDangThue == null)
                return;
            
            if (this.TinhtrangPagecontrol.SelectedPage == PageXemphong)
                thongTinChiTietNhieuPhong1.UpdateTime();

            tileView1.RefreshData();


        }

        
        private void tileView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "colThoiGianThue")
            {
                if (e.IsGetData)
                
                    if (listPhongDangThue.ContainsKey((int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaPhong"]) && (int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaTinhTrangPhong"] == 1)
                    {
                        e.Value = ToCustomString((DateTime.Now - listPhongDangThue[(int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaPhong"]].GioThuePhong));
                    }
                    else
                        e.Value = "";

                if (e.IsSetData) ;
            }
            if (e.Column.FieldName == "colThoiGianDat")
            {
                if (e.IsGetData)

                    if (listThoiGianDat.ContainsKey((int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaPhong"]) && ((int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaTinhTrangPhong"] == 4 || (int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaTinhTrangPhong"] == 6 || (int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaTinhTrangPhong"] == 7))
                    {
                        if(DateTime.Now > listThoiGianDat[(int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaPhong"]])
                        {
                            e.Value = ToCustomString((DateTime.Now - listThoiGianDat[(int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaPhong"]]));
                           
                            //this.tileView1.TileTemplate[11].Appearance.Normal.ForeColor = Color.Blue;
                        }
                        else
                        {
                            e.Value = ToCustomString((listThoiGianDat[(int)((DataView)tileView1.DataSource)[e.ListSourceRowIndex]["MaPhong"]] - DateTime.Now));
                            //this.tileView1.TileTemplate[11].Appearance.Normal.ForeColor = Color.Red;
                        }
                         

                        //this.tileView1.TileTemplate[11];
                            
                    }
                    else
                        e.Value = "";

                if (e.IsSetData) ;
            }

            else if (e.Column.FieldName == "TinhTrangPhong1")
            {
                if (e.IsGetData)
                {
                    e.Value = danhSachPhong.Rows[e.ListSourceRowIndex]["TinhTrangPhong"];
                    //switch((int)danhSachPhong.Rows[e.ListSourceRowIndex]["MaTinhTrangPhong"])
                    //{
                    //    case 0: e.Value = "Còn trống"; break;
                    //    case 1: e.Value = "Đang sử dụng"; break;
                    //    case 2: e.Value = "Đang sửa chữa"; break;
                    //    case 3: e.Value = "Đã xóa"; break;
                    //    case 4: e.Value = "Đã đặt trước"; break;
                    //    case 5: e.Value = "Chờ dọn dẹp"; break;
                    //    case 6: e.Value = "Chờ dọn dẹp - Đã đặt trước"; break;
                    //    case 7: e.Value = "Đang sử dung<br>Đã đặt trước"; break;
                    //}
                }
                    
               

                if (e.IsSetData) ;
            }
            else if (e.Column.FieldName == "colGrpImg")
            {
                if (e.IsGetData)
                {
                    if((int)danhSachPhong.Rows[e.ListSourceRowIndex]["MaTinhTrangPhong"] ==1)
                    {
                        if (!listPhongDangThue.ContainsKey((int)danhSachPhong.Rows[e.ListSourceRowIndex]["MaPhong"]))
                            return;

                        if(BUS.HoaDonBUS.DemSoLuongThuePhong(listPhongDangThue[(int)danhSachPhong.Rows[e.ListSourceRowIndex]["MaPhong"]].MaHoaDon) > 1)
                            e.Value = Properties.Resources.grpIcon;
                        else
                            e.Value = Properties.Resources.singleIcon;
                    }
                }        
            }
            else if (e.Column.FieldName == "Check")
            {
                if (e.IsGetData)
                    e.Value = checkedRows.Contains(e.ListSourceRowIndex);

                if (e.IsSetData)
                {
                    if (System.Convert.ToBoolean(e.Value))
                    {
                        checkedRows.Add(e.ListSourceRowIndex);


                        tileView1.FocusedRowHandle = -1;

                        foreach (int idx in checkedRows)
                        {
                            if (danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Đang sử dụng") == 0 || danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Đã đặt trước") == 0 || danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Chờ dọn dẹp") == 0 || danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Chờ dọn dẹp - Đã đặt trước") == 0)
                            {
                                btnXemPhong.Visible = false;
                                wbntTinhtrangphong.Buttons[1].Properties.Visible = false;
                                btnDatPhong.Visible = false;
                                btnThuePhong.Visible = false;

                                wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                                btnChuyenPhong.Visible = false;
                                btnThanhToan.Visible = false;

                                btnDonDep.Visible = false;
                                break;
                            }             
                            else
                            {
                                btnXemPhong.Visible = false;
                                wbntTinhtrangphong.Buttons[1].Properties.Visible = false;
                                btnDatPhong.Visible = true;

                                btnThuePhong.Visible = true;

                                wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                                btnChuyenPhong.Visible = false;
                                btnThanhToan.Visible = false;
                                btnDonDep.Visible = false;

                            }
                        }
                    }

                    else
                    {
                        checkedRows.Remove(e.ListSourceRowIndex);


                        if (checkedRows.Count >= 1)
                        {
                            tileView1.FocusedRowHandle = -1;
                            foreach (int idx in checkedRows)
                            {
                                if (danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Đang sử dụng") == 0 || danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Đã đặt trước") == 0 || danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Chờ dọn dẹp") == 0 || danhSachPhong.Rows[idx]["TinhTrangPhong"].ToString().CompareTo("Chờ dọn dẹp - Đã đặt trước") == 0)
                                {
                                    btnXemPhong.Visible = false;
                                    wbntTinhtrangphong.Buttons[1].Properties.Visible = false;
                                    btnDatPhong.Visible = false;
                                    btnThuePhong.Visible = false;

                                    wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                                    btnChuyenPhong.Visible = false;
                                    btnThanhToan.Visible = false;
                                    btnDonDep.Visible = false;
                                    break;
                                }
                                else
                                {
                                    btnXemPhong.Visible = false;
                                    wbntTinhtrangphong.Buttons[1].Properties.Visible = false;
                                    btnDatPhong.Visible = true;

                                    btnThuePhong.Visible = true;

                                    wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                                    btnChuyenPhong.Visible = false;
                                    btnThanhToan.Visible = false;
                                    btnDonDep.Visible = false;

                                }
                            }
                        }
                        else if (checkedRows.Count == 0)
                            tileView1.FocusedRowHandle = 0;
                    }

                }

            }
        }

        private void tileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DisplayBottomButtonWithSelectedTile();
        }
        void DisplayBottomButtonWithSelectedTile()
        {
            if (tileView1.GetFocusedRowCellValue(colTinhTrangPhong) == null)
            {
                btnXemPhong.Visible = false;
                wbntTinhtrangphong.Buttons[1].Properties.Visible = false;
                btnDatPhong.Visible = false;
                btnThuePhong.Visible = false;

                wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                btnChuyenPhong.Visible = false;
                btnThanhToan.Visible = false;
                return;
            }

            switch (tileView1.GetFocusedRowCellValue(colTinhTrangPhong).ToString())
            {
                case "Còn trống":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = true;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                    btnChuyenPhong.Visible = false;
                    btnThanhToan.Visible = false;
                    btnXemDatPhong.Visible = false;
                    btnDonDep.Visible = false;

                    break;
                case "Đã đặt trước":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = false;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                    btnChuyenPhong.Visible = false;
                    btnThanhToan.Visible = false;
                    btnXemDatPhong.Visible = true;
                    btnDonDep.Visible = false;

                    break;
                case "Đang sử dụng":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = false;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = true;
                    btnChuyenPhong.Visible = true;
                    btnThanhToan.Visible = true;
                    btnXemDatPhong.Visible = false;
                    btnDonDep.Visible = false;

                    break;
                case "Chờ dọn dẹp":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = false;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = true;
                    btnChuyenPhong.Visible = false;
                    btnThanhToan.Visible = false;
                    btnXemDatPhong.Visible = false;
                    btnDonDep.Visible = true;
                    break;
                case "Chờ dọn dẹp - Đã đặt trước":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = false;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = true;
                    btnChuyenPhong.Visible = false;
                    btnThanhToan.Visible = false;
                    btnXemDatPhong.Visible = true;
                    btnDonDep.Visible = true;
                    break;
                default:
                    break;
            }
        }



        public string ToCustomString(TimeSpan span)
        {
            return string.Format("{0}:{1:D2}:{2:D2}", span.Days * 24 + span.Hours, span.Minutes, span.Seconds);
        }
        #endregion

        #region Button
        void OnClickBtnThuePhong(object sender, EventArgs e)
        {
            List<PhongDTO> listPhong = new List<PhongDTO>();
            if (checkedRows.Count != 0)
            {
                for (int i = 0; i < checkedRows.Count; i++)
                {
                    listPhong.Add(new DTO.PhongDTO((int)danhSachPhong.Rows[checkedRows[i]]["MaPhong"], danhSachPhong.Rows[checkedRows[i]]["TenPhong"].ToString(), (int)danhSachPhong.Rows[checkedRows[i]]["MaLoaiPhong"]));
                }

            }
            else
            {
                listPhong.Add(new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong")));


            }


            FlyoutDialog.Show(this.FindForm(), new ThuePhong(listPhong, OnThuePhongSuccess));

        }
        void OnClickBtnXemPhong(object sender, EventArgs e)
        {
            DisplayTinhTrangPhongWithSelectedTile();


        }
        void OnClickBtnDatPhong(object sender, EventArgs e)
        {
            FlyoutDialog.Show(this.FindForm(), new DatPhong(OnDatPhongSuccess));


        }
        void OnClickBtnChuyenPhong(object sender, EventArgs e)
        {

            DisplayChuyenPhongWithSelectedTile();



        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.TinhtrangPagecontrol.SelectedPage = this.PageTinhtrang;
        }

        void OnClickBtnThanhToan(object sender, EventArgs e)
        {
            //BUS.ThanhToanBUS.TinhTienThuePhong( new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong")),DateTime.Now);
            DisplayThanhToanPhongWithSelectedTile();
        }


        void OnClickBtnXemDatPhong(object sender, EventArgs e)
        {
            
            (ParentForm as MainForm).HienThiThongTinDatPhong(DatPhongBUS.LayThongTinThuePhongCuaPhongDangDat((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), DateTime.Now));
        }
        void OnClickBtnDonDep(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận đã dọn dẹp phòng " + tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong") + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (tileView1.GetFocusedRowCellValue(colTinhTrangPhong).ToString() == "Chờ dọn dẹp")
                {
                    BUS.PhongBUS.CapNhatTinhTrangPhong((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), 0);
                    RefreshDataBinding();
                }
                else if (tileView1.GetFocusedRowCellValue(colTinhTrangPhong).ToString() == "Chờ dọn dẹp - Đã đặt trước")
                {
                    BUS.PhongBUS.CapNhatTinhTrangPhong((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), 4);
                    RefreshDataBinding();
                }


            }
        }
        #endregion

        #region CallBack
        void OnThuePhongSuccess(ThuePhongDTO thuePhong)
        {
            RefreshDataBinding();

            DisplayTinhTrangPhongWithSelectedTile(thuePhong);
            
        }

        void OnDatPhongSuccess(DatPhongDTO thuePhong)
        {
            RefreshDataBinding();

            UpdateTimeNotify();

            (ParentForm as MainForm).HienThiThongTinDatPhong(thuePhong);
        }

        #endregion


        void DisplayTinhTrangPhongWithSelectedTile(ThuePhongDTO thuePhong = null)
        {
                       

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitForm1));
            if(thuePhong == null)
            {
                if (listPhongDangThue.ContainsKey((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong")))
                    thongTinChiTietNhieuPhong1.RefreshDataBinding(listPhongDangThue[(int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong")], DisplayThanhToanPhongWithSelectedTile);

                else
                    thongTinChiTietNhieuPhong1.RefreshDataBinding(new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "Tang"), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "GhiChu").ToString(), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaTinhTrangPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "SucChua")), DisplayThanhToanPhongWithSelectedTile);

                
            }
            else
            {
                thongTinChiTietNhieuPhong1.RefreshDataBinding(thuePhong, DisplayThanhToanPhongWithSelectedTile);
                
            }


            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            this.TinhtrangPagecontrol.SelectedPage = PageXemphong;
        }

        private void tileView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void windowsUIButtonPanel1_ButtonClick_1(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.TinhtrangPagecontrol.SelectedPage = PageTinhtrang;
        }

        private void TinhtrangPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (e.Page == PageTinhtrang)
                RefreshDataBinding();
        }

        void DisplayThanhToanPhongWithSelectedTile(ThuePhongDTO thuePhong=null)
        {
            //DTO.PhongDTO phongDTO = new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong"), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "Tang").ToString(), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "GhiChu").ToString(), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaTinhTrangPhong"));

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitForm1));
            if (thuePhong == null)
                thanhToan1.RefreshDataBinding(listPhongDangThue[(int)danhSachPhong.Rows[tileView1.GetFocusedDataSourceRowIndex()]["MaPhong"]]);
            else
                thanhToan1.RefreshDataBinding(thuePhong);
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

            this.TinhtrangPagecontrol.SelectedPage = PageThanhtoan;
        }

        void DisplayChuyenPhongWithSelectedTile(ThuePhongDTO thuePhong = null)
        {
            //DTO.PhongDTO phongDTO = new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong"), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "Tang").ToString(), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "GhiChu").ToString(), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaTinhTrangPhong"));
            ThuePhongDTO thuePhongDto;
            
            if (thuePhong == null)

                thuePhongDto = listPhongDangThue[(int)danhSachPhong.Rows[tileView1.GetFocusedDataSourceRowIndex()]["MaPhong"]];
            else
                thuePhongDto = thuePhong;

            ChuyenPhong formChuyenPhong = new ChuyenPhong(thuePhongDto);
            if (FlyoutDialog.Show(this.FindForm(), formChuyenPhong) == DialogResult.OK)
            {
                DisplayTinhTrangPhongWithSelectedTile(formChuyenPhong.GetThuePhongMoi());
            }
            else
            {

            }

            //this.TinhtrangPagecontrol.SelectedPage = PageThanhtoan;
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileView1_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
          
            //    if(e.Item["TinhTrangPhong"].ToString() == "Đã đặt trước")
            //{
                if (listThoiGianDat.ContainsKey((int)tileView1.GetRowCellValue(e.RowHandle, colMaPhong)) && ((int)tileView1.GetRowCellValue(e.RowHandle, colMaTinhTrangPhong) == 4 || (int)tileView1.GetRowCellValue(e.RowHandle, colMaTinhTrangPhong) == 6 || (int)tileView1.GetRowCellValue(e.RowHandle, colMaTinhTrangPhong) == 7))
                {
                  

                if (DateTime.Now > listThoiGianDat[(int)tileView1.GetRowCellValue(e.RowHandle, colMaPhong) ])
                    {
                            e.Item["colThoiGianDat"].Appearance.Normal.ForeColor = Color.Red;
                     }
                    else

                {
                    e.Item["colThoiGianDat"].Appearance.Normal.ForeColor = Color.Blue;
                }

                }
                       
            
            //    else
            //{

            //}
                    
            
        }

        public void UpdateTimeNotify()
        {
            Dictionary<int,PhongDTO> tempSapDat = BUS.ThuePhongBUS.LayCacPhongDangSapDuocDat(ThamSoBUS.LayKhoangThoiGianChoDatPhong());
            //Dictionary<int, PhongDTO> tempSapDat = BUS.ThuePhongBUS.LayCacPhongDangSapDuocDat(-5);
            Dictionary<int, DatPhongDTO> tempDatPhongHetHanDat = BUS.DatPhongBUS.LayCacDatPhongDangHetHanDat(ThamSoBUS.LayKhoangThoiGianTuDongHuyDatPhong());

            if (listDanhSachPhongDangDat == null)
                return;



            foreach(PhongDTO phong in tempSapDat.Values)
            {
                if (!listDanhSachPhongDangDat.ContainsKey(phong.MaPhong))
                {
                    if(!listThoiGianDat.ContainsKey(phong.MaPhong))
                    {
                        listThoiGianDat.Add(phong.MaPhong, DatPhongBUS.LayThongTinThuePhongCuaPhongDangDat(phong.MaPhong,DateTime.Now).ThoiGianDatPhong);
                    }
                    else
                    {

                    }

                    if(phong.MaTinhTrangPhong == 0)
                    {
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Header = "THÔNG BÁO PHÒNG SẮP ĐƯỢC ĐẶT";
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body = "Phòng "+ phong.TenPhong +" được đặt trong "+ ThamSoBUS.LayKhoangThoiGianChoDatPhong() + " phút nữa!";
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body2 = "";
                        (this.ParentForm as MainForm).GeToastNotifications().ShowNotification((this.ParentForm as MainForm).GeToastNotifications().Notifications[0]);

                        BUS.PhongBUS.CapNhatTinhTrangPhong(phong.MaPhong, 4);
                    }            
                    else if (phong.MaTinhTrangPhong == 5)
                    {
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Header = "THÔNG BÁO PHÒNG SẮP ĐƯỢC ĐẶT";
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body = "Phòng " + phong.TenPhong + " được đặt trong " + ThamSoBUS.LayKhoangThoiGianChoDatPhong() + " phút nữa! Phòng vẫn đang trong trạng thái chờ dọn dẹp!";
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body2 = "";
                        (this.ParentForm as MainForm).GeToastNotifications().ShowNotification((this.ParentForm as MainForm).GeToastNotifications().Notifications[0]);

                        BUS.PhongBUS.CapNhatTinhTrangPhong(phong.MaPhong, 6);
                    }
                    else if (phong.MaTinhTrangPhong == 1)
                    {
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Header = "THÔNG BÁO PHÒNG SẮP ĐƯỢC ĐẶT";
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body = "Phòng " + phong.TenPhong + " được đặt trong " + ThamSoBUS.LayKhoangThoiGianChoDatPhong() + " phút nữa! Phòng vẫn đang trong trạng thái chờ dọn dẹp!";
                        (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body2 = "";
                        (this.ParentForm as MainForm).GeToastNotifications().ShowNotification((this.ParentForm as MainForm).GeToastNotifications().Notifications[0]);

                        BUS.PhongBUS.CapNhatTinhTrangPhong(phong.MaPhong, 7);
                    }


                }          
         
            }

            
            foreach(DatPhongDTO datPhong in tempDatPhongHetHanDat.Values)
            {
                foreach(ChiTietDatPhongDTO chiTiet in DatPhongBUS.LayTatCaCacChiTietDatPhong(datPhong.MaDatPhong))
                {
                    if (listThoiGianDat.ContainsKey(chiTiet.MaPhong))
                    {
                        listThoiGianDat.Remove(chiTiet.MaPhong);
                    }

                    if (listDanhSachPhongDangDat.ContainsKey(chiTiet.MaPhong))
                    {
                       if(PhongBUS.LayThongTinPhong(chiTiet.MaPhong).MaTinhTrangPhong == 4)
                        {
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Header = "THÔNG BÁO PHÒNG ĐƯỢC ĐẶT QUÁ THỜI GIAN CHỜ";
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body = "Phòng " + BUS.PhongBUS.LayThongTinPhong(chiTiet.MaPhong).TenPhong + " được đặt quá thời gian chờ nên sẽ chuyển về trạng thái trống và đặt phòng được tự động hủy. ";
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body2 = "";
                            (this.ParentForm as MainForm).GeToastNotifications().ShowNotification((this.ParentForm as MainForm).GeToastNotifications().Notifications[0]);

                            BUS.PhongBUS.CapNhatTinhTrangPhong(chiTiet.MaPhong, 0);
                        }
                       else if (PhongBUS.LayThongTinPhong(chiTiet.MaPhong).MaTinhTrangPhong == 6)
                        {
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Header = "THÔNG BÁO PHÒNG ĐƯỢC ĐẶT QUÁ THỜI GIAN CHỜ";
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body = "Phòng " + BUS.PhongBUS.LayThongTinPhong(chiTiet.MaPhong).TenPhong + " được đặt quá thời gian chờ nên sẽ chuyển về trạng thái trống và đặt phòng được tự động hủy. ";
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body2 = "";
                            (this.ParentForm as MainForm).GeToastNotifications().ShowNotification((this.ParentForm as MainForm).GeToastNotifications().Notifications[0]);

                            BUS.PhongBUS.CapNhatTinhTrangPhong(chiTiet.MaPhong, 5);
                        }
                        else if (PhongBUS.LayThongTinPhong(chiTiet.MaPhong).MaTinhTrangPhong == 7)
                        {
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Header = "THÔNG BÁO PHÒNG ĐƯỢC ĐẶT QUÁ THỜI GIAN CHỜ";
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body = "Phòng " + BUS.PhongBUS.LayThongTinPhong(chiTiet.MaPhong).TenPhong + " được đặt quá thời gian chờ nên sẽ chuyển về trạng thái trống và đặt phòng được tự động hủy. ";
                            (this.ParentForm as MainForm).GeToastNotifications().Notifications[0].Body2 = "";
                            (this.ParentForm as MainForm).GeToastNotifications().ShowNotification((this.ParentForm as MainForm).GeToastNotifications().Notifications[0]);

                            BUS.PhongBUS.CapNhatTinhTrangPhong(chiTiet.MaPhong, 1);
                        }

                    }
                    DatPhongBUS.CapNhatTinhTrangDatPhong(3, chiTiet.MaDatPhong);
                }
            }

          

            RefreshDataBinding();
            
            //MessageBox.Show("Notification #2 Clicked");
        }
        public void HienThiThongTinPhong(ThuePhongDTO dto)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitForm1));           
                thongTinChiTietNhieuPhong1.RefreshDataBinding(dto, DisplayThanhToanPhongWithSelectedTile);

            


            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            this.TinhtrangPagecontrol.SelectedPage = PageXemphong;
        }
    }
}
