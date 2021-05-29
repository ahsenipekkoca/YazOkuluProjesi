using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-5C8GF20;Initial Catalog=YazOkuluDb;Integrated Security=True");
    }
}
