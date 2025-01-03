using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace nhom1qlxe
{
    class Ketnoi
    {
        public static OracleConnection connectDB()
        {
            string chuoi = @"Data Source=DESKTOP-93BAI9D;User ID=TOAN1;Password=110103;Unicode=True";
            OracleConnection conn = new OracleConnection(chuoi);
            return conn;
        }
    }
}
