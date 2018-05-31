﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuPhongBUS
    {
        public static int PhatSinhMaDichVuPhong()
        {
            return DichVuPhongDAL.PhatSinhMaDichVuPhong();
        }

        public static bool LuuThongTinDichVuPhong(DichVuPhongDTO dichVuPhongDTO)
        {
            return DichVuPhongDAL.LuuThongTinDichVuPhong(dichVuPhongDTO);
        }

        public static DataTable LayTatCaDichVuPhong_DichVu(ThuePhongDTO thuePhongDTO)
        {
            return DichVuPhongDAL.LayTatCaDichVuPhong_DichVu_LoaiDV(thuePhongDTO);
        }
        public static void UpdateDichVuPhong(DichVuPhongDTO dichVuPhongDTO)
        {
            DichVuPhongDAL.UpdateDichVuPhong(dichVuPhongDTO);
        }
        public static bool XoaDichVuPhong(int maDVP)
        {
            return DichVuPhongDAL.XoaDichVuPhong(maDVP);
        }
    }
}