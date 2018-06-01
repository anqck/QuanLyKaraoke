using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static Dictionary<string, LoaiPhongDTO.DonGiaTheoNgay> LayDonGia(LoaiPhongDTO loaiPhongDTO)
        {
            return DAL.DonGia_LoaiPhongDAL.LayDonGia(loaiPhongDTO);
        }

        public static DataTable LayTatCaDonGia_DataTable()
        {
            return DAL.DonGia_LoaiPhongDAL.LayTatCaDonGia_DataTable();
        }
        public static bool XoaCacDonGiaPhong(LoaiPhongDTO loaiPhongDTO)
        {
            return DAL.DonGia_LoaiPhongDAL.XoaCacDonGiaPhong(loaiPhongDTO);
        }
    }
}
