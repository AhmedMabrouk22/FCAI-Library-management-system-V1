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
    public partial class AddBookForm : Form
    {
        Label catCnt, bookCnt;
        public int catId,authorId = -1, publisherId = -1;
        DataGridView bookData;
        bool state;
        int id_book = -2;
        public AddBookForm(Label catCnt, Label bookCnt, DataGridView bookData, bool state = false)
        {
            InitializeComponent();
            this.catCnt = catCnt;
            this.bookCnt = bookCnt;
            this.bookData = bookData;
            this.state = state;
            if (state)
            {
                addBtn.Text = "تعديل";
                this.Text = "تعديل كتاب";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisher_Click(object sender, EventArgs e)
        {
            var publisher = new houseForm(this);
            publisher.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void AddBookForm_Load(object sender, EventArgs e)
        {
            if(state == true)
            {
                id_book = int.Parse(bookData.CurrentRow.Cells[0].Value.ToString());
                idTextBox.Text = bookData.CurrentRow.Cells[0].Value.ToString();
                idTextBox.Enabled = false;
                ISBNTextBox.Text = bookData.CurrentRow.Cells[2].Value.ToString();
                nameTextBox.Text = bookData.CurrentRow.Cells[1].Value.ToString();
                editionTextBox.Text = bookData.CurrentRow.Cells[6].Value.ToString();
                //catTextBox.Enabled = true;
                //authorTextBox.Enabled = true;
                //publisherTextbox.Enabled = true;
            }

        }

        private void author_Click(object sender, EventArgs e)
        {
            var author = new AuthorsForm(this);
            author.ShowDialog();
        }

        private void cat_Click(object sender, EventArgs e)
        {
            var cat = new CatsForm(catCnt, this);
            cat.ShowDialog();
        }

        private void add()
        {
            if (idTextBox.Text == "" || ISBNTextBox.Text == "" || nameTextBox.Text == "" || catTextBox.Text == "")
                MessageBox.Show("يجب إكمال البيانات المطلوبة");
            else
            {
                int id = -1;
                try
                {
                    id = int.Parse(idTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("يجب إدخال رقم صحيح");
                }

                if (id != -1 && Book.FindBook(id))
                {
                    string ISBN = ISBNTextBox.Text;
                    string name = nameTextBox.Text;
                    string edition = editionTextBox.Text;
                    int publisher = publisherId;
                    int author = authorId;
                    int cat = catId;
                    var book = new Book();
                    try
                    {
                        book.InsertBook(id, ISBN, name, edition, publisher, author, cat);
                        MessageBox.Show("تمت الاضافة بنجاح");
                        string sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id";
                        bookData.DataSource = Book.LoadDate(sql);
                        int nRowIdx = bookData.Rows.Count - 1;
                        bookData.FirstDisplayedScrollingRowIndex = nRowIdx;
                        bookData.Rows[nRowIdx].Selected = true;
                        Book.IncBookNumber();
                        bookCnt.Text = Book.GetBookNumber().ToString();

                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ حاول مرة أخرى");
                    }

                    this.Close();
                }

            }
        }
        private void update()
        {
            if (ISBNTextBox.Text == "" || nameTextBox.Text == "" || catTextBox.Text == "")
                MessageBox.Show("يجب إكمال البيانات المطلوبة");
            else
            {
                
                    string ISBN = ISBNTextBox.Text;
                    string name = nameTextBox.Text;
                    string edition = editionTextBox.Text;
                    int publisher = publisherId;
                    int author = authorId;
                    int cat = catId;
                    var book = new Book();
                    try
                    {
                        book.UpdateBook(id_book, ISBN, name, edition, publisher, author, cat);
                        MessageBox.Show("تم التعديل بنجاح");
                        string sql = "SELECT B.id , B.name , B.ISBN , C.name , A.name , P.name , B.edition_number, B.borrow FROM Book B LEFT OUTER JOIN Category C ON B.Category_id = C.id	LEFT OUTER JOIN Author A  ON B.Author_id = A.id LEFT OUTER JOIN Publish_house P ON B.Publishing_House_id = P.id";
                        int nRowIdx = bookData.CurrentCell.RowIndex;
                        bookData.DataSource = Book.LoadDate(sql);
                        bookData.FirstDisplayedScrollingRowIndex = nRowIdx;
                        bookData.Rows[nRowIdx].Selected = true;

                    }
                    catch
                    {
                        //MessageBox.Show("حدث خطأ حاول مرة أخرى");
                    }

                    this.Close();
                }

            }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (state == false)
                add();
            else
                update();
        }

    }

}
