using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOHoaDonKhach
    {
        private int id;
        private string ngayLap;
        private string khach;
        private string tong;

        public DTOHoaDonKhach(int id, string ngayLap, string khach, string tong)
        {
            this.Id = id;
            this.NgayLap = ngayLap;
            this.Khach = khach;
            this.Tong = tong;
        }

        public int Id { get => id; set => id = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string Khach { get => khach; set => khach = value; }
        public string Tong { get => tong; set => tong = value; }
    }
}
