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

    class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string EN { get; set; }
        public int AuthorId {get;set;}
        public int PublishID { get; set; }
        public int CatId { get; set; }
        public bool Borrow { get; set; }
        private static int bookNumber;
        private static int borrowBookNumber;

        public static void Updatebook(string sql)
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
            finally
            {
                con.close();
            }
        }
        public static DataTable LoadDate(string sql)
        {
            DataTable dt = new DataTable();
            DatabaseCon con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
            return dt;
        }

        public static int GetBookNumber()
        {
            return bookNumber;
        }
        public static void IncBookNumber()
        {
            ++bookNumber;
        }
        public static void DecBookNumber()
        {
            --bookNumber;
        }
        public static void UpdateBookNumber()
        {
            string sql = "SELECT COUNT(id) FROM Book";
            var con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    bookNumber = dr.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
        }
        public static int GetBorrowBookNumber()
        {
            return borrowBookNumber;
        }
        public static void IncBorrowBookNumber()
        {
            ++borrowBookNumber;
        }
        public static void DecBorrowBookNumber()
        {
            --borrowBookNumber;
        }
        public static void UpdateBorrowBookNumber()
        {
            string sql = "SELECT COUNT(id) FROM Book WHERE borrow = 1";
            var con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    borrowBookNumber = dr.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
        }
        public static void DeleteBorrowBook(int id)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "DELETE FROM Borrow WHERE id = " + (id) + "";
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
            finally
            {
                con.close();
            }
        }
        public static bool FindBook(int id)
        {
            string sql = "SELECT id FROM Book WHERE id = " + (id) + "";
            var con = new DatabaseCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("لا يمكن تكرار الكتاب");
                return false;
            }

            return true;
        }


        public void InsertBook(int id , string ISBN,string name,string edition,int publisher,int author,int cat)
        {
            string sql = "";
            if (publisher != -1 && author != -1)
                sql = "INSERT INTO Book VALUES(" + (id) + ",'" + (ISBN) + "','" + (name) + "','" + (edition) + "'," + (publisher) + "," + (author) + "," + (cat) + "," + (0) + ")";
            else if (publisher != -1)
                sql = "INSERT INTO Book (id,ISBN,name,edition_number,Publishing_House_id,Category_id) VALUES(@id,@isbn,@name,@edition,@publisher,@cat)";
            else if (author != -1)
                sql = "INSERT INTO Book (id,ISBN,name,edition_number,Author_id,Category_id) VALUES(@id,@isbn,@name,@edition,@author,@cat)";
            else
                sql = "INSERT INTO Book (id,ISBN,name,edition_number,Category_id,borrow) VALUES(@id,@isbn,@name,@edition,@cat,@borrow)";

            var con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@isbn", ISBN);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@edition", edition);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@cat", cat);
                cmd.Parameters.AddWithValue("@borrow", 0);

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
        public void UpdateBook(int id, string ISBN, string name, string edition, int publisher, int author, int cat)
        {
            string sql = "";
            if (publisher != -1 && author != -1)
                sql = "UPDATE Book SET id = " + (id) + ", ISBN = '" + (ISBN) + "', name = '" + (name) + "',edition_number = '" + (edition) + "',Publishing_House_id = " + (publisher) + ", Author_id = " + (author) + ",Category_id = " + (cat) + " WHERE id = "+(id)+"";
            else if (publisher != -1)
                sql = "UPDATE Book SET id = " + (id) + ", ISBN = '" + (ISBN) + "', name = '" + (name) + "',edition_number = '" + (edition) + "',Publishing_House_id = " + (publisher) + ",Category_id = " + (cat) + " WHERE id = " + (id) + "";
            else if (author != -1)
                sql = "UPDATE Book SET id = " + (id) + ", ISBN = '" + (ISBN) + "', name = '" + (name) + "',edition_number = '" + (edition) + "', Author_id = " + (author) + ",Category_id = " + (cat) + " WHERE id = " + (id) + "";
            else
                sql = "UPDATE Book SET id = " + (id) + ", ISBN = '" + (ISBN) + "', name = '" + (name) + "',edition_number = '" + (edition) + "',Category_id = " + (cat) + " WHERE id = " + (id) + "";

            var con = new DatabaseCon();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());

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
        public void DeleteBook(int id)
        {
            var con = new DatabaseCon();
            string sql = "DELETE FROM Book WHERE id = " + (id) + "";
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
