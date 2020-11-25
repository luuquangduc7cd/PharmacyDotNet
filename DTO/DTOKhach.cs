using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOKhach
    {
		private int id;
		private string ten;
		private string sdt;
		private string diaChi;

        public DTOKhach() { }
        public DTOKhach(int id, string ten, string sdt, string diaChi)
        {
            this.id = id;
            this.ten = ten;
            this.sdt = sdt;
            this.diaChi = diaChi;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
