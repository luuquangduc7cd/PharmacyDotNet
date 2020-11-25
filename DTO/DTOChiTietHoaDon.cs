using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOChiTietHoaDon
    {
		private int _id;
		private int _idHoaDon;
		private int _idThuoc;
		private int _soLuong;

        public DTOChiTietHoaDon() { }

        public DTOChiTietHoaDon(int id, int idHoaDon, int idThuoc, int soLuong)
        {
            Id = id;
            IdHoaDon = idHoaDon;
            IdThuoc = idThuoc;
            SoLuong = soLuong;
        }

        public int Id { get => _id; set => _id = value; }
        public int IdHoaDon { get => _idHoaDon; set => _idHoaDon = value; }
        public int IdThuoc { get => _idThuoc; set => _idThuoc = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
