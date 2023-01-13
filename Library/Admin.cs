using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class Admin
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static Admin RunAdmin = new Admin();
        public Admin GetAdmin(string email)
        {
            Admin admin = new Admin();
            var con = new DatabaseCon();
            string sql = "SELECT * FROM Admin WHERE email = '" + (email) + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    admin.Id = dr.GetInt32(0);
                    admin.Name = dr.GetString(1);
                    admin.Email = dr.GetString(2);
                    admin.Password = dr.GetString(3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
            return admin;
        }

        public void InsertAdmin(string name, string email,string pass)
        {
            var con = new DatabaseCon();
            string sql = "INSERT INTO Admin VALUES('" + (name) + "','" + (email) + "','" + (pass) + "')";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.close();
            }
        }
        public void UpdateAdmin(int id, string name,string pass)
        {
            var con = new DatabaseCon();
            string sql = "UPDATE Admin SET name = '" + (name) + "' , password = '" + (pass) + "' WHERE admin_id = " + (id) + "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.close();
            }
        }


    }
}
