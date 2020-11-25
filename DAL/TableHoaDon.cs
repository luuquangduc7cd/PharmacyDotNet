using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableHoaDon : Pharmacy
    {
        private PharmacyDataContext database;
        private TableChiTietHoaDon tblChiTietHoaDon;
        public TableHoaDon()
        {
            database = getDatabase();
            tblChiTietHoaDon = new TableChiTietHoaDon();
        }

        public DTOHoaDon GET(int id)
        {
            HoaDon hd = database.HoaDons.Where(item => item.id == id).FirstOrDefault();
            DTOHoaDon temp = new DTOHoaDon(hd.id, hd.ngayLap, (int)hd.idKhach, hd.idNhanVien, hd.tongTien);
            return temp;
        }
        public DTOHoaDon GetHoaDonID(DTOHoaDon hd)
        {
            HoaDon hoaDon = database.HoaDons
                        .Where(item => item.ngayLap.Equals(hd.NgayLap) && 
                                item.idKhach == hd.IdKhach && 
                                item.idNhanVien == hd.IdNhanVien && 
                                item.tongTien.Equals(hd.TongTien))
                        .FirstOrDefault();
            DTOHoaDon temp = new DTOHoaDon(hoaDon.id, hoaDon.ngayLap, (int)hoaDon.idKhach, hd.IdNhanVien, hd.TongTien);
            return temp;
        }
        public List<DTOHoaDon> GetAll()
        {
            IEnumerable<HoaDon> hd = database.HoaDons;
            List<DTOHoaDon> list = new List<DTOHoaDon>();
            foreach (HoaDon i in hd)
            {
                DTOHoaDon temp = new DTOHoaDon();
                temp.Id = i.id;
                temp.IdKhach = (int)i.idKhach;
                temp.NgayLap = i.ngayLap;
                temp.TongTien = i.tongTien;
                temp.IdNhanVien = (int)i.idNhanVien;

            }
            return list;
        }
        public bool POST(DTOHoaDon hd)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.idNhanVien = hd.IdNhanVien;
                hoaDon.idKhach = hd.IdKhach;
                hoaDon.ngayLap = hd.NgayLap;
                hoaDon.tongTien = hd.TongTien;
                database.HoaDons.InsertOnSubmit(hoaDon);
                database.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool PUT(DTOHoaDon hd)
        {
            try
            {
                HoaDon temp = database.HoaDons.Single(item => item.id == hd.Id);
                temp.idKhach = hd.IdKhach;
                temp.ngayLap = hd.NgayLap;
                temp.idNhanVien = hd.IdNhanVien;
                database.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool DELETE(int id)
        {
            try
            {
                HoaDon temp = database.HoaDons.Single(item => item.id == id);
                if (temp != null)
                {
                    database.HoaDons.DeleteOnSubmit(temp);
                    database.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool DeleteHoaDonByKhachId(int id)
        {
            try
            {
                IEnumerable<HoaDon> list = database.HoaDons.Where(item => item.idKhach == id);
                foreach(HoaDon i in list)
                    tblChiTietHoaDon.DeleteByParentId(i.id);
                database.HoaDons.DeleteAllOnSubmit(list);
                database.SubmitChanges();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<DTOHoaDon> GetHoaDonByKhachId(int id)
        {
            try
            {
                IEnumerable<HoaDon> list = database.HoaDons.Where(item => item.idKhach == id);
                List<DTOHoaDon> temp = new List<DTOHoaDon>();
                foreach (HoaDon i in list)
                {
                    DTOHoaDon dTOHoaDon = new DTOHoaDon();
                    dTOHoaDon.Id = i.id;
                    dTOHoaDon.IdKhach = (int)i.idKhach;
                    dTOHoaDon.IdNhanVien = i.idNhanVien;
                    dTOHoaDon.TongTien = i.tongTien;
                    temp.Add(dTOHoaDon);
                }
                return temp;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
