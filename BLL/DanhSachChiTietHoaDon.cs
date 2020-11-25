using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class DanhSachChiTietHoaDon
    {
        public TableChiTietHoaDon list;
        public DanhSachChiTietHoaDon()
        {
            list = new TableChiTietHoaDon();
        }
        public bool ThemChiTietHoaDon(DTOChiTietHoaDon cthd)
        {
            return list.POST(cthd);
        }
        public bool XoaChiTietHoaDonBy(DTOChiTietHoaDon cthd)
        {
            return list.POST(cthd);
        }

        internal bool XoaCTHDByIdHoaDon(int id)
        {
            return list.DeleteByParentId(id);
        }
    }
}
