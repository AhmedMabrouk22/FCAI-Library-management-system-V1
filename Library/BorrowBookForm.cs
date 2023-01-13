using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace Library
{
    public partial class BorrowBookForm : Form
    {
        private DatabaseCon con = new DatabaseCon();
        private User user = new User();
        private int userID = -1;
        private UserForm usf;
        public BorrowBookForm(UserForm usf)
        {
            InitializeComponent();
            borrowDate.MinDate = DateTime.Now;
            borrowDate.Value = DateTime.Now;
            returnDate.MinDate = DateTime.Now;
            this.usf = usf;
        }

        private void borrowDate_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void returnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {

        }

        

        // Find book in book table
        private bool FindBook(int id)
        {
            string sql = "SELECT id FROM Book WHERE id = " + (id) + " AND borrow = 0";
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

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("الكتاب غير متوفر");
                return false;
            }

            return true;
        }

        // Add new borrow in Borrow Table
        private void InsertBorrow(int id ,int userId,int bookId, DateTime borrowDate , DateTime returnDate)
        {
            string sql = "INSERT INTO Borrow VALUES(" + (userId) + "," + (bookId) + ",'" + (borrowDate) + "','" + (returnDate) + "', "+(id)+")";
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

        private int BorrowNumber()
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "SELECT id FROM Borrow ";
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    res = int.Parse(dr.GetValue(0).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.close();
            }
            return res;

        }

        private void makeBorrow()
        {
            if (borrowBookID.Text == "" || borrowStName.Text == "" || borrowEmail.Text == "" || borrowDep.SelectedIndex == -1 || phone_textBox.Text == "")
                MessageBox.Show("الرجاء إكمال البيانات المطلوبة");
            else
            {
                int bookId = -1;
                try
                {
                    bookId = int.Parse(borrowBookID.Text);
                }
                catch
                {
                    MessageBox.Show("الرجاء إدخال رقم صحيح");
                }
                string stName = borrowStName.Text;
                string email = borrowEmail.Text;
                string dep = borrowDep.SelectedItem.ToString();

                if (bookId != -1 && FindBook(bookId)) // is book find  and not borrow ?
                {
                    bool newUser = false;
                    bool newPhone = false;
                    bool newBorrow = false;
                    try
                    {

                        if (Regex.IsMatch(email, @"^[A-Za-z0-9_-]+@fcai.usc.edu.eg$"))
                        {

                            userID = user.Id; // current user id
                            if (user.Id == -1) // add new user in user table
                            {
                                user.InsertUser(stName, email, dep);
                                newUser = true;
                                userID = user.user(email).Id; // new user id
                                user.insertPhone(userID, phone_textBox.Text);
                                newPhone = true;
                                User.IncUser();
                            }
                            int id = BorrowNumber() + 1;
                            InsertBorrow(id, userID, bookId, borrowDate.Value.Date, returnDate.Value.Date);
                            newBorrow = true;
                            string sql = "update Book SET borrow = 1 WHERE id = " + (bookId) + "";
                            Book.Updatebook(sql);
                            MessageBox.Show("تمت العملية بنجاح");
                        }
                        else
                            MessageBox.Show("يجب إدخال الايميل بطريقة صحيحة ويجب ان تكون طالب في الكلية");
                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ ولم تتم العملية");
                        if(newUser == true)
                        {
                            string sql;
                            if (newPhone == true)
                            {
                                sql = "DELETE FROM User_Phones WHERE id = " + (userID) + " AND phone = '" + (phone_textBox.Text) + "'";
                                User.UpdateUser(sql);
                            }
                            sql = "DELETE FROM Users WHERE id = " + (userID) + "";
                            User.UpdateUser(sql);
                        }

                        if (newBorrow)
                        {
                            string sql = "DELETE FROM Borrow WHERE book_id = " + (bookId) + "";
                            Book.Updatebook(sql);
                        }

                    }
                    if (newBorrow)
                    {
                        this.Close();
                        Book.IncBorrowBookNumber();
                    }
                }

            }

        }

        private void borrowBook_Click(object sender, EventArgs e)
        {
            makeBorrow();
            usf.bookData.DataSource = Book.LoadDate("SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = " + (0) + "");
            
        }

        private void borrowEmail_TextChanged(object sender, EventArgs e)
        {
            user = user.user(borrowEmail.Text);
            if (user != null && user.Id != -1)
            {
                borrowStName.Text = user.Name;
                borrowStName.Enabled = false;

                borrowDep.SelectedValue = user.Dep;
                borrowDep.SelectedText = user.Dep;
                borrowDep.SelectedItem = user.Dep;
                borrowDep.Enabled = false;

                phone_textBox.Text = user.Phone;
                phone_textBox.Enabled = false;

            }
            else
            {
                borrowStName.Text = "";
                borrowStName.Enabled = true;

                borrowDep.ResetText();
                borrowDep.SelectedIndex = -1;
                borrowDep.Enabled = true;

                phone_textBox.Text = "";
                phone_textBox.Enabled = true;


            }

        }

        private void borrowEmail_ModifiedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
