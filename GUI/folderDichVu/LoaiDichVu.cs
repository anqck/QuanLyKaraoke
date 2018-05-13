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

namespace GUI.folderDichVu
{
    public partial class LoaiDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet dataset;
        DataTable dtLoaiDichVu;
        DataTable dtDichVu;

        public LoaiDichVu()
        {
            InitializeComponent();

            
        }
        public void RefreshDataBinding()
        {
            //try
            //{
                dtLoaiDichVu = BUS.LoaiDichVuBUS.LayTatCaLoaiDichVu_DataTable();
                dtDichVu = BUS.DichVuBUS.LayTatCaDichVu_DataTable();

                dataset = new DataSet();
                dataset.Tables.Add(dtLoaiDichVu);
                dataset.Tables.Add(dtDichVu);

                dataset.Relations.Add("ThongTinChiTietDichVu", dataset.Tables["loaidichvu"].Columns["MaLDV"], dataset.Tables["dichvu"].Columns["MaLDV"]);

                gridControl1.DataSource = dataset.Tables["loaidichvu"];
                gridControl1.LevelTree.Nodes.Add("ThongTinChiTietDichVu", cardView1);


            //}
            //catch (Exception x)
            //{

            //}
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == 0 || e.FocusedRowHandle == 1)
            {
                wbntSuadichvu.Buttons[1].Properties.Enabled = false;
                wbntSuadichvu.Buttons[2].Properties.Enabled = false;
            }
            else
            {
                wbntSuadichvu.Buttons[2].Properties.Enabled = true;
                wbntSuadichvu.Buttons[2].Properties.Enabled = false;
            }
        }

        private void wbntSuadichvu_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case "Thêm Loại Dịch Vụ":

                    break;
                case "Sửa Loại Dịch Vụ":

                    break;
                case "Xóa Loại Dịch Vụ":

                    break;
            }
        }
    }
}
