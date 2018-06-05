using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuDatPhongBUS
    {
        public static int PhatSinhMaDichVuPhong()
        {
            return DAL.DichVuDatPhongDAL.PhatSinhMaDichVuPhong();
        }

        public static bool LuuThongTinDichVuDatPhong(DichVuDatPhongDTO dichVuPhongDTO)
        {


            return DAL.DichVuDatPhongDAL.LuuThongTinDichVuDatPhong(dichVuPhongDTO);
        }

        public static bool UpdateDichVuDatPhong(DichVuDatPhongDTO dichVuDatPhongDTO)
        {

            return DAL.DichVuDatPhongDAL.UpdateDichVuDatPhong(dichVuDatPhongDTO);
        }

        public static bool XoaDichVuDatPhong(int maDVP)
        {
            return DAL.DichVuDatPhongDAL.XoaDichVuDatPhong(maDVP);
        }

        public static DataTable LayTatCaDichVuDatPhong_DichVu_LoaiDV(ChiTietDatPhongDTO chiTietDatPhong)
        {
            return DAL.DichVuDatPhongDAL.LayTatCaDichVuDatPhong_DichVu_LoaiDV(chiTietDatPhong);
        }
    }
}
