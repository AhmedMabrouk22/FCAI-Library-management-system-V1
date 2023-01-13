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
    public partial class AddAdminForm : Form
    {
        public AddAdminForm()
        {
            InitializeComponent();
        }
        bool state;
        Label adminName;
        public AddAdminForm(Label adminName,bool state)
        {
            InitializeComponent();
            this.Text = "تعديل";
            addBtn.Text = "تعديل";
            this.state = state;
            this.adminName = adminName;
        }

        private void add()
        {
            if (nameTextBox.Text == "" || emailTextBox.Text == "" || passTextBox.Text == "")
                MessageBox.Show("يجب إكمال البيانات");
            else
            {
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;
                string pass = passTextBox.Text;

                Admin admin = new Admin();
                admin = admin.GetAdmin(email);
                if (admin.Email == email)
                    MessageBox.Show("هذ البريد الالكتروني مستخدم");
                else
                {
                    try
                    {
                        admin.InsertAdmin(name, email, pass);
                        MessageBox.Show("تمت الإضافة بنجاح");
                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ");
                    }
                    this.Close();
                }
            }
        }
        private void update()
        {
            if (nameTextBox.Text == "" ||  passTextBox.Text == "")
                MessageBox.Show("يجب إكمال البيانات");
            else
            {
                string name = nameTextBox.Text;
                string pass = passTextBox.Text;

                Admin admin = new Admin();
                admin = admin.GetAdmin(emailTextBox.Text);
                try
                {
                    admin.UpdateAdmin(admin.Id,name, pass);
                    MessageBox.Show("تم التعديل بنجاح");
                    adminName.Text = name;
                }
                catch
                {
                    MessageBox.Show("حدث خطأ");
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

        private void AddAdminForm_Load(object sender, EventArgs e)
        {
            if(state)
            {
                var admin = new Admin();
                admin = admin.GetAdmin(Admin.RunAdmin.Email);
                nameTextBox.Text = admin.Name;
                emailTextBox.Text = admin.Email;
                emailTextBox.Enabled = false;
                passTextBox.Text = admin.Password;
            }

        }
    }
}
