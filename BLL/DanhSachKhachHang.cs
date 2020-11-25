using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    class DanhSachKhachHang
    {
        private TableKhach tblKhach;
        public DanhSachKhachHang()
        {
            tblKhach = new TableKhach();
        }
        public bool ThemKhach(DTOKhach khach)
        {
            return tblKhach.POST(khach);
        }
        public bool XoaKhach(int id)
        {
            return tblKhach.DELETE(id);
        }
        public bool CapNhat(DTOKhach khach)
        {
            return tblKhach.PUT(khach);
        }
        public List<DTOKhach> TimKiem(string ten)
        {
            if (string.IsNullOrEmpty(ten))
                return tblKhach.GetAll();
            return tblKhach.GetByTenKhach(ten);
        }
        public DTOKhach TimTheoSdt(string sdt)
        {
            string data = sdt.Trim();
            return tblKhach.GetBySdt(sdt);
        }
    }
}
