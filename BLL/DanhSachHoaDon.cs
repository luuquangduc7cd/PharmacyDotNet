using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class DanhSachHoaDon
    {
        private TableHoaDon list;
        private TableChiTietHoaDon tblChiTietHoaDon;
        public DanhSachHoaDon()
        {
            list = new TableHoaDon();
            tblChiTietHoaDon = new TableChiTietHoaDon();
        }
        public bool ThemHoaDon(DTOHoaDon hoaDon)
        {
            return list.POST(hoaDon);
        }
        public bool XoaHoaDon(DTOHoaDon hoaDon)
        {
            if(tblChiTietHoaDon.DeleteByParentId(hoaDon.Id))
                return list.DELETE(hoaDon.Id);
            return false;
        }
        public bool CapNhatHoaDon(DTOHoaDon hoaDon)
        {
            return list.PUT(hoaDon);
        }
        public List<DTOHoaDon> TimKiem(int idKhach)
        {
            if (idKhach == -1)
                return list.GetAll();
            return list.GetHoaDonByKhachId(idKhach);
        }

        internal DTOHoaDon TimTheoObject(DTOHoaDon hoaDonTemp)
        {
            return list.GetHoaDonID(hoaDonTemp);
        }
    }
}
