using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BooksForm : Form
    {
        Label catCnt, bookCnt;
        public BooksForm(Label catCnt, Label bookCnt)
        {
            InitializeComponent();
            
            this.catCnt = catCnt;
            this.bookCnt = bookCnt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

            string sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id";
            bookData.DataSource = Book.LoadDate(sql);

            bookData.Columns[0].HeaderText = "ID";
            bookData.Columns[0].Width = 50;
            bookData.Columns[1].HeaderText = "إسم الكتاب";
            bookData.Columns[1].Width = 300;
            bookData.Columns[2].HeaderText = "ISBN";
            bookData.Columns[2].Width = 120;
            bookData.Columns[3].HeaderText = "التصنيف";
            bookData.Columns[3].Width = 120;
            bookData.Columns[4].HeaderText = "المؤلف";
            bookData.Columns[4].Width = 110;
            bookData.Columns[5].HeaderText = "الناشر";
            bookData.Columns[5].Width = 130;
            bookData.Columns[6].HeaderText = "الاصدار";
            bookData.Columns[6].Width = 70;
            bookData.Columns[7].HeaderText = "";


            bookData.Columns[0].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[1].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[2].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[3].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[4].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[5].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[6].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            bookData.Columns[7].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);

        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var addBookFrm = new AddBookForm(catCnt, bookCnt,bookData);
            addBookFrm.ShowDialog();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            var addBookFrm = new AddBookForm(catCnt, bookCnt, bookData,true);
            addBookFrm.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.bookData.CurrentRow.Cells[0].Value.ToString());
            var book = new Book();
            try
            {
                book.DeleteBook(id);
                this.bookData.Rows.RemoveAt(bookData.CurrentRow.Index);
                Book.DecBookNumber();
                bookCnt.Text = Book.GetBookNumber().ToString();
                
            }
            catch
            {
                MessageBox.Show("حدث خطأ حاول مرة أخرى");
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int type = serachComboBox.SelectedIndex;
            if (type != -1)
            {
                string sql = "";
                if (searchTextBox.Text != "")
                {
                    if (type == 0)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (B.name LIKE '" + (searchTextBox.Text) + "%' OR B.name LIKE '%" + (searchTextBox.Text) + "%' OR B.name LIKE '%" + (searchTextBox.Text) + "')";
                    else if (type == 1)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (B.ISBN = '" + (searchTextBox.Text) + "')";
                    else if (type == 2)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (A.name LIKE '" + (searchTextBox.Text) + "%' OR A.name LIKE '%" + (searchTextBox.Text) + "%' OR A.name LIKE '%" + (searchTextBox.Text) + "')";
                    else if (type == 3)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (C.name LIKE '" + (searchTextBox.Text) + "%' OR C.name LIKE '%" + (searchTextBox.Text) + "%' OR C.name LIKE '%" + (searchTextBox.Text) + "') ";
                    else if (type == 4)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE (P.name LIKE '" + (searchTextBox.Text) + "%' OR P.name LIKE '%" + (searchTextBox.Text) + "%' OR P.name LIKE '%" + (searchTextBox.Text) + "')";
                    else if (type == 5)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = 0";
                    else if (type == 6)
                        sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = 1";

                    bookData.DataSource = Book.LoadDate(sql);
                }
                else if (searchTextBox.Text == "" && type == 5)
                {
                    sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = 0";
                    bookData.DataSource = Book.LoadDate(sql);
                }
                else if (searchTextBox.Text == "" && type == 6)
                {
                    sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id WHERE B.borrow = 1";
                    bookData.DataSource = Book.LoadDate(sql);
                }
                else
                {
                    sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id";
                    bookData.DataSource = Book.LoadDate(sql);
                }

            }
            else
                MessageBox.Show("الرجاء إختيار نوع البحث");
        }
    }
}
