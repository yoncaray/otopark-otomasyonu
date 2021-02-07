using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu
{
    class SqlBaglanti
    {
        public SqlConnection sqlbaglan()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-OS5O92Q2;Initial Catalog=OtoparkOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
