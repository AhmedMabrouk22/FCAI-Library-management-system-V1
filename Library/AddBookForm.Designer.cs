namespace Library
{
    partial class AddBookForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cat = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Button();
            this.publisher = new System.Windows.Forms.Button();
            this.catTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(160, 10);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 45);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(160, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(507, 45);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 45);
            this.label2.TabIndex = 25;
            this.label2.Text = "عنوان الكتاب *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "رقم الكتاب *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(288, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 45);
            this.label4.TabIndex = 28;
            this.label4.Text = "ISBN *";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextBox.Location = new System.Drawing.Point(436, 10);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(231, 45);
            this.ISBNTextBox.TabIndex = 1;
            this.ISBNTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Crimson;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(12, 391);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(655, 49);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "إضافة";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cat
            // 
            this.cat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cat.Font = new System.Drawing.Font("Cairo", 14.25F);
            this.cat.ForeColor = System.Drawing.Color.White;
            this.cat.Location = new System.Drawing.Point(12, 211);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(142, 45);
            this.cat.TabIndex = 4;
            this.cat.Text = "التصنيف *";
            this.cat.UseVisualStyleBackColor = false;
            this.cat.Click += new System.EventHandler(this.cat_Click);
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.Teal;
            this.author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.author.Font = new System.Drawing.Font("Cairo", 14.25F);
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(12, 276);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(142, 45);
            this.author.TabIndex = 5;
            this.author.Text = "المؤلف";
            this.author.UseVisualStyleBackColor = false;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // publisher
            // 
            this.publisher.BackColor = System.Drawing.Color.OrangeRed;
            this.publisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publisher.Font = new System.Drawing.Font("Cairo", 14.25F);
            this.publisher.ForeColor = System.Drawing.Color.White;
            this.publisher.Location = new System.Drawing.Point(12, 340);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(142, 45);
            this.publisher.TabIndex = 6;
            this.publisher.Text = "دار النشر";
            this.publisher.UseVisualStyleBackColor = false;
            this.publisher.Click += new System.EventHandler(this.publisher_Click);
            // 
            // catTextBox
            // 
            this.catTextBox.Enabled = false;
            this.catTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTextBox.Location = new System.Drawing.Point(160, 211);
            this.catTextBox.Name = "catTextBox";
            this.catTextBox.Size = new System.Drawing.Size(507, 45);
            this.catTextBox.TabIndex = 32;
            this.catTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Enabled = false;
            this.authorTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(160, 276);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(507, 45);
            this.authorTextBox.TabIndex = 33;
            this.authorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.Enabled = false;
            this.publisherTextbox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextbox.Location = new System.Drawing.Point(160, 340);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Size = new System.Drawing.Size(507, 45);
            this.publisherTextbox.TabIndex = 34;
            this.publisherTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 45);
            this.label1.TabIndex = 36;
            this.label1.Text = "الطبعة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editionTextBox
            // 
            this.editionTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editionTextBox.Location = new System.Drawing.Point(160, 142);
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.Size = new System.Drawing.Size(507, 45);
            this.editionTextBox.TabIndex = 3;
            this.editionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editionTextBox);
            this.Controls.Add(this.publisherTextbox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.catTextBox);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.author);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "إضافة كتاب";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cat;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Button publisher;
        public System.Windows.Forms.TextBox catTextBox;
        public System.Windows.Forms.TextBox authorTextBox;
        public System.Windows.Forms.TextBox publisherTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editionTextBox;
    }
}