using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var admin = new Admin();
            if (emailTextbox.Text == "" || pasTextbox.Text == "")
                MessageBox.Show("يجب إدخال البيانات");
            else
            {
                string email = emailTextbox.Text;
                string pass = pasTextbox.Text;
                admin = admin.GetAdmin(email);
                if (admin.Email == email && admin.Password == pass)
                {
                    Admin.RunAdmin = admin;
                    Thread thr = new Thread(start);
                    thr.SetApartmentState(ApartmentState.STA);
                    thr.Start();

                    this.Close();
                }
                else
                    MessageBox.Show("البريد الالكتروني أو كلمة المرور خطأ أعد المحاولة مرة أخرى");
            }

            

        }

        static void start ()
        {
            Application.Run(new AdminForm());
        }

        private void emailTextbox_Enter(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "Email")
            {
                emailTextbox.Text = "";
            }
        }

        private void emailTextbox_Leave(object sender, EventArgs e)
        {
            if (emailTextbox.Text == "")
                emailTextbox.Text = "Email";
        }

        private void pasTextbox_Enter(object sender, EventArgs e)
        {
            if (pasTextbox.Text == "Password")
            {
                pasTextbox.Text = "";
                pasTextbox.UseSystemPasswordChar = true;
            }
        }

        private void pasTextbox_Leave(object sender, EventArgs e)
        {
            if(pasTextbox.Text == "")
            {
                pasTextbox.UseSystemPasswordChar = false;
                pasTextbox.Text = "Password";
            }
        }
    }
}
