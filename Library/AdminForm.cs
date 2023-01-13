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
    

    public partial class AdminForm : Form
    {
        AuthorsForm af;
        CatsForm cat;
        BooksForm book;
        houseForm house;
        BorrowForm borrow;
        public AdminForm()
        {
            InitializeComponent();
            UpdateData();
            af = new AuthorsForm();
            cat = new CatsForm(catCnt);
            house = new houseForm();
            book = new BooksForm(catCnt, bookCnt);
            borrow = new BorrowForm(borrowCnt);
        }

        private void UpdateData()
        {
            Book.UpdateBookNumber();
            bookCnt.Text = Book.GetBookNumber().ToString();
            Category.UpdateCatNumber();
            catCnt.Text = Category.GetCatNumber().ToString();
            Book.UpdateBorrowBookNumber();
            borrowCnt.Text = Book.GetBorrowBookNumber().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addBookFrm = new AddBookForm(catCnt, bookCnt, book.bookData);
            addBookFrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var addCatfrm = new AddCatForm(cat.catData,catCnt);
            addCatfrm.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminName.Text = Admin.RunAdmin.Name;
            Thread thr = new Thread(start);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }


        private static void start()
        {
            Application.Run(new UserForm());
        }

        private void addAuthorBtn_Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthorFrm = new AddAuthorForm(af.authorData);
            addAuthorFrm.ShowDialog();
        }

        private void addHouseBtn_Click(object sender, EventArgs e)
        {
            var addPublishFrm = new AddPublishHouseForm(house.dataGrid);
            addPublishFrm.ShowDialog();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (book == null || book.IsDisposed)
                this.book = new BooksForm(catCnt, bookCnt);
            book.Show();
            book.BringToFront();

        }

        private void authorBtn_Click(object sender, EventArgs e)
        {
            if (af == null || af.IsDisposed)
                this.af = new AuthorsForm();
            
            af.Show();
            af.BringToFront();

        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            if (cat == null || cat.IsDisposed)
                this.cat = new CatsForm(this.catCnt);
            cat.Show();
            cat.BringToFront();
        }

        private void houseBtn_Click(object sender, EventArgs e)
        {
            if (house.IsDisposed)
             this.house = new houseForm();
            house.Show();
            house.BringToFront();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            if(borrow.IsDisposed)
                this.borrow = new BorrowForm(this.borrowCnt);

            borrowCnt.Text = Book.GetBorrowBookNumber().ToString();
            borrow.Show();
            borrow.BringToFront();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var add = new AddAdminForm();
            add.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var add = new AddAdminForm(adminName,true);
            add.ShowDialog();
        }
    }
}
