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

namespace GUI.TinhTrangPhong
{
    public partial class TinhTrangPhong : DevExpress.XtraEditors.XtraUserControl
    {
        public TinhTrangPhong()
        {
            InitializeComponent();
          


        }


        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
         
            if (e.Button.Equals(this.wbntTinhtrangphong.Buttons[0] ))
            {
                this.TinhtrangPagecontrol.SelectedPageIndex = 1;
            }
        }

        private void windowsUIButtonPanel2_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(this.wbntBack.Buttons[0]))
            {
                this.TinhtrangPagecontrol.SelectedPageIndex = 0;
            }
        }


        public void RefreshDataBinding()
        {
            try
            {
                gridControl.DataSource = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();

                tileAll.Elements[1].Text = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong().Rows.Count.ToString();

                grpLoaiPhong.Items.Clear();
                foreach (DataRow row in DAL.LoaiPhongDAL.LayTatCaLoaiPhong().Rows)
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
                    tileView1.ActiveFilterEnabled = false;
                    preSelect = tileAll;
                    break;
                case "tileAvailable":
                    preSelect = tileAvailable;
                    break;
                case "tileRented":
                    preSelect = tileRented;
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
                tileView1.ActiveFilterString = BUS.TinhTrangPhongBUS.GetFilterString_LoaiPhong(listLoaiPhongChecked);
            else
                tileView1.ActiveFilterString = "[TenLoaiPhong] = null";
        }

        #endregion
    }
}
