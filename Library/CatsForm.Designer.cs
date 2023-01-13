namespace Library
{
    partial class CatsForm
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
            this.delBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.addCatbutn = new System.Windows.Forms.Button();
            this.catData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.catData)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Crimson;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(212, 270);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(94, 45);
            this.delBtn.TabIndex = 50;
            this.delBtn.Text = "حذف";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.modBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modBtn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modBtn.ForeColor = System.Drawing.Color.White;
            this.modBtn.Location = new System.Drawing.Point(112, 270);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(94, 45);
            this.modBtn.TabIndex = 49;
            this.modBtn.Text = "تعديل";
            this.modBtn.UseVisualStyleBackColor = false;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // addCatbutn
            // 
            this.addCatbutn.BackColor = System.Drawing.Color.SeaGreen;
            this.addCatbutn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatbutn.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatbutn.ForeColor = System.Drawing.Color.White;
            this.addCatbutn.Location = new System.Drawing.Point(12, 270);
            this.addCatbutn.Name = "addCatbutn";
            this.addCatbutn.Size = new System.Drawing.Size(94, 45);
            this.addCatbutn.TabIndex = 48;
            this.addCatbutn.Text = "إضافة";
            this.addCatbutn.UseVisualStyleBackColor = false;
            this.addCatbutn.Click += new System.EventHandler(this.addCatbutn_Click);
            // 
            // catData
            // 
            this.catData.AllowUserToAddRows = false;
            this.catData.AllowUserToDeleteRows = false;
            this.catData.AllowUserToResizeColumns = false;
            this.catData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.catData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.catData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.catData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catData.Location = new System.Drawing.Point(12, 12);
            this.catData.MultiSelect = false;
            this.catData.Name = "catData";
            this.catData.ReadOnly = true;
            this.catData.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.catData.RowTemplate.Height = 50;
            this.catData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catData.Size = new System.Drawing.Size(291, 252);
            this.catData.TabIndex = 47;
            this.catData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catData_CellDoubleClick);
            // 
            // CatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 322);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.addCatbutn);
            this.Controls.Add(this.catData);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "CatsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "التصنيفات";
            this.Load += new System.EventHandler(this.CatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.Button addCatbutn;
        public System.Windows.Forms.DataGridView catData;
    }
}