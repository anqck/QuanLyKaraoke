using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.LoaiPhongDTO;

namespace DTO
{
    public class ThongTinThanhToanTheoNgay
    {
        public double TongThanhTien;
        public List<DonGiaTheoKhoangThoiGian> listDonGiaTheoKhoangThoiGian;
        public Ngay ngay;

        public ThongTinThanhToanTheoNgay()
        {
            TongThanhTien = 0;
            listDonGiaTheoKhoangThoiGian = new List<DonGiaTheoKhoangThoiGian>();
        }

        public class Gio
        {
            public int hour, minute, second;

            public Gio(int h, int m, int s)
            {
                hour = h;
                minute = m;
                second = s;
            }
            public Gio(DateTime dt)
            {
                hour = dt.Hour;
                minute = dt.Minute;
                second = dt.Second;
            }

            public Gio(TimeSpan dt)
            {
                hour = (int)dt.TotalHours;
                minute = dt.Minutes;
                second = dt.Seconds;
            }
            public void AddHour(int i)
            {
                hour += i;
            }
            public override string ToString()
            {
                return hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");
            }

            public static TimeSpan CalcTimeSpan(Gio gioBatDau, Gio gioKetThuc)
            {
                return (new DateTime(1,1, (gioKetThuc.hour == 24) ? 2 : 1, (gioKetThuc.hour==24)?0:gioKetThuc.hour, gioKetThuc.minute, gioKetThuc.second)) - (new DateTime(1, 1, 1, gioBatDau.hour, gioBatDau.minute, gioBatDau.second));
            }

        }

        public class Ngay
        {
            public string Thu;
            public Gio GioBatDau;
            public Gio GioKetThuc;
            public DateTime date;

            public Ngay(string ngayTrongTiengAnh, Gio gioBatDau, Gio gioKetThuc,DateTime dt)
            {
                SetNgayTrongTuan(ngayTrongTiengAnh);
                GioBatDau = gioBatDau;
                GioKetThuc = gioKetThuc;
                date = dt;
            }

           
            public void SetNgayTrongTuan(string ngayTrongTiengAnh)
            {
                switch (ngayTrongTiengAnh)
                {
                    case "Monday":
                        Thu = "Thứ 2";
                        break;
                    case "Tuesday":
                        Thu = "Thứ 3";
                        break;
                    case "Wednesday":
                        Thu = "Thứ 4";
                        break;
                    case "Thursday":
                        Thu = "Thứ 5";
                        break;
                    case "Friday":
                        Thu = "Thứ 6";
                        break;
                    case "Saturday":
                        Thu = "Thứ 7";
                        break;
                    case "Sunday":
                        Thu = "CN";
                        break;
                    case "Else":
                        Thu = "Ngày lễ";
                        break;
                }
            }
        }
    }
}
