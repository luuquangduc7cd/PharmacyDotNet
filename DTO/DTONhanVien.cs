using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTONhanVien
    {
        private int id;
        private string ten;
        private string password;
        private string usr;
        public DTONhanVien()
        {

        }

        public DTONhanVien(int id, string ten, string password, string usr)
        {
            this.id = id;
            this.ten = ten;
            this.password = password;
            this.Usr = usr;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Password { get => password; set => password = value; }
        public string Usr { get => usr; set => usr = value; }
    }
}
