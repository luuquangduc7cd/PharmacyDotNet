using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoaDonKhach : Pharmacy
    {
        private PharmacyDataContext database;
        public HoaDonKhach()
        {
            database = getDatabase();
        }
        public List<DTOHoaDonKhach> GetAll()
        {
            List<DTOHoaDonKhach> list = new List<DTOHoaDonKhach>();
            var innerJoinQuery = from khach in database.Khaches
                                 join hoaDon in database.HoaDons on khach.id equals hoaDon.idKhach
                                 select new { id = hoaDon.id,
                                     ten = khach.ten,
                                     ngay = hoaDon.ngayLap,
                                     tien = hoaDon.tongTien };
            foreach(var item in innerJoinQuery)
            {
                DTOHoaDonKhach obj = new DTOHoaDonKhach(item.id, item.ngay, item.ten, item.tien);
                list.Add(obj);
            }
            return list;
        }
    }
}
