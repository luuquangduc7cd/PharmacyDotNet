using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableKhach : Pharmacy
    {
        private PharmacyDataContext database;
        private TableHoaDon tblHoaDon;
        public TableKhach()
        {
            database = getDatabase();
            tblHoaDon = new TableHoaDon();
        }
        public DTOKhach GET(int id)
        {
            try
            {
                Khach khach = database.Khaches.Single(item => item.id == id);
                if (khach == null)
                    return null;
                DTOKhach result = new DTOKhach();
                result.Id = khach.id;
                result.Ten = khach.ten;
                result.Sdt = khach.sdt;
                result.DiaChi = khach.diaChi;
                return result;
            }
            catch (Exception e) 
            {
                return null;
            }
        }
        public bool POST(DTOKhach khach)
        {
            try
            {
                Khach temp = new Khach();
                temp.ten = khach.Ten;
                temp.sdt = khach.Sdt;
                temp.diaChi = khach.DiaChi;
                database.Khaches.InsertOnSubmit(temp);
                database.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool PUT(DTOKhach hd)
        {
            try
            {
                Khach temp = database.Khaches.Single(item => item.id == hd.Id);
                temp.ten = hd.Ten;
                temp.sdt = hd.Sdt;
                temp.diaChi = hd.DiaChi;
                database.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DELETE(int id)
        {
            try
            {
                Khach temp = database.Khaches.Single(item => item.id == id);
                if(temp != null)
                {
                    database.Khaches.DeleteOnSubmit(temp);
                    database.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<DTOKhach> GetAll()
        {
            try
            {
                IEnumerable<Khach> list = from item in database.Khaches select item;
                List<DTOKhach> danhSach = new List<DTOKhach>();
                foreach (Khach temp in list)
                {
                    DTOKhach obj = new DTOKhach();
                    obj.Id = temp.id;
                    obj.Ten = temp.ten;
                    obj.Sdt = temp.sdt;
                    obj.DiaChi = temp.diaChi;
                    danhSach.Add(obj);
                }
                return danhSach;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<DTOKhach> GetByTenKhach(string ten)
        {
            try
            {
                IEnumerable<Khach> list = from item in database.Khaches
                                          where item.ten.Contains(ten)
                                          select item;
                List<DTOKhach> danhSach = new List<DTOKhach>();
                foreach (Khach temp in list)
                {
                    DTOKhach obj = new DTOKhach();
                    obj.Id = temp.id;
                    obj.Ten = temp.ten;
                    obj.Sdt = temp.sdt;
                    obj.DiaChi = temp.diaChi;
                    danhSach.Add(obj);
                }
                return danhSach;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DTOKhach GetBySdt(string sdt)
        {
            try
            {
                Khach khach = database.Khaches.Single(item => item.sdt.Contains(sdt));
                if (khach == null)
                    return null;
                DTOKhach result = new DTOKhach();
                result.Id = khach.id;
                result.Ten = khach.ten;
                result.Sdt = khach.sdt;
                result.DiaChi = khach.diaChi;
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
