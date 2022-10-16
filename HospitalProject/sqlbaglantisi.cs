using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalProject
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UMTLPQ5;Initial Catalog=HospitalProject;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
