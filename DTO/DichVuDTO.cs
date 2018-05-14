using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDTO
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }

        public double DonGia { get; set; }

        public string DonVi { get; set; }

        public Image HinhAnh { get; set; }
        public int MaLoaiDV { get; set; }
        
        public DichVuDTO(int maDV, string tenDV, double donGia, string donVi, byte[] hinhAnh, int maLoaiDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            DonGia = donGia;
            DonVi = donVi;
            MaLoaiDV = maLoaiDV;

            SetHinhAnh(hinhAnh);
        }

        public DichVuDTO(int maDV, string tenDV, double donGia, string donVi, Image hinhAnh, int maLoaiDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            DonGia = donGia;
            DonVi = donVi;
            MaLoaiDV = maLoaiDV;

            HinhAnh = hinhAnh;
        }

        public void SetHinhAnh(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            HinhAnh = returnImage;
        }
    }
}
