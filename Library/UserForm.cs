using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
            
        }


        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var borrowBook = new BorrowBookForm(this);
            string sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = " + (0) + "";
            bookData.DataSource = Book.LoadDate(sql);
            borrowBook.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Load data from database

            string sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = " + (0) + "";
            bookData.DataSource = Book.LoadDate(sql);

            bookData.Columns[0].HeaderText = "ID";
            bookData.Columns[0].Width = 60;
            bookData.Columns[1].HeaderText = "إسم الكتاب";
            bookData.Columns[1].Width = 400;
            bookData.Columns[2].HeaderText = "ISBN";
            bookData.Columns[2].Width = 150;
            bookData.Columns[3].HeaderText = "التصنيف";
            bookData.Columns[3].Width = 150;
            bookData.Columns[4].HeaderText = "المؤلف";
            bookData.Columns[4].Width = 150;
            bookData.Columns[5].HeaderText = "دار النشر";
            bookData.Columns[6].HeaderText = "رقم الاصدار";
            bookData.Columns[6].Width = 120;

            bookData.Columns[0].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[1].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[2].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[3].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[4].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[5].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[6].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);

        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
           
            int type = searchComboBox.SelectedIndex;
            if (type != -1)
            {
                string sql = "";
                if (searchTextBox.Text != "")
                {
                    if (type == 0)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (B.name LIKE '" + (searchTextBox.Text)+ "%' OR B.name LIKE '%" + (searchTextBox.Text) + "%' OR B.name LIKE '%" + (searchTextBox.Text) + "') AND B.borrow = " + (0) + "";
                    else if (type == 1)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (B.ISBN = '" + (searchTextBox.Text)+ "') AND B.borrow = " + (0) + "";
                    else if (type == 2)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (A.name LIKE '" + (searchTextBox.Text) + "%' OR A.name LIKE '%" + (searchTextBox.Text) + "%' OR A.name LIKE '%" + (searchTextBox.Text) + "')AND B.borrow = " + (0) + "";
                    else if (type == 3)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = " + (0) + " AND (C.name LIKE '" + (searchTextBox.Text) + "%' OR C.name LIKE '%" + (searchTextBox.Text) + "%' OR C.name LIKE '%" + (searchTextBox.Text) + "') ";
                    else if (type == 4)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (P.name LIKE '" + (searchTextBox.Text) + "%' OR P.name LIKE '%" + (searchTextBox.Text) + "%' OR P.name LIKE '%" + (searchTextBox.Text) + "')AND B.borrow = " + (0) + "";

                    bookData.DataSource = Book.LoadDate(sql);
                }
                else
                {
                    sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = " + (0) + "";
                    bookData.DataSource = Book.LoadDate(sql);
                }

            }
            else 
            MessageBox.Show("الرجاء إختيار نوع البحث");
        }

        private void bookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
