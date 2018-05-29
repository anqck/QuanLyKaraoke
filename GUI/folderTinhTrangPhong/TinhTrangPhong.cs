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

namespace GUI.TinhTrangPhong
{
    public partial class TinhTrangPhong : DevExpress.XtraEditors.XtraUserControl
    {
        Dictionary<int,ThuePhongDTO> listPhongDangThue;
        public TinhTrangPhong()
        {
            InitializeComponent();

            btnThuePhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Thuê phòng"];
            btnThuePhong.Click += OnClickBtnThuePhong;

            btnXemPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Xem phòng"];
            btnXemPhong.Click += OnClickBtnXemPhong;

            btnDatPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Đặt phòng"];
            btnDatPhong.Click += OnClickBtnDatPhong;

            btnChuyenPhong = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Chuyển phòng"];
            btnChuyenPhong.Click += OnClickBtnChuyenPhong;

            btnThanhToan = (DevExpress.XtraBars.Docking2010.WindowsUIButton)wbntTinhtrangphong.Buttons["Thanh toán"];
            btnThanhToan.Click += OnClickBtnThanhToan;

           

            var colCheck = tileView1.Columns.AddVisible("Check");
            colCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            tileView1.ColumnSet.CheckedColumn = colCheck;
        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            
           
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
            try
            {
                gridControl.DataSource = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();

                //Tính giờ
                listPhongDangThue = BUS.ThuePhongBUS.LayThongTinCacPhongDangDuocThue();

                  

                tileAll.Elements[1].Text = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong().Rows.Count.ToString();

                grpLoaiPhong.Items.Clear();
                foreach (DataRow row in BUS.LoaiPhongBUS.LayTatCaLoaiPhong_DataTable().Rows)
                {
                    grpLoaiPhong.Items.Add(NewTileItem(row["TenLoaiPhong"].ToString()));

                }

                List<String> listLoaiPhongChecked = new List<string>();
                foreach (TileItem i in grpLoaiPhong.Items)
                {
                    if (i.Checked)
                        listLoaiPhongChecked.Add(i.Name);
                }
                strFilterLoaiPhong = BUS.TinhTrangPhongBUS.GetFilterString_LoaiPhong(listLoaiPhongChecked);
  
            }
            catch (Exception x)
            {

            }
        }

        internal void GoToPage(int v)
        {
            TinhtrangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            TinhtrangPagecontrol.SelectedPageIndex = v;
            TinhtrangPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
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
                        tileView1.ActiveFilterEnabled = false;
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
            //e.Item.Checked = true;
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
                thongTinChiTietPhong1.UpdateTime();

            tileView1.RefreshData();


        }

        private List<int> checkedRows = new List<int>();
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
            else if (e.Column.FieldName == "Check")
            {
                if (e.IsGetData)
                    e.Value = checkedRows.Contains(e.ListSourceRowIndex);

                if (e.IsSetData)
                {
                    if (System.Convert.ToBoolean(e.Value))
                        checkedRows.Add(e.ListSourceRowIndex);
                    else
                        checkedRows.Remove(e.ListSourceRowIndex);
                }
               
            }
        }

        private void tileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
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
                
            switch(tileView1.GetFocusedRowCellValue(colTinhTrangPhong).ToString())
            {
                case "Còn trống":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = true;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = false;
                    btnChuyenPhong.Visible = false;
                    btnThanhToan.Visible = false;

                    break;
                case "Đang sử dụng":
                    btnXemPhong.Visible = true;
                    wbntTinhtrangphong.Buttons[1].Properties.Visible = true;
                    btnDatPhong.Visible = true;

                    btnThuePhong.Visible = false;

                    wbntTinhtrangphong.Buttons[4].Properties.Visible = true;
                    btnChuyenPhong.Visible = true;
                    btnThanhToan.Visible = true;

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
            DTO.PhongDTO phongDTO = new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong"));

            FlyoutDialog.Show(this.FindForm(), new ThuePhong(phongDTO, OnThuePhongSuccess));
         
        }
        void OnClickBtnXemPhong(object sender, EventArgs e)
        {
            DisplayTinhTrangPhongWithSelectedTile();


        }
        void OnClickBtnDatPhong(object sender, EventArgs e)
        {
            
        }
        void OnClickBtnChuyenPhong(object sender, EventArgs e)
        {
            
        }

        private void wbntThemphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.TinhtrangPagecontrol.SelectedPage = this.PageTinhtrang;
        }

        void OnClickBtnThanhToan(object sender, EventArgs e)
        {
            BUS.ThanhToanBUS.TinhTienThuePhong( new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong")),DateTime.Now);
            DisplayThanhToanPhongWithSelectedTile();
        }

        
        #endregion

        #region CallBack
        void OnThuePhongSuccess()
        {
            RefreshDataBinding();

            DisplayTinhTrangPhongWithSelectedTile();

            
        }

        #endregion


        void DisplayTinhTrangPhongWithSelectedTile()
        {
            DTO.PhongDTO phongDTO = new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong"), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "Tang").ToString() , tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "GhiChu").ToString(), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaTinhTrangPhong"));

            thongTinChiTietPhong1.SetActionThanhToanButton(DisplayThanhToanPhongWithSelectedTile);
            thongTinChiTietPhong1.RefreshDataBinding(phongDTO);
            
            this.TinhtrangPagecontrol.SelectedPage = PageXemphong;
        }
        void DisplayThanhToanPhongWithSelectedTile()
        {
            DTO.PhongDTO phongDTO = new DTO.PhongDTO((int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaPhong"), (string)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "TenPhong"), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaLoaiPhong"), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "Tang").ToString(), tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "GhiChu").ToString(), (int)tileView1.GetRowCellValue(tileView1.GetSelectedRows()[0], "MaTinhTrangPhong"));

            thanhToan1.RefreshDataBinding(phongDTO);

            this.TinhtrangPagecontrol.SelectedPage = PageThanhtoan;
        }
    }
}
