using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class NhanVienDAL
    {
        public static int PhatSinhMaNhanVien()
        {
            DataTable dt = DataProvider.ExecuseQuery("SELECT quanlykaraoke.NhanVien.MaNhanVien FROM quanlykaraoke.NhanVien ORDER BY quanlykaraoke.NhanVien.MaNhanVien DESC LIMIT 1;");
            if (dt.Rows.Count == 0)
                return 1;
            else
                return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }

        public static bool LuuThongTinNhanVien(NhanVienDTO NhanVienDTO)
        {
            try
            {
                StringBuilder strSQL = new StringBuilder("INSERT INTO `quanlykaraoke`.`nhanvien` (`MaNhanVien`, `TenNhanVien`, `DiaChi`, `SDT`, `TenDangNhap`, `MatKhau`, `MaLoaiTaiKhoan`, `HinhAnh`) VALUES (@0, @1, @2, @3, @4, @5, @6,@7); ");

                //strSQL.Replace("$0", NhanVienDTO.MaNhanVien.ToString());
                //strSQL.Replace("$1", NhanVienDTO.TenNhanVien.ToString());
                //strSQL.Replace("$2", NhanVienDTO.DiaChi.ToString());
                //strSQL.Replace("$3", NhanVienDTO.SDT.ToString());
                //strSQL.Replace("$4", NhanVienDTO.TenDangNhap.ToString());
                //strSQL.Replace("$5", NhanVienDTO.MatKhau.ToString());
                //strSQL.Replace("$6", NhanVienDTO.MaLoaiTaiKhoan.ToString());


                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(NhanVienDTO.HinhAnh, typeof(byte[]));

                //strSQL.Replace("@5", arr.ToString());



                MySqlTransaction transaction = null; //wherever you get the transaction obj from.

                var MaNhanVien = new MySqlParameter("@0", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.MaNhanVien
                };
                var TenNhanVien = new MySqlParameter("@1", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.TenNhanVien
                };
                var DiaChi = new MySqlParameter("@2", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.DiaChi
                };
                var SDT = new MySqlParameter("@3", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.SDT
                };
                var TenDangNhap = new MySqlParameter("@4", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.TenDangNhap
                };
                var MatKhau = new MySqlParameter("@5", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.MatKhau
                };
                var MaLoaiTaiKhoan = new MySqlParameter("@6", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.MaLoaiTaiKhoan
                };

                var byteParam = new MySqlParameter("@7", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = arr.Length,
                    Value = arr
                }; //change the data type to whatever data type you are expecting

                DAL.DataProvider.getConnection().Open();
                MySqlHelper.ExecuteNonQuery(DAL.DataProvider.getConnection(), strSQL.ToString(), MaNhanVien, TenNhanVien, DiaChi, SDT, TenDangNhap,MatKhau,MaLoaiTaiKhoan, byteParam);
                DAL.DataProvider.getConnection().Close();
                //DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static List<LoaiTaiKhoanDTO> LayTatCaLoaiTaiKhoan_List()
        {
            List<LoaiTaiKhoanDTO> res = new List<LoaiTaiKhoanDTO>();

            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaitaikhoan;");
            foreach (DataRow row in dt.Rows)
            {
                res.Add(new LoaiTaiKhoanDTO(Convert.ToInt32(row["MaLoaiTaiKhoan"]), row["TenLoaiTaiKhoan"].ToString()));
            }

            return res;
        }

        public static DataTable LayTatCaNhanVien_LoaiTaiKhoan()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.NhanVien, quanlykaraoke.loaitaikhoan where quanlykaraoke.NhanVien.MaLoaiTaiKhoan = quanlykaraoke.loaitaikhoan.MaLoaiTaiKhoan ;");
        }
        public static DataTable LayTatCaLoaiTaiKhoan()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.loaitaikhoan ;");
        }

        public static NhanVienDTO LayNhanVien(int MaNhanVien)
        {
            DataTable dt = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.NhanVien WHERE MaNhanVien = '" + MaNhanVien.ToString() + "';");

            return new NhanVienDTO((int)dt.Rows[0]["MaNhanVien"], dt.Rows[0]["TenNhanVien"].ToString(), dt.Rows[0]["DiaChi"].ToString(), dt.Rows[0]["SDT"].ToString(), dt.Rows[0]["TenDangNhap"].ToString(), dt.Rows[0]["MatKhau"].ToString(), (int)dt.Rows[0]["MaLoaiTaiKhoan"], (byte[])dt.Rows[0]["HinhAnh"]);

        }
        public static bool CapNhatThongTinNhanVien(NhanVienDTO NhanVienDTO)
        {
            
            try
            {
                // StringBuilder strSQL1 = new StringBuilder("UPDATE quanlykaraoke.dichvu SET  TenDV = @1,DonGia = @2, DonVi = @3,MaLDV = @4, HinhAnhDV = @5   WHERE MaDV = @0");
                StringBuilder strSQL = new StringBuilder("UPDATE `quanlykaraoke`.`nhanvien` SET  `TenNhanVien`=@1, `DiaChi`=@2, `SDT`=@3, `TenDangNhap`=@4, `MatKhau`= @5,`MaLoaiTaiKhoan`= @6, `HinhAnh` = @7 WHERE `MaNhanVien`= @0;");
                                                        
                //strSQL.Replace("$0", NhanVienDTO.MaNhanVien.ToString());
                //strSQL.Replace("$1", NhanVienDTO.TenNhanVien.ToString());
                //strSQL.Replace("$2", NhanVienDTO.DiaChi.ToString());
                //strSQL.Replace("$3", NhanVienDTO.SDT.ToString());
                //strSQL.Replace("$4", NhanVienDTO.TenDangNhap.ToString());
                //strSQL.Replace("$5", NhanVienDTO.MatKhau.ToString());
                //strSQL.Replace("$6", NhanVienDTO.MaLoaiTaiKhoan.ToString());
                // Console.WriteLine(strSQL);


                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(NhanVienDTO.HinhAnh, typeof(byte[]));

                //strSQL.Replace("@5", arr.ToString());



                MySqlTransaction transaction = null; //wherever you get the transaction obj from.

                var MaNhanVien = new MySqlParameter("@0", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.MaNhanVien
                };
                var TenNhanVien = new MySqlParameter("@1", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.TenNhanVien
                };
                var DiaChi = new MySqlParameter("@2", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.DiaChi
                };
                var SDT = new MySqlParameter("@3", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.SDT
                };
                var TenDangNhap = new MySqlParameter("@4", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.TenDangNhap
                };
                var MatKhau = new MySqlParameter("@5", MySqlDbType.VarChar)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.MatKhau
                };
                var MaLoaiTaiKhoan = new MySqlParameter("@6", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = NhanVienDTO.MaLoaiTaiKhoan
                };

                var byteParam = new MySqlParameter("@7", MySqlDbType.VarBinary)
                {
                    Direction = ParameterDirection.Input,
                    Size = arr.Length,
                    Value = arr
                }; //change the data type to whatever data type you are expecting

                DAL.DataProvider.getConnection().Open();
                MySqlHelper.ExecuteNonQuery(DAL.DataProvider.getConnection(), strSQL.ToString(), MaNhanVien, TenNhanVien, DiaChi, SDT, TenDangNhap, MatKhau, MaLoaiTaiKhoan, byteParam);
                DAL.DataProvider.getConnection().Close();
                //DAL.DataProvider.ExecuseNonQuery(strSQL.ToString());

                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
       
        public static DataTable LayTatCaNhanVien_DataTable()
        {
            return DAL.DataProvider.ExecuseQuery("SELECT * FROM NhanVien;");
        }
       
    }
}
