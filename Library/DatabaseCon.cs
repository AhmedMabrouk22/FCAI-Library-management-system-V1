using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library
{
    class DatabaseCon
    {
        SqlConnection con;
        // Database Connection

        public DatabaseCon()
        {
            con = new SqlConnection("Data Source=DESKTOP-B8INV0B;Initial Catalog=library;Integrated Security=True");
        }
       
        // Open database
        public SqlConnection open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        // Close database
        public void close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }           

    }
}
