using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Pharmacy 
    { 
        private string str = @"Data Source=Lwu;Initial Catalog=Pharmacy;Integrated Security=True";
        protected PharmacyDataContext getDatabase()
        {
            PharmacyDataContext ctx = new PharmacyDataContext(str);
            ctx.Connection.Open();
            return ctx;
        }
    }
}
