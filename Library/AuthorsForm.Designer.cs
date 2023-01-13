namespace Library
{
    partial class AuthorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.authorData = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.addAuthorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorData)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(524, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(185, 45);
            this.searchBtn.TabIndex = 34;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextBox.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(158, 9);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(360, 45);
            this.searchTextBox.TabIndex = 33;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 32;
            this.label1.Text = "البحث عن مؤلف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 61);
            this.panel2.TabIndex = 38;
            // 
            // authorData
            // 
            this.authorData.AllowUserToAddRows = false;
            this.authorData.AllowUserToDeleteRows = false;
            this.authorData.AllowUserToResizeColumns = false;
            this.authorData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.authorData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.authorData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.authorData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.authorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorData.Location = new System.Drawing.Point(12, 76);
            this.authorData.MultiSelect = false;
            this.authorData.Name = "authorData";
            this.authorData.ReadOnly = true;
            this.authorData.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.authorData.RowTemplate.Height = 50;
            this.authorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorData.Size = new System.Drawing.Size(697, 252);
            this.authorData.TabIndex = 39;
            this.authorData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorData_CellContentClick);
            this.authorData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorData_CellDoubleClick);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.delBtn.BackColor = System.Drawing.Color.Crimson;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(447, 348);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(142, 45);
            this.delBtn.TabIndex = 42;
            this.delBtn.Text = "حذف";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modBtn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtn.ForeColor = System.Drawing.Color.White;
            this.modBtn.Location = new System.Drawing.Point(299, 348);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(142, 45);
            this.modBtn.TabIndex = 41;
            this.modBtn.Text = "تعديل";
            this.modBtn.UseVisualStyleBackColor = false;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // addAuthorBtn
            // 
            this.addAuthorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addAuthorBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addAuthorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorBtn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthorBtn.ForeColor = System.Drawing.Color.White;
            this.addAuthorBtn.Location = new System.Drawing.Point(151, 348);
            this.addAuthorBtn.Name = "addAuthorBtn";
            this.addAuthorBtn.Size = new System.Drawing.Size(142, 45);
            this.addAuthorBtn.TabIndex = 40;
            this.addAuthorBtn.Text = "إضافة";
            this.addAuthorBtn.UseVisualStyleBackColor = false;
            this.addAuthorBtn.Click += new System.EventHandler(this.addAuthorBtn_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 405);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.addAuthorBtn);
            this.Controls.Add(this.authorData);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AuthorsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "المؤلفين";
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.Button addAuthorBtn;
        public System.Windows.Forms.DataGridView authorData;
    }
}