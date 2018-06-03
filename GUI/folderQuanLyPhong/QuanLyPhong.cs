﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.folderQuanLyPhong
{
    public partial class QuanLyPhong : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable phong;
        public QuanLyPhong()
        {
            InitializeComponent();
            themPhongMoi1.actionBack = GoToHomePage;
            suaPhong1.actionBack = GoToHomePage;
        }
        void GoToHomePage()
        {
            this.QuanlyPagecontrol.SelectedPage = PageQuanly;
        }
        private void wbntTinhtrangphong_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            
            switch (e.Button.Properties.Tag.ToString())
            {
                case "Thêm phòng":
                    themPhongMoi1.Initialize();
                    QuanlyPagecontrol.SelectedPage = PageThemphongmoi;
                    break;
                case "Sửa phòng":
                    // suaKhachHang3.RefreshDataBinding((int)khachHang.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaKH"]);
                    suaPhong1.RefreshDataBinding((int)phong.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MaPhong"]);
                    QuanlyPagecontrol.SelectedPage = PageSuaphong;
                    break;
                case "Xóa":
                    //Thông báo xác nhận
                    //if (XtraMessageBox.Show("Bạn có chắc xóa khách hàng '" + gridView1.GetFocusedRowCellValue(colTenKH).ToString() + "' ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    //{

                    //    if (BUS.KhachHangBUS.XoaKhachHang((int)gridView1.GetFocusedRowCellValue(colMaKH)))
                    //    {

                    //        //Thông báo thành công/thất bại
                    //        XtraMessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                    //        RefreshDataBinding();
                    //    }
                    //    else
                    //        //Thông báo thành công/thất bại
                    //        XtraMessageBox.Show("Xóa khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK);
                    //}
                    break;
            }
        }


        public void RefreshDataBinding()
        {
        
            try
            {

                 gridControl.DataSource = phong = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();
                

                tileAll.Elements[1].Text = ((DataView)gridView1.DataSource).Count.ToString();

                grpLoaiPhong.Items.Clear();
                foreach (DataRow row in BUS.LoaiPhongBUS.LayTatCaLoaiPhong_DataTable().Rows)
                {
                    grpLoaiPhong.Items.Add(NewTileItem(row["TenLoaiPhong"].ToString()));
                }

            }
            catch (Exception x)
            {

            }
        }

        internal void GoToPage(int v)
        {
            QuanlyPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            QuanlyPagecontrol.SelectedPageIndex = v;
            QuanlyPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
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
            t.AppearanceItem.Selected.BackColor = System.Drawing.Color.RoyalBlue;
            t.AppearanceItem.Selected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            t.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            t.AppearanceItem.Selected.Options.UseBackColor = true;
            t.AppearanceItem.Selected.Options.UseFont = true;
            t.AppearanceItem.Selected.Options.UseForeColor = true;


            t.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            t.Name = name;
            t.Text = name;
            t.Checked = true;

            t.ItemClick += tileLoaiPhong_ItemClick;
            return t;
        }

        TileItem preSelect;
        private void tileControl2_ItemPress(object sender, TileItemEventArgs e)
        {

            switch (e.Item.Name)
            {
                case "tileAll":                   
                    preSelect = tileAll;
                    break;                
                default:
                    return;
            }


            //tileView1.ActiveFilterString = "[TenLoaiPhong] = 'VIP 1'";
        }


        private void tileLoaiPhong_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = (TileItem)sender;

            if (preSelect == null)
                tileControl2.SelectedItem = tileAll;
            else
                tileControl2.SelectedItem = preSelect;



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
                gridView1.ActiveFilterString = BUS.TinhTrangPhongBUS.GetFilterString_LoaiPhong(listLoaiPhongChecked);
            else
                gridView1.ActiveFilterString = "[TenLoaiPhong] = null";
        }

        #endregion

        private void QuanlyPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            RefreshDataBinding();
        }
    }
}
