namespace PhoneBookSaitOrhan
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPhoneBook = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gbPhoneBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.deleteSelectedRowToolStripMenuItem,
            this.updateSelectedRowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // gbPhoneBook
            // 
            this.gbPhoneBook.Controls.Add(this.dataGridView1);
            this.gbPhoneBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPhoneBook.Location = new System.Drawing.Point(0, 28);
            this.gbPhoneBook.Name = "gbPhoneBook";
            this.gbPhoneBook.Size = new System.Drawing.Size(1193, 559);
            this.gbPhoneBook.TabIndex = 1;
            this.gbPhoneBook.TabStop = false;
            this.gbPhoneBook.Text = "Phone Book";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Id,
            this.C_NameSurname,
            this.C_Email,
            this.C_Phone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // C_Id
            // 
            this.C_Id.HeaderText = "Id";
            this.C_Id.MinimumWidth = 6;
            this.C_Id.Name = "C_Id";
            this.C_Id.ReadOnly = true;
            this.C_Id.Visible = false;
            // 
            // C_NameSurname
            // 
            this.C_NameSurname.HeaderText = "Name Surname";
            this.C_NameSurname.MinimumWidth = 6;
            this.C_NameSurname.Name = "C_NameSurname";
            this.C_NameSurname.ReadOnly = true;
            // 
            // C_Email
            // 
            this.C_Email.HeaderText = "E-Mail";
            this.C_Email.MinimumWidth = 6;
            this.C_Email.Name = "C_Email";
            this.C_Email.ReadOnly = true;
            // 
            // C_Phone
            // 
            this.C_Phone.HeaderText = "Phone";
            this.C_Phone.MinimumWidth = 6;
            this.C_Phone.Name = "C_Phone";
            this.C_Phone.ReadOnly = true;
            // 
            // deleteSelectedRowToolStripMenuItem
            // 
            this.deleteSelectedRowToolStripMenuItem.Name = "deleteSelectedRowToolStripMenuItem";
            this.deleteSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.deleteSelectedRowToolStripMenuItem.Text = "Delete Selected Row";
            this.deleteSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedRowToolStripMenuItem_Click);
            // 
            // updateSelectedRowToolStripMenuItem
            // 
            this.updateSelectedRowToolStripMenuItem.Name = "updateSelectedRowToolStripMenuItem";
            this.updateSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.updateSelectedRowToolStripMenuItem.Text = "Update Selected Row";
            this.updateSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.updateSelectedRowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 587);
            this.Controls.Add(this.gbPhoneBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPhoneBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPhoneBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Phone;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSelectedRowToolStripMenuItem;
    }
}

