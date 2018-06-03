using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhachHangDTO
    {

        public int MaLoaiKH { get; set; }
        public string TenLoaiKH { get; set; }
        public int SoDiemDeDatDuoc { get; set; }

        public double PhanTramGiamGia { get; set; }
        public double SoTienGiamGia_Max { get; set; }
        public double SoTienGiamGia_Min { get; set; }

        public double PhanTramGiamGiaSinhNhat { get; set; }
        public double SoTienGiamGiaSinhNhat_Max { get; set; }
        public double SoTienGiamGiaSinhNhat_Min { get; set; }


        public LoaiKhachHangDTO(int maLoaiKH, string tenLoaiKH, int SoDiemDeDatDuoc, double PhanTramGiamGia, double SoTienGiamGia_Min, double SoTienGiamGia_Max, double PhanTramGiamGiaSinhNhat, double SoTienGiamGiaSinhNhat_Min, double SoTienGiamGiaSinhNhat_Max)
        {
            this.MaLoaiKH = maLoaiKH;
            this.TenLoaiKH = tenLoaiKH;
            this.SoDiemDeDatDuoc = SoDiemDeDatDuoc;
            this.PhanTramGiamGia = PhanTramGiamGia;
            this.SoTienGiamGia_Max = SoTienGiamGia_Max;
            this.SoTienGiamGia_Min = SoTienGiamGia_Min;
            this.PhanTramGiamGiaSinhNhat = PhanTramGiamGiaSinhNhat;
            this.SoTienGiamGiaSinhNhat_Max = SoTienGiamGiaSinhNhat_Max;
            this.SoTienGiamGiaSinhNhat_Min = SoTienGiamGiaSinhNhat_Min;
        }

    }
}
