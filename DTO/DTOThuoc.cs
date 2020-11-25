using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOThuoc
    {
		private int _id;
		private string _ten;
		private string _donVi;
		private int _donGia;
		private int _soLuong;
		private string _nhaCungCap;
		private string _hanSuDung;
		private int _idNhanVien;

        public DTOThuoc()
        {
        }

        public DTOThuoc(int id, string ten, string donVi, int donGia, int soLuong, string nhaCungCap, string hanSuDung, int idNhanVien)
        {
            _id = id;
            _ten = ten;
            _donVi = donVi;
            _donGia = donGia;
            _soLuong = soLuong;
            _nhaCungCap = nhaCungCap;
            _hanSuDung = hanSuDung;
            _idNhanVien = idNhanVien;
        }

        public int Id { get => _id; set => _id = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string DonVi { get => _donVi; set => _donVi = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string NhaCungCap { get => _nhaCungCap; set => _nhaCungCap = value; }
        public string HanSuDung { get => _hanSuDung; set => _hanSuDung = value; }
        public int IdNhanVien { get => _idNhanVien; set => _idNhanVien = value; }
    }
}
