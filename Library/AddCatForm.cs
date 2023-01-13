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
    public partial class AddCatForm : Form
    {
        DataGridView dg = new DataGridView();
        bool state;
        Label catCnt;
        public AddCatForm(DataGridView dg,Label catCnt,bool state = false)
        {
            InitializeComponent();
            this.dg = dg;
            this.state = state;
            if (state == true)
            {
                addBtn.Text = "تعديل";
                this.Text = "تعديل التصنيف";
                catNameTextBox.Text = dg.CurrentRow.Cells[1].Value.ToString();
            }
            this.catCnt = catCnt;
        }


        private int CatNumber()
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "SELECT IDENT_CURRENT('Category')";
            int res = -1;
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
            con.close();
            return res;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cat = new Category();
            if (catNameTextBox.Text != "")
            {
                if (state == false)
                {
                    try
                    {
                        cat.InsertCat(catNameTextBox.Text);
                        dg.DataSource = Category.load();
                        int nRowIdx = dg.Rows.Count - 1;
                        dg.FirstDisplayedScrollingRowIndex = nRowIdx;
                        dg.Rows[nRowIdx].Selected = true;
                        Category.IncCatNumber();
                        catCnt.Text = Category.GetCatNumber().ToString();
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
                        cat.UpdateCat(id, catNameTextBox.Text);
                        dg.CurrentRow.Cells[1].Value = catNameTextBox.Text.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ حاول مرة أخرى");
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("الرجاء إدخال إسم التصنيف");
        }

        private void AddCatForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
