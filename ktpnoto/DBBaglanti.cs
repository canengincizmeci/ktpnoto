using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ktpnoto
{
    public class DBBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ktproj;Integrated Security=True");
            bgl.Open();
            return bgl;
        }



    }
}
