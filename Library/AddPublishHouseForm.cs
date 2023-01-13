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
    public partial class AddPublishHouseForm : Form
    {
        DataGridView dg = new DataGridView();
        PublishHouse publisher = new PublishHouse();
        bool state;
        public AddPublishHouseForm(DataGridView dg,bool state = false)
        {
            InitializeComponent();
            this.dg = dg;
            this.state = state;
            if (state == true)
            {
                
                addBtn.Text = "تعديل";
                this.Text = "تعديل دار النشر";
                publisher.Id = int.Parse(dg.CurrentRow.Cells[0].Value.ToString());
                publisher.Name = dg.CurrentRow.Cells[1].Value.ToString();
                publisher.Email = dg.CurrentRow.Cells[2].Value.ToString();
                string[] str = dg.CurrentRow.Cells[3].Value.ToString().Split('-');
                publisher.City = str[0];
                publisher.Street = (str.Length < 2 ? "" : str[1]);
                publisher.phone = dg.CurrentRow.Cells[4].Value.ToString();
                
            }
        }


        private void AddPublishHouseForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = publisher.Name;
            emailTexbox.Text = publisher.Email;
            phoneTextBox.Text = publisher.phone;
            cityTextBox.Text = publisher.City;
            streetTextBox.Text = publisher.Street;
        }

        private void Add()
        {
            if (nameTextBox.Text == "")
                MessageBox.Show("يجب إدخال اسم دار النشر");
            else
            {
                string name = nameTextBox.Text;
                string email = emailTexbox.Text;
                string phone = phoneTextBox.Text;
                string city = cityTextBox.Text;
                string street = streetTextBox.Text;
                bool newPublisher = false;
                bool newPhone = false;
                int id = 0;
                try
                {
                    publisher.InsertPublishHouse(name, email, city, street);
                    newPublisher = true;
                    if (phone != "")
                    {
                        id = publisher.PublishHouseID();
                        publisher.InsertPhone(id, phone);
                        newPhone = true;
                    }
                    dg.DataSource = PublishHouse.LoadDate();
                    int nRowIdx = dg.Rows.Count - 1;
                    dg.FirstDisplayedScrollingRowIndex = nRowIdx;
                    dg.Rows[nRowIdx].Selected = true;
                }
                catch
                {
                    MessageBox.Show("حدث خطأ ولم تتم العملية بنجاح");
                    if (newPhone == true)
                        publisher.DeletePhpne(id);
                    if (newPublisher == true)
                        publisher.DeletePublishHouse(id);
                }

                this.Close();
            }
        }
        private void UpdateData()
        {
            if (nameTextBox.Text == "")
                MessageBox.Show("يجب إدخال اسم دار النشر");
            else
            {
                string name = nameTextBox.Text;
                string email = emailTexbox.Text;
                string phone = phoneTextBox.Text;
                string city = cityTextBox.Text;
                string street = streetTextBox.Text;
                try
                {
                    bool hasPhone = (publisher.phone != "");
                    publisher.UpdatePublishHouse(publisher.Id, name, email, city, street, phone, hasPhone);
                    int nRowIdx = dg.CurrentCell.RowIndex;
                    dg.DataSource = PublishHouse.LoadDate();
                    dg.FirstDisplayedScrollingRowIndex = nRowIdx;
                    dg.Rows[nRowIdx].Selected = true;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("حدث خطأ ولم تتم العملية بنجاح");
                }
                this.Close();
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (state == false)
                Add();
            else
                UpdateData();




        }
    }
}
