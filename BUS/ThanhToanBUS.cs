using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.LoaiPhongDTO;
using static DTO.ThongTinThanhToanTheoNgay;

namespace BUS
{
    public class ThanhToanBUS
    {
        public struct ThongTinThanhToan
        {
            public List<ThongTinThanhToanTheoNgay> listThongTin;
           public double TongThanhTien;
        }
       

      
        public static ThongTinThanhToan TinhTienThuePhong(ThuePhongDTO thuePhongDTO, DateTime gioKetThuc)
        {
            ThongTinThanhToan thongTinThanhToan = new ThongTinThanhToan();
            List<ThongTinThanhToanTheoNgay> res = new List<ThongTinThanhToanTheoNgay>();

            int maLoaiPhong = PhongBUS.LayThongTinPhong(thuePhongDTO.MaPhong).MaLoaiPhong;
            //ThuePhongDTO thuePhongDTO = ThuePhongBUS.LayThongTinPhongDangThue(phong);

            List<Ngay> listNgay = new List<Ngay>();
            for (var day = thuePhongDTO.GioThuePhong.Date; day.Date <= gioKetThuc.Date; day = day.AddDays(1))
            {
                if(thuePhongDTO.GioThuePhong.Date == gioKetThuc.Date)
                {
                    listNgay.Add(new Ngay(day.DayOfWeek.ToString(), new Gio(thuePhongDTO.GioThuePhong), new Gio(gioKetThuc),day));
                    break;
                }

                if(listNgay.Count == 0)
                {
                    listNgay.Add(new Ngay(day.DayOfWeek.ToString(), new Gio(thuePhongDTO.GioThuePhong),  new Gio(24,0,0), day));
                }
                else if(day.AddDays(1) <= DateTime.Now.Date)
                {
                    listNgay.Add(new Ngay(day.DayOfWeek.ToString(), new Gio(0, 0, 0), new Gio(24, 0, 0), day));
                }
                else
                {
                    listNgay.Add(new Ngay(day.DayOfWeek.ToString(), new Gio(0, 0, 0), new Gio(gioKetThuc), day));
                }
               
            }


            for(int i = 0; i < listNgay.Count; i++)
            {
                res.Add(TinhTienTheoNgay(listNgay[i], maLoaiPhong));
                thongTinThanhToan.TongThanhTien += res[i].TongThanhTien;
            }


            thongTinThanhToan.listThongTin = res;
 
            return thongTinThanhToan;
        }

        public static ThongTinThanhToanTheoNgay TinhTienTheoNgay(Ngay ngay,int maLoaiPhong)
        {
            ThongTinThanhToanTheoNgay res = new ThongTinThanhToanTheoNgay();
            
            res.listDonGiaTheoKhoangThoiGian.AddRange(ThanhToanDAL.LayDonGiaMaGioBatDauVaGioKetThucNamTrong(ngay, maLoaiPhong));
            if(res.listDonGiaTheoKhoangThoiGian.Count == 0)
            {
                res.listDonGiaTheoKhoangThoiGian.AddRange(ThanhToanDAL.LayTatCaCacDonGiaNamTrongKhoang(ngay, maLoaiPhong));
                res.listDonGiaTheoKhoangThoiGian.AddRange(ThanhToanDAL.LayDonGiaMaGioBatDauNamTrong(ngay, maLoaiPhong));
                res.listDonGiaTheoKhoangThoiGian.AddRange(ThanhToanDAL.LayDonGiaMaGiaKetThucNamTrong(ngay, maLoaiPhong));
            }
            

            
            foreach (DonGiaTheoKhoangThoiGian donGia_KhoangTG in res.listDonGiaTheoKhoangThoiGian)
            {
                res.TongThanhTien += Gio.CalcTimeSpan(donGia_KhoangTG.GioBatDau, donGia_KhoangTG.GioKetThuc).TotalHours * donGia_KhoangTG.DonGia;
            }
            res.ngay = ngay;

            return res;
        }


    }
}
