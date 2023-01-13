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

namespace Library
{
    public partial class BorrowForm : Form
    {
        Label borrowCnt;
        public BorrowForm(Label borrowCnt)
        {
            InitializeComponent();
            this.borrowCnt = borrowCnt;
            
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

            string sql = "SELECT B.id,Bk.name , U.name, U.email,P.phone, FORMAT (B.borrow_date, 'dd-MM-yyyy'), FORMAT (B.return_date, 'dd-MM-yyyy') FROM Borrow B LEFT OUTER JOIN Users U ON B.user_id = U.id LEFT OUTER JOIN Book Bk ON B.book_id = Bk.id LEFT OUTER JOIN User_phones P ON U.id = P.id";
            borrowData.DataSource = Book.LoadDate(sql);
            if (Book.GetBorrowBookNumber() == 0)
                button1.Enabled = false;

            borrowData.Columns[0].HeaderText = "ID";
            borrowData.Columns[0].Width = 60;
            borrowData.Columns[1].HeaderText = "الكتاب";
            borrowData.Columns[1].Width = 250;
            borrowData.Columns[2].HeaderText = "الطالب";
            borrowData.Columns[2].Width = 120;
            borrowData.Columns[3].HeaderText = "البريد الالكتروني";
            borrowData.Columns[3].Width = 150;
            borrowData.Columns[4].HeaderText = "الهاتف";
            borrowData.Columns[5].HeaderText = "الاستعارة";
            borrowData.Columns[6].HeaderText = "الاسترجاع";

            borrowData.Columns[0].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            borrowData.Columns[1].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            borrowData.Columns[2].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            borrowData.Columns[3].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            borrowData.Columns[4].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            borrowData.Columns[5].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            borrowData.Columns[6].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                int id = int.Parse(borrowData.CurrentRow.Cells[0].Value.ToString());
                int[] arr = GetId(id);
                int num = User.NumberOfBorrow(arr[0]);
                Book.DeleteBorrowBook(id);
                Book.Updatebook("UPDATE Book SET borrow = 0 WHERE id = " + (arr[1])+"");
                if (num == 1)
                    {
                        var us = new User();
                        us.DeletePhpne(arr[0]);
                        us.DeleteUser(arr[0]);
                    }
                MessageBox.Show("تمت العملية بنجاح");
                this.borrowData.Rows.RemoveAt(borrowData.CurrentRow.Index);
                Book.DecBorrowBookNumber();
                borrowCnt.Text = Book.GetBorrowBookNumber().ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (Book.GetBorrowBookNumber() == 0)
                button1.Enabled = false;
        }

        private int[] GetId(int id)
        {
            int[] arr = new int[2];
            var con = new DatabaseCon();
            string sql = "SELECT user_id,book_id FROM Borrow WHERE id = " + (id) + "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    arr[0] = dr.GetInt32(0);
                    arr[1] = dr.GetInt32(1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
            return arr;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool book = noCh.Checked;
            bool nameB = bookCh.Checked;
            bool nameS = stCh.Checked;
            string sql;
            if (searchTextBox.Text == "")
            {
                sql = "SELECT B.id,Bk.name , U.name, U.email,P.phone, FORMAT (B.borrow_date, 'dd-MM-yyyy'), FORMAT (B.return_date, 'dd-MM-yyyy') FROM Borrow B LEFT OUTER JOIN Users U ON B.user_id = U.id LEFT OUTER JOIN Book Bk ON B.book_id = Bk.id LEFT OUTER JOIN User_phones P ON U.id = P.id";
                borrowData.DataSource = Book.LoadDate(sql);
                if (borrowData.RowCount >= 1)
                    button1.Enabled = true;
            }
            else
            {
                if (book)
                {
                    try
                    {
                        int id = int.Parse(searchTextBox.Text);
                        sql = "SELECT B.id,Bk.name , U.name, U.email,P.phone, FORMAT (B.borrow_date, 'dd-MM-yyyy'), FORMAT (B.return_date, 'dd-MM-yyyy') FROM Borrow B LEFT OUTER JOIN Users U ON B.user_id = U.id LEFT OUTER JOIN Book Bk ON B.book_id = Bk.id LEFT OUTER JOIN User_phones P ON U.id = P.id WHERE Bk.id = " + (id) + " ";
                        borrowData.DataSource = Book.LoadDate(sql);
                    }
                    catch
                    {
                        MessageBox.Show("ادخل رقم صحيح");
                    }

                }
                else if (nameB)
                {
                    sql = "SELECT B.id,Bk.name , U.name, U.email,P.phone, FORMAT (B.borrow_date, 'dd-MM-yyyy'), FORMAT (B.return_date, 'dd-MM-yyyy') FROM Borrow B LEFT OUTER JOIN Users U ON B.user_id = U.id LEFT OUTER JOIN Book Bk ON B.book_id = Bk.id LEFT OUTER JOIN User_phones P ON U.id = P.id WHERE (Bk.name LIKE '" + (searchTextBox.Text) + "%' OR Bk.name LIKE '%" + (searchTextBox.Text) + "%' OR Bk.name LIKE '%" + (searchTextBox.Text) + "')";
                    borrowData.DataSource = Book.LoadDate(sql);
                }
                else
                {
                    sql = "SELECT B.id,Bk.name , U.name, U.email,P.phone, FORMAT (B.borrow_date, 'dd-MM-yyyy'), FORMAT (B.return_date, 'dd-MM-yyyy') FROM Borrow B LEFT OUTER JOIN Users U ON B.user_id = U.id LEFT OUTER JOIN Book Bk ON B.book_id = Bk.id LEFT OUTER JOIN User_phones P ON U.id = P.id WHERE (U.name LIKE '" + (searchTextBox.Text) + "%' OR U.name LIKE '%" + (searchTextBox.Text) + "%' OR U.name LIKE '%" + (searchTextBox.Text) + "')";
                    borrowData.DataSource = Book.LoadDate(sql);
                }
            }
        }
    }
}
