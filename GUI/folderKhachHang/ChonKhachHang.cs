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

namespace GUI.folderKhachHang
{
    public partial class ChonKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable gridDataSource;
        bool VisibleVangLai ;
        public ChonKhachHang(bool VisibleVangLai = true)
        {
            InitializeComponent();

            gridDataSource = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();

            if (!VisibleVangLai)
                gridDataSource.Rows.RemoveAt(0);

            gridControl1.DataSource = gridDataSource;

     
            searchControl1.Client = gridControl1;

            btnThemKH.Enabled = false;
        }

        internal KhachHangDTO LayKhachHangDaChon()
        {
            int idxSelectedRow = gridView1.GetFocusedDataSourceRowIndex();
            return new KhachHangDTO((int)gridDataSource.Rows[idxSelectedRow]["MaKH"], gridDataSource.Rows[idxSelectedRow]["TenKH"].ToString(), gridDataSource.Rows[idxSelectedRow]["Email"].ToString(), gridDataSource.Rows[idxSelectedRow]["SDT"].ToString(), gridDataSource.Rows[idxSelectedRow]["DiaChi"].ToString(), (int)gridDataSource.Rows[idxSelectedRow]["MaLoaiKH"], (double)gridDataSource.Rows[idxSelectedRow]["DiemTichLuy"], (gridDataSource.Rows[idxSelectedRow]["NgaySinh"].ToString() == "") ? (DateTime.MinValue) : ((DateTime)gridDataSource.Rows[idxSelectedRow]["NgaySinh"]));
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (BUS.KhachHangBUS.LuuThongTinKH(new KhachHangDTO(BUS.KhachHangBUS.PhatSinhMaKH(), txtTenKH.Text, "", txtSDT.Text,"", 1, 0, new DateTime())))
            {
                //Thông báo thành công

                XtraMessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridDataSource = BUS.KhachHangBUS.LayTatCaKhachHang_LoaiKhachHang();

                if (!VisibleVangLai)
                    gridDataSource.Rows.RemoveAt(0);

                gridControl1.DataSource = gridDataSource;
            }
        }

        private void txtTenKH_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTenKH.EditValue.ToString() == "")
            {
                btnThemKH.Enabled = false;
                txtTenKH.ErrorText = "Tên khách hàng không được để trống";
            }
                
            else
            {
                btnThemKH.Enabled = true;
                txtTenKH.ErrorText = "";
            }
        }
    }
}
