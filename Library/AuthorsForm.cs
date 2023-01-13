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
    public partial class AuthorsForm : Form
    {
        AddBookForm abf;

        public AuthorsForm()
        {
            InitializeComponent();
            authorData.DataSource = Author.LoadDate("SELECT * FROM Author");
        }

        public AuthorsForm(AddBookForm abf)
        {
            InitializeComponent();
            authorData.DataSource = Author.LoadDate("SELECT * FROM Author");
            this.abf = abf;
            modBtn.Enabled = false;
            delBtn.Enabled = false;
        }


        private void addAuthorBtn_Click(object sender, EventArgs e)
        {
            var addAuthorFrm = new AddAuthorForm(this.authorData);
            addAuthorFrm.ShowDialog();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            authorData.Columns[0].HeaderText = "ID";
            authorData.Columns[1].HeaderText = "الإسم";
            authorData.Columns[2].HeaderText = "البريد الالكتروني";

            authorData.Columns[0].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            authorData.Columns[1].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            authorData.Columns[2].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
        }

        private void authorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.authorData.CurrentRow.Cells[0].Value.ToString());
            Author author = new Author();
            try
            {
                author.DeleteAuthor(id);
                this.authorData.Rows.RemoveAt(authorData.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("حدث خطأ حاول مرة أخرى");
            }
            
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            var updateAuthor = new AddAuthorForm(this.authorData, true);
            updateAuthor.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
                authorData.DataSource = Author.LoadDate("SELECT * FROM Author");
            else
            {

                string sql = "SELECT * FROM Author WHERE name LIKE '"+(searchTextBox.Text) + "' OR name LIKE '%" + (searchTextBox.Text) + "' OR name LIKE '" + (searchTextBox.Text) + "%' OR name LIKE '%" + (searchTextBox.Text) + "%'";
                authorData.DataSource = Author.LoadDate(sql);
            }
        }

        private void authorData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modBtn.Enabled == false && delBtn.Enabled == false)
            {
                abf.authorId = int.Parse(authorData.CurrentRow.Cells[0].Value.ToString());
                abf.authorTextBox.Text = authorData.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }


    }
}
