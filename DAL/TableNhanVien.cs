using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TableNhanVien : Pharmacy
    {
        private PharmacyDataContext database;
        public TableNhanVien()
        {
            database = getDatabase();
        }
        public DTONhanVien GET(DTONhanVien nv)
        {
            try
            {
                NhanVien temp = database.NhanViens.Single(nhanvien =>
                                                        nhanvien.usr.Trim().Equals(nv.Usr.Trim()) &&
                                                        nhanvien.pwd.Trim().Equals(nv.Password.Trim()));
                if (temp == null)
                    return null;
                DTONhanVien result = new DTONhanVien();
                result.Id = temp.id;
                result.Password = temp.pwd;
                result.Ten = temp.ten;
                result.Usr = temp.usr;
                return result;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
