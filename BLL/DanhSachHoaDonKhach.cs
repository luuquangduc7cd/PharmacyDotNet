using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhSachHoaDonKhach
    {
        HoaDonKhach list;
        public DanhSachHoaDonKhach()
        {
            list = new HoaDonKhach();
        }
        public List<DTOHoaDonKhach> GetAll()
        {
            return list.GetAll();
        }
        public List<DTOHoaDonKhach> FilterBetween(DateTime from, DateTime to)
        {
            List<DTOHoaDonKhach> temp = list.GetAll();
            List<DTOHoaDonKhach> result = new List<DTOHoaDonKhach>();
            foreach (DTOHoaDonKhach i in temp)
            {
                DateTime timeOfBill = DateTime.ParseExact(i.NgayLap, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (DateTime.Compare(from, timeOfBill) <= 0 && DateTime.Compare(timeOfBill, to) <= 0)
                    result.Add(i);
            }
            return result;
        }
    }
}
