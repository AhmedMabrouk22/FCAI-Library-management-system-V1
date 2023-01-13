using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    class User
    {
        DatabaseCon con = new DatabaseCon();
        SqlDataReader dr;

        private static int userNum;

        public int Id { get; private set;}
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Dep { get; private set; }
        public string Phone { get; private set; }

        public User()
        {
            Id = -1;
        }

        public static void SetUserNum()
        {
            var con = new DatabaseCon();
            var dt = new DataTable();
            string sql = "SELECT id FROM Users";
            SqlCommand cmd = new SqlCommand(sql, con.open());
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.close();
            userNum = dt.Rows.Count;
        }
        public static int GetUserNum()
        {
            return userNum;
        }
        public static void IncUser()
        {
            ++userNum;
        }

        // Find user in user table
        public User user(string email)
        {
            User us = new User();
            string sql = "SELECT id,name,email,department FROM Users WHERE email = '" + (email) + "'";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    us.Id = dr.GetInt32(0);
                    us.Name = dr.GetString(1);
                    us.Email = dr.GetString(2);
                    us.Dep = dr.GetString(3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
            us.Phone = GetPhoneNumber(us.Id);
            return us;
        }

        // Add new user in users Table
        public void InsertUser(string name, string email, string dep)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "INSERT INTO Users VALUES('" + (name) + "','" + (email) + "','" + (dep) + "')";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();

        }
        public void DeleteUser(int id)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "DELETE FROM Users WHERE id = "+(id)+"";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }

        //Insert userPhone
        public void insertPhone(int id, string phone)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "INSERT INTO User_phones VALUES(" + (id) + ",'" + (phone) + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void DeletePhpne(int id)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "DELETE FROM User_phones WHERE id = " + (id) + "";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void UpdatePhpne(int id, string phone)
        {
            var con = new DatabaseCon();
            string sql = "UPDATE User_phones SET phone = '" + (phone) + "' WHERE id = " + (id) + "";
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
        private string GetPhoneNumber(int id)
        {
            string sql = "SELECT phone FROM User_phones WHERE id = "+(id)+"";
            string phoen = "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    phoen = dr.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
            return phoen;
        }
        public static void UpdateUser(string sql)
        {
            DatabaseCon con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public static int NumberOfBorrow(int id)
        {
            var con = new DatabaseCon();
            string sql = "SELECT COUNT(" + (id) + ") FROM Borrow";
            int num = 0;
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    num = dr.GetInt32(0);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
            return num;
        }

    }
}
