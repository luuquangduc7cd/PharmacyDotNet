using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhanVien
    {
        private DTONhanVien dataNhanVien;
        private TableNhanVien tblNhanVien;
        private DanhSachThuoc listThuoc;
        private DanhSachKhachHang listKhachHang;
        private DanhSachChiTietHoaDon listChiTietHoaDon;
        private DanhSachHoaDon listHoaDon;
        private DanhSachHoaDonKhach listHoaDonKhach;
        public NhanVien()
        {
            dataNhanVien = new DTONhanVien();
            tblNhanVien = new TableNhanVien();
            listThuoc = new DanhSachThuoc();
            listKhachHang = new DanhSachKhachHang();
            listChiTietHoaDon = new DanhSachChiTietHoaDon();
            listHoaDon = new DanhSachHoaDon();
            listHoaDonKhach = new DanhSachHoaDonKhach();
        }
        public NhanVien(DTONhanVien dTONhanVien)
        {
            dataNhanVien = dTONhanVien;
            tblNhanVien = new TableNhanVien();
            listThuoc = new DanhSachThuoc();
            listKhachHang = new DanhSachKhachHang();
            listChiTietHoaDon = new DanhSachChiTietHoaDon();
            listHoaDon = new DanhSachHoaDon();
            listHoaDonKhach = new DanhSachHoaDonKhach();
        }
        public NhanVien(string username, string password)
        {
            dataNhanVien = new DTONhanVien();
            tblNhanVien = new TableNhanVien();
            listThuoc = new DanhSachThuoc();
            listKhachHang = new DanhSachKhachHang();
            listChiTietHoaDon = new DanhSachChiTietHoaDon();
            listHoaDon = new DanhSachHoaDon();
            listHoaDonKhach = new DanhSachHoaDonKhach();
            dataNhanVien.Usr = username;
            dataNhanVien.Password = password;
        }

        public DTONhanVien DataNhanVien { get => dataNhanVien; }

        public bool DangNhap()
        {
            DTONhanVien temp = tblNhanVien.GET(dataNhanVien);
            if(temp != null)
            {
                dataNhanVien = temp;
                return true;
            }
            return false;
        }

        public bool ThemThuoc(DTOThuoc thuoc)
        {
            return listThuoc.ThemThuoc(thuoc);
        }
        public List<DTOThuoc> TimKiemThuoc(string tenThuoc)
        {
            return listThuoc.TimKiem(tenThuoc);
        }
        public bool XoaThuoc(DTOThuoc thuoc)
        {
            return listThuoc.XoaThuoc(thuoc.Id);
        }
        public bool CapNhatThuoc(DTOThuoc thuoc)
        {
            return listThuoc.CapNhat(thuoc);
        }

        public bool ThemKhach(DTOKhach khach)
        {
            return listKhachHang.ThemKhach(khach);
        }
        public bool XoaKhach(int id)
        {
            List<DTOHoaDon> listTemp = listHoaDon.TimKiem(id);
            foreach(DTOHoaDon i in listTemp)
            {
                listChiTietHoaDon.XoaCTHDByIdHoaDon(id);
                listHoaDon.XoaHoaDon(i);
            }
            return listKhachHang.XoaKhach(id);
        }
        public bool CapNhatKhach(DTOKhach khach)
        {
            return listKhachHang.CapNhat(khach);
        }
        public List<DTOKhach> TimKhach(string ten)
        {
            return listKhachHang.TimKiem(ten);
        }
        public DTOKhach TimTheoSdt(string sdt)
        {
            string temp = sdt.Trim();
            return listKhachHang.TimTheoSdt(temp);
        }
        public bool NhapHoaDon(DTOKhach khach, DTOHoaDon hoaDon, List<DTOChiTietHoaDon> list)
        {
            bool test = true;
            DTOKhach khachTemp = listKhachHang.TimTheoSdt(khach.Sdt);
            if (khachTemp == null)
                listKhachHang.ThemKhach(khach);
            khachTemp = listKhachHang.TimTheoSdt(khach.Sdt);
            DTOHoaDon hoaDonTemp = new DTOHoaDon();
            hoaDonTemp.TongTien = hoaDon.TongTien;
            hoaDonTemp.NgayLap = hoaDon.NgayLap;
            hoaDonTemp.IdNhanVien = hoaDon.IdNhanVien;
            hoaDonTemp.IdKhach = khachTemp.Id;
            if(listHoaDon.ThemHoaDon(hoaDonTemp))
            {
                hoaDonTemp = listHoaDon.TimTheoObject(hoaDonTemp);
                foreach (DTOChiTietHoaDon i in list)
                {
                    DTOChiTietHoaDon temp = new DTOChiTietHoaDon();
                    temp = i;
                    temp.IdHoaDon = hoaDonTemp.Id;
                    test = test && listChiTietHoaDon.ThemChiTietHoaDon(temp);
                }
            }
            return test;
        }

        public List<DTOHoaDonKhach> ThongKe(string from, string to)
        {
            if(string.IsNullOrEmpty(from) && string.IsNullOrEmpty(to))
                return listHoaDonKhach.GetAll();
            DateTime start = DateTime.ParseExact(from, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(to, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            return listHoaDonKhach.FilterBetween(start, end);
        }
    }
}
