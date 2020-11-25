using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    class DanhSachThuoc
    {
        private TableThuoc tblThuoc;
        public DanhSachThuoc()
        {
            tblThuoc = new TableThuoc();
        }

        public bool ThemThuoc(DTOThuoc thuoc)
        {
            return tblThuoc.POST(thuoc);
        }
        public bool XoaThuoc(int id)
        {
            return tblThuoc.DELETE(id);
        }

        public bool CapNhat(DTOThuoc thuoc)
        {
            return tblThuoc.PUT(thuoc);
        }

        public List<DTOThuoc> TimKiem(string ten)
        {
            List<DTOThuoc> list = new List<DTOThuoc>();
            if (string.IsNullOrEmpty(ten))
                list = tblThuoc.GetAll();
            else
                list = tblThuoc.GetByTenThuoc(ten);
            return list;
        }

    }
}
