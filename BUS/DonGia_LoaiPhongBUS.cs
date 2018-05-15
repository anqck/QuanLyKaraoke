using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonGia_LoaiPhongBUS
    {
        public static int PhatSinhMaDonGia_LoaiPhong()
        {
            return DAL.DonGia_LoaiPhongDAL.PhatSinhMaDonGia_LoaiPhong();
        }
        public static bool ThemDonGiaTheoKhoangThoiGian(LoaiPhongDTO.DonGiaTheoTuan donGiaNgay)
        {
            return DAL.DonGia_LoaiPhongDAL.ThemDonGiaTheoKhoangThoiGian(donGiaNgay);
        }
    }
}
