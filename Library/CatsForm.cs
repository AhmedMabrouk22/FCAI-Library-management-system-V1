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
    public partial class CatsForm : Form
    {
        Label catCnt;
        AddBookForm abf;
        public CatsForm(Label catCnt)
        {
            InitializeComponent();
            this.catCnt = catCnt;
        }

        public CatsForm(Label catCnt, AddBookForm abf)
        {
            InitializeComponent();
            this.abf = abf;
            this.Text = "إختار تصنيف";
            modBtn.Enabled = false;
            delBtn.Enabled = false;
        }

        private void addCatbutn_Click(object sender, EventArgs e)
        {
            var addCatfrm = new AddCatForm(this.catData,catCnt);
            addCatfrm.ShowDialog();
        }

        private void CatsForm_Load(object sender, EventArgs e)
        {
            catData.DataSource = Category.load();

            catData.Columns[0].HeaderText = "ID";
            catData.Columns[0].Width = 50;
            /*catData.Columns[0].FillWeight = 50;*/
            catData.Columns[1].HeaderText = "الإسم";
            catData.Columns[0].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            catData.Columns[1].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);

        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            var addCatfrm = new AddCatForm(this.catData,catCnt,true);
            addCatfrm.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.catData.CurrentRow.Cells[0].Value.ToString());
            Category cat = new Category();
            
            try
            {
                cat.DeleteCat(id);
                this.catData.Rows.RemoveAt(catData.CurrentRow.Index);
                Category.DecCatNumber();
                catCnt.Text = Category.GetCatNumber().ToString();
            }
            catch
            {
                MessageBox.Show("حدث خطأ حاول مرة أخرى");
            }
        }

        private void catData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modBtn.Enabled == false && delBtn.Enabled == false)
            {
                abf.catId = int.Parse(catData.CurrentRow.Cells[0].Value.ToString());
                abf.catTextBox.Text = catData.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
