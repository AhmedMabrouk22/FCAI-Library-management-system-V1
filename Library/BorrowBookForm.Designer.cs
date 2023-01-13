namespace Library
{
    partial class BorrowBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.borrowBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowStName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.borrowBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.borrowDep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 45);
            this.label3.TabIndex = 28;
            this.label3.Text = "رقم الكتاب *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowBookID
            // 
            this.borrowBookID.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBookID.Location = new System.Drawing.Point(177, 14);
            this.borrowBookID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.borrowBookID.Name = "borrowBookID";
            this.borrowBookID.Size = new System.Drawing.Size(340, 45);
            this.borrowBookID.TabIndex = 0;
            this.borrowBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 45);
            this.label1.TabIndex = 30;
            this.label1.Text = "إسم الطالب *";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowStName
            // 
            this.borrowStName.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowStName.Location = new System.Drawing.Point(177, 134);
            this.borrowStName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.borrowStName.Name = "borrowStName";
            this.borrowStName.Size = new System.Drawing.Size(341, 45);
            this.borrowStName.TabIndex = 2;
            this.borrowStName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 45);
            this.label2.TabIndex = 32;
            this.label2.Text = "البريد الالكتروني *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowEmail
            // 
            this.borrowEmail.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowEmail.Location = new System.Drawing.Point(176, 74);
            this.borrowEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.borrowEmail.Name = "borrowEmail";
            this.borrowEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.borrowEmail.Size = new System.Drawing.Size(341, 45);
            this.borrowEmail.TabIndex = 1;
            this.borrowEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.borrowEmail.ModifiedChanged += new System.EventHandler(this.borrowEmail_ModifiedChanged);
            this.borrowEmail.TextChanged += new System.EventHandler(this.borrowEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 45);
            this.label4.TabIndex = 33;
            this.label4.Text = "تاريخ الاستعارة ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowDate
            // 
            this.borrowDate.CustomFormat = "yyyy-MM-dd";
            this.borrowDate.Enabled = false;
            this.borrowDate.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.borrowDate.Location = new System.Drawing.Point(177, 314);
            this.borrowDate.MinDate = new System.DateTime(2022, 12, 13, 0, 0, 0, 0);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(340, 43);
            this.borrowDate.TabIndex = 5;
            this.borrowDate.Value = new System.DateTime(2022, 12, 13, 0, 0, 0, 0);
            this.borrowDate.ValueChanged += new System.EventHandler(this.borrowDate_ValueChanged);
            // 
            // returnDate
            // 
            this.returnDate.CustomFormat = "yyyy-MM-dd";
            this.returnDate.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnDate.Location = new System.Drawing.Point(177, 374);
            this.returnDate.MinDate = new System.DateTime(2022, 12, 13, 0, 0, 0, 0);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(340, 43);
            this.returnDate.TabIndex = 6;
            this.returnDate.Value = new System.DateTime(2022, 12, 13, 0, 0, 0, 0);
            this.returnDate.ValueChanged += new System.EventHandler(this.returnDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 45);
            this.label5.TabIndex = 35;
            this.label5.Text = "تاريخ الاسترداد";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowBook
            // 
            this.borrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBook.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBook.Location = new System.Drawing.Point(12, 437);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(505, 45);
            this.borrowBook.TabIndex = 7;
            this.borrowBook.Text = "إستعارة";
            this.borrowBook.UseVisualStyleBackColor = true;
            this.borrowBook.Click += new System.EventHandler(this.borrowBook_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 45);
            this.label6.TabIndex = 38;
            this.label6.Text = "القسم *";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borrowDep
            // 
            this.borrowDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.borrowDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.borrowDep.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDep.FormattingEnabled = true;
            this.borrowDep.Items.AddRange(new object[] {
            "علوم الحاسب",
            "نظم ومعلومات",
            "الذكاء الاصطناعي",
            "المعلوماتية الحيوية"});
            this.borrowDep.Location = new System.Drawing.Point(178, 194);
            this.borrowDep.Name = "borrowDep";
            this.borrowDep.Size = new System.Drawing.Size(339, 44);
            this.borrowDep.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 45);
            this.label7.TabIndex = 40;
            this.label7.Text = "رقم الهاتف *";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_textBox.Location = new System.Drawing.Point(177, 254);
            this.phone_textBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(341, 45);
            this.phone_textBox.TabIndex = 4;
            this.phone_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 496);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.borrowDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.borrowBook);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrowEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrowStName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borrowBookID);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "BorrowBookForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إستعارة كتاب";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borrowBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox borrowStName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox borrowEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker borrowDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button borrowBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox borrowDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_textBox;
    }
}