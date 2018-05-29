﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {

        public static int PhatSinhMaHoaDon()
        {
            return DAL.HoaDonDAL.PhatSinhMaHoaDon();
        }

        public static bool LuuThongTinThuePhong(ThuePhongDTO thuePhongDTO, HoaDonDTO hoaDonDTO)
        {
            return HoaDonDAL.LuuThongTinHoaDon(hoaDonDTO) && ThuePhongBUS.LuuThongTinThuePhong(thuePhongDTO)  ;


        }
        public static HoaDonDTO LayThongTinHoaDonDangThue(int maHoaDon)
        {
            return DAL.HoaDonDAL.LayThongTinHoaDonDangThue(maHoaDon);
        }
    }
}
