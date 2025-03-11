using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp.YurtKayit
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-LLPCPH2\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;User ID=sa;Password=54321");
            baglan.Open();
            return baglan;
        }
    }
}
