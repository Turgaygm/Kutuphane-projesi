using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL
    {
        public static SqlConnection con = new SqlConnection(@"Data Source = 302-12; Initial Catalog =Kutuphane; User ID = sa; Password=1234");
        
    }
}
