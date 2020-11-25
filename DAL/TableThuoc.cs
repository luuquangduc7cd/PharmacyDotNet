using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TableThuoc : Pharmacy
    {
        private PharmacyDataContext database;
        public TableThuoc()
        {
            database = getDatabase();
        }
        public DTOThuoc GET(int id)
        {
            try
            {
                DTOThuoc obj = new DTOThuoc();
                Thuoc temp = database.Thuocs.Single(item => item.id == id);
                if (temp == null)
                    return null;
                obj.Id = id;
                obj.Ten = temp.ten;
                obj.SoLuong = int.Parse(temp.soLuong.ToString());
                obj.HanSuDung = temp.hanSuDung;
                obj.IdNhanVien = temp.idNhanVien;
                obj.NhaCungCap = temp.nhaCungCap;
                obj.DonGia = int.Parse(temp.donGia.ToString());
                obj.DonVi = temp.donVi;
                return obj;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public List<DTOThuoc> GetAll()
        {
            try
            {
                IEnumerable<Thuoc> list = from item in database.Thuocs select item;
                List<DTOThuoc> danhSach = new List<DTOThuoc>();
                foreach (Thuoc temp in list)
                {
                    DTOThuoc obj = new DTOThuoc();
                    obj.Id = temp.id;
                    obj.Ten = temp.ten;
                    obj.SoLuong = int.Parse(temp.soLuong.ToString());
                    obj.HanSuDung = temp.hanSuDung;
                    obj.IdNhanVien = temp.idNhanVien;
                    obj.NhaCungCap = temp.nhaCungCap;
                    obj.DonGia = int.Parse(temp.donGia.ToString());
                    obj.DonVi = temp.donVi;
                    danhSach.Add(obj);
                }
                return danhSach;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public List<DTOThuoc> GetByTenThuoc(string ten)
        {
            try
            {
                IEnumerable<Thuoc> list = database.Thuocs.Where(item => item.ten.Contains(ten));
                List<DTOThuoc> danhSach = new List<DTOThuoc>();
                if (list == null)
                    return null;
                foreach (Thuoc temp in list)
                {
                    DTOThuoc obj = new DTOThuoc();
                    obj.Id = temp.id;
                    obj.Ten = temp.ten;
                    obj.SoLuong = int.Parse(temp.soLuong.ToString());
                    obj.HanSuDung = temp.hanSuDung;
                    obj.IdNhanVien = temp.idNhanVien;
                    obj.NhaCungCap = temp.nhaCungCap;
                    obj.DonGia = int.Parse(temp.donGia.ToString());
                    obj.DonVi = temp.donVi;
                    danhSach.Add(obj);
                }
                return danhSach;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool POST(DTOThuoc temp)
        {
            try
            {
                Thuoc obj = new Thuoc();
                obj.id = temp.Id;
                obj.ten = temp.Ten;
                obj.soLuong = temp.SoLuong;
                obj.hanSuDung = temp.HanSuDung;
                obj.idNhanVien = temp.IdNhanVien;
                obj.nhaCungCap = temp.NhaCungCap;
                obj.donGia = temp.DonGia;
                obj.donVi = temp.DonVi;
                database.Thuocs.InsertOnSubmit(obj);
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
                Thuoc temp = database.Thuocs.Single(item => item.id == id);
                database.Thuocs.DeleteOnSubmit(temp);
                database.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool PUT(DTOThuoc thuoc)
        {
            try
            {
                Thuoc temp = database.Thuocs.Single(item => item.id == thuoc.Id);
                temp.idNhanVien = thuoc.IdNhanVien;
                temp.ten = thuoc.Ten;
                temp.donVi = thuoc.DonVi;
                temp.donGia = thuoc.DonGia;
                temp.soLuong = thuoc.SoLuong;
                temp.nhaCungCap = thuoc.NhaCungCap;
                temp.hanSuDung = thuoc.HanSuDung;
                database.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
