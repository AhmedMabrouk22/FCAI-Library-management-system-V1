using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Library
{
    class Category
    {
        private const string SQL =  "SELECT * FROM Category";
        private static int catNumber;

        public Category()
        {

        }

        public static DataTable load(string sql = SQL)
        {
            
            DatabaseCon con = new DatabaseCon();
            SqlCommand cmd;
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
            return dt;
        }
        public static int GetCatNumber()
        {
            return catNumber;
        }
        public static void IncCatNumber()
        {
            ++catNumber;
        }
        public static void DecCatNumber()
        {
            --catNumber;
        }
        public static void UpdateCatNumber()
        {
            string sql = "SELECT COUNT(id) FROM Category";
            var con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    catNumber = dr.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
        }

        public void InsertCat(string name)
        {
            var con = new DatabaseCon();
            string sql = "INSERT INTO Category VALUES('" + (name) + "')";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void DeleteCat(int id)
        {
            var con = new DatabaseCon();
            string sql = "DELETE FROM Category WHERE id = " + (id) + "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void UpdateCat(int id, string name)
        {
            var con = new DatabaseCon();
            string sql = "UPDATE Category SET name = '" + (name) + "' WHERE id = " + (id) + "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
    }
}
