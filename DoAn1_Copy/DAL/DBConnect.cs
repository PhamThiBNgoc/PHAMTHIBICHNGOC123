using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;


namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D5PP251;Initial Catalog=Doan_1;Integrated Security=True");
       
    }

}
