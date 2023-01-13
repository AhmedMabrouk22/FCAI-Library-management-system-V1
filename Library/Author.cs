using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Library
{
    class Author
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public static DataTable LoadDate(string sql)
        {
            var con = new DatabaseCon();
            var dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
            return dt;
        }

        public Author GetAuthor(int id)
        {
            Author author = new Author();
            author.Id = id;
            var con = new DatabaseCon();
            string sql = "SELECT * FORM Author WHERE id = " + (id) + "";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    author.Name = dr.GetString(1);
                    author.Email = dr.GetString(2);
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
            return author;
        }
        public void InsertAuthor(string name, string email)
        {
            var con = new DatabaseCon();
            string sql = "INSERT INTO Author VALUES('" + (name) + "','" + (email) + "')";
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
        public void DeleteAuthor(int id)
        {
            var con = new DatabaseCon();
            string sql = "DELETE FROM Author WHERE id = " + (id) + "";
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
        public void UpdateAuthor(int id,string name,string email)
        {
            var con = new DatabaseCon();
            string sql = "UPDATE Author SET name = '" + (name) + "' , email = '" + (email) + "' WHERE id = " + (id) + "";
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
