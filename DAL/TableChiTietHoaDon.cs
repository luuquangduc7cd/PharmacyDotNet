using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TableChiTietHoaDon : Pharmacy
    {
        private PharmacyDataContext database;
        public TableChiTietHoaDon()
        {
            database = getDatabase();
        }
        public ChiTietHoaDon GET(int id)
        {
            IEnumerable<ChiTietHoaDon> list = from item in database.ChiTietHoaDons
                                 where item.id == id
                                 select item;
            return list.First();
        }
        public bool POST(DTOChiTietHoaDon cthd)
        {
            try
            {
                ChiTietHoaDon temp = new ChiTietHoaDon();
                temp.idHoaDon = cthd.IdHoaDon;
                temp.idThuoc = cthd.IdThuoc;
                temp.soLuong = cthd.SoLuong;
                database.ChiTietHoaDons.InsertOnSubmit(temp);
                database.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool PUT(ChiTietHoaDon cthd)
        {
            try
            {
                ChiTietHoaDon temp = database.ChiTietHoaDons.Single(item => item.id == cthd.id);
                temp.idHoaDon = cthd.idThuoc;
                temp.soLuong = cthd.soLuong;
                temp.idThuoc = cthd.idThuoc;
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
                ChiTietHoaDon temp = database.ChiTietHoaDons.Single(item => item.id == id);
                database.ChiTietHoaDons.DeleteOnSubmit(temp);
                database.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeleteByParentId(int parentId)
        {
            try
            {
                IEnumerable<ChiTietHoaDon> list = database.ChiTietHoaDons.Where(item => item.idHoaDon == parentId);
                database.ChiTietHoaDons.DeleteAllOnSubmit(list);
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
