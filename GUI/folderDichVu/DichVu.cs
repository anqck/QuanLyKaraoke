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

namespace GUI.folderDichVu
{
    public partial class DichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public DichVu()
        {
            InitializeComponent();
        }

        private void wbntDichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Equals(wbntDichvu.Buttons[0]))
            {
                themDichVu1.Initialize();
                this.DichVuPagecontrol.SelectedPage = PageThemdichvu;
            }
            if (e.Button.Equals(wbntDichvu.Buttons[1]))
            {
                this.DichVuPagecontrol.SelectedPage = PageSuadichvu;
            }
            if (e.Button.Equals(wbntDichvu.Buttons[3]))
            {
                this.DichVuPagecontrol.SelectedPage = PageLoaidichvu;
            }
            if (e.Button.Equals(wbntDichvu.Buttons[4]))
            {
                this.DichVuPagecontrol.SelectedPage = PageThemloaidichvu;
            }
        }

        private void wbntBack_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            this.DichVuPagecontrol.SelectedPage = PageDichvu;
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

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



            t.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            t.Name = name;
            t.Text = name;
            //t.Checked = true;

            t.ItemClick += tileLoaiDichVu_ItemClick;
            return t;
        }

        private void tileLoaiDichVu_ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem tileItem = (TileItem)sender;

        }

        public void RefreshDataBinding()
        {
            try
            {
                gridControl1.DataSource = DAL.PhongDAL.LayTatCaPhong_TinhTrangPhong_LoaiPhong();

           

                grpLoaiDichVu.Items.Clear();
                foreach (LoaiDichVuDTO loaiDV in BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_List())
                {
                    grpLoaiDichVu.Items.Add(NewTileItem(loaiDV.TenDV.ToString()));

                }

               

            }
            catch (Exception x)
            {

            }
        }

        internal void GoToPage(int v)
        {
            DichVuPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            DichVuPagecontrol.SelectedPageIndex = v;
            DichVuPagecontrol.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
        }

        private void DichVuPagecontrol_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if(e.Page == PageLoaidichvu)
            {
                loaiDichVu1.RefreshDataBinding();
                return;
            }

            if(e.Page == PageDichvu)
            {
                this.RefreshDataBinding();
                return;
            }
        }
    }
}
