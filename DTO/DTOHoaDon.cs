using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHoaDon
    {
        private int _id;
        private string _ngayLap;
        private int _idKhach;
        private int _idNhanVien;
        private string _tongTien;
        public DTOHoaDon() { }

        public DTOHoaDon(int id, string ngayLap, int idKhach, int idNhanVien, string tongTien)
        {
            Id = id;
            NgayLap = ngayLap;
            IdKhach = idKhach;
            IdNhanVien = idNhanVien;
            TongTien = tongTien;
        }

    public int Id { get => _id; set => _id = value; }
    public string NgayLap { get => _ngayLap; set => _ngayLap = value; }
    public int IdKhach { get => _idKhach; set => _idKhach = value; }
    public int IdNhanVien { get => _idNhanVien; set => _idNhanVien = value; }
    public string TongTien { get => _tongTien; set => _tongTien = value; } 
    }
}
