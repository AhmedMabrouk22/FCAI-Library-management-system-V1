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
    public partial class houseForm : Form
    {
        AddBookForm abf;
        public houseForm()
        {
            InitializeComponent();
            
        }

        public houseForm(AddBookForm abf)
        {
            InitializeComponent();
            this.abf = abf;
            modBtn.Enabled = false;
            delBtn.Enabled = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            var addPublishFrm = new AddPublishHouseForm(this.dataGrid);
            addPublishFrm.ShowDialog();
        }

        private void houseForm_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = PublishHouse.LoadDate();

            dataGrid.Columns[0].HeaderText = "ID";
            dataGrid.Columns[0].Width = 50;
            dataGrid.Columns[1].HeaderText = "الإسم";
            dataGrid.Columns[1].Width = 200;
            dataGrid.Columns[2].HeaderText = "البريد الالكتروني";
            dataGrid.Columns[3].HeaderText = "العنوان";
            dataGrid.Columns[4].HeaderText = "رقم الهاتف";
            

            dataGrid.Columns[0].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            dataGrid.Columns[1].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            dataGrid.Columns[2].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            dataGrid.Columns[3].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);
            dataGrid.Columns[4].HeaderCell.Style.Font = new Font("Cairo", 11, FontStyle.Regular);

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.dataGrid.CurrentRow.Cells[0].Value.ToString());
            var publish = new PublishHouse();
            try
            {
                publish.DeletePhpne(id);
                publish.DeletePublishHouse(id);
                this.dataGrid.Rows.RemoveAt(dataGrid.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("حدث خطأ حاول مرة أخرى");
            }
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            var addPublishFrm = new AddPublishHouseForm(this.dataGrid,true);
            addPublishFrm.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT A.id , A.name , A.email, CONCAT(A.City , '-' , A.Street) , A.phone FROM (SELECT id , name , email, City , Street , phone , ROW_NUMBER() OVER (PARTITION BY id ORDER BY phone) AS RN FROM Publish_house LEFT OUTER JOIN House_phone ON id = House_id ) A WHERE A.RN = 1 AND (name LIKE '" + (searchTextBox.Text) + "' OR name LIKE '%" + (searchTextBox.Text) + "' OR name LIKE '" + (searchTextBox.Text) + "%' OR name LIKE '%" + (searchTextBox.Text) + "%')";
            dataGrid.DataSource = PublishHouse.LoadDate(sql);
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modBtn.Enabled == false && delBtn.Enabled == false)
            {
                abf.publisherId= int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                abf.publisherTextbox.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
