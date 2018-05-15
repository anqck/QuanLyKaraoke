using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.ThongTinThanhToanTheoNgay;

namespace DTO
{
    public class LoaiPhongDTO
    {
        public class DonGiaTheoKhoangThoiGian
        {           
            public Gio GioBatDau;
            public Gio GioKetThuc;
            public double DonGia; 


            public DonGiaTheoKhoangThoiGian(Gio gioBD,Gio gioKT,double donGia)
            {
                GioBatDau = gioBD;
                GioKetThuc = gioKT;
                DonGia = donGia;
            }
        }

        public class DonGiaTheoTuan
        {
            public int MaLoaiPhong;
            public List<DonGiaTheoNgay> listDonGiaTheoNgay;
            public DonGiaTheoTuan()
            {
                MaLoaiPhong = 0;
                listDonGiaTheoNgay = new List<DonGiaTheoNgay>();
            }
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

            public void SetNgayTrongTuan(int i)
            {
                switch(i)
                {
                    case 0:
                        NgayTrongTuan = "Thứ 2";
                        break;
                    case 1:
                        NgayTrongTuan = "Thứ 3";
                        break;
                    case 2:
                        NgayTrongTuan = "Thứ 4";
                        break;
                    case 3:
                        NgayTrongTuan = "Thứ 5";
                        break;
                    case 4:
                        NgayTrongTuan = "Thứ 6";
                        break;
                    case 5:
                        NgayTrongTuan = "Thứ 7";
                        break;
                    case 6:
                        NgayTrongTuan = "CN";
                        break;
                    case 7:
                        NgayTrongTuan = "Ngày lễ";
                        break;
                }
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
