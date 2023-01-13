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
    public partial class AddAuthorForm : Form
    {
        DataGridView dg = new DataGridView();
        bool state;

        public AddAuthorForm(DataGridView dg,bool state = false)
        {
            InitializeComponent();
            this.dg = dg;
            this.state = state;
            if (state == true)
            {
                addBtn.Text = "تعديل";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var author = new Author();

            if (nameTextBox.Text != "")
            {
                if(state == false)
                {
                    try
                    {
                        author.InsertAuthor(nameTextBox.Text, emailTextBox.Text);
                        dg.DataSource = Author.LoadDate("SELECT * FROM Author");
                        int nRowIdx = dg.Rows.Count - 1;
                        dg.FirstDisplayedScrollingRowIndex = nRowIdx;
                        dg.Rows[nRowIdx].Selected = true;
                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ حاول مرة أخرى");
                    }

                }
                else
                {
                    int id = int.Parse(dg.CurrentRow.Cells[0].Value.ToString());
                    try
                    {
                        author.UpdateAuthor(id, nameTextBox.Text, emailTextBox.Text);
                        dg.CurrentRow.Cells[1].Value = nameTextBox.Text.ToString();
                        dg.CurrentRow.Cells[2].Value = emailTextBox.Text.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ حاول مرة أخرى");
                    }
                }
                this.Close();


            }
            else
                MessageBox.Show("الرجاء إدخال إسم المؤلف");

        }

        private void AddAuthorForm_Load(object sender, EventArgs e)
        {
            if (state == true)
            {
                nameTextBox.Text = dg.CurrentRow.Cells[1].Value.ToString();
                emailTextBox.Text = dg.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
