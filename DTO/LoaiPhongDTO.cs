﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhongDTO
    {
        public struct DonGiaTheoKhoangThoiGian
        {           
            public int GioBatDau;
            public int GioKetThuc;
            public double DonGia; 
        }
        

        public class DonGiaTheoNgay
        {
            public string NgayTrongTuan;
            public List<DonGiaTheoKhoangThoiGian> listDonGiaTheoKhoangThoiGian;
            public DonGiaTheoNgay()
           {
                NgayTrongTuan = "";
                listDonGiaTheoKhoangThoiGian = new List<DonGiaTheoKhoangThoiGian>();
           }
        }


        public int MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }

        public LoaiPhongDTO(int maLoaiPhong, string tenLoaiPhong)
        {
            MaLoaiPhong = maLoaiPhong;
            TenLoaiPhong = tenLoaiPhong;
        }
    }
}
