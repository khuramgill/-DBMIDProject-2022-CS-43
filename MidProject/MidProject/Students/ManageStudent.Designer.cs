namespace MidProject.Student
{
    partial class ManageStudent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.Gender_CB = new System.Windows.Forms.ComboBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.RegNo_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Insert_btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Delete_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Update_btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Exit_btn, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.09174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(3, 270);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(194, 101);
            this.Insert_btn.TabIndex = 9;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(3, 377);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(194, 101);
            this.Delete_btn.TabIndex = 10;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(3, 484);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(194, 101);
            this.Update_btn.TabIndex = 11;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Exit_btn.Location = new System.Drawing.Point(3, 591);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(194, 56);
            this.Exit_btn.TabIndex = 12;
            this.Exit_btn.Text = "GoTo Main Menu";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 650);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 492);
            this.panel2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.FirstName_textBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LastName_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Contact_textBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Gender_CB, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Email_textBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RegNo_textBox, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1128, 158);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Industry Professional"});
            this.comboBox1.Location = new System.Drawing.Point(3, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName_textBox.Location = new System.Drawing.Point(3, 3);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(369, 26);
            this.FirstName_textBox.TabIndex = 11;
            this.FirstName_textBox.Text = "First Name";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastName_textBox.Location = new System.Drawing.Point(378, 3);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(370, 26);
            this.LastName_textBox.TabIndex = 12;
            this.LastName_textBox.Text = "Last Name";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker.Location = new System.Drawing.Point(378, 107);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(370, 26);
            this.dateTimePicker.TabIndex = 17;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact_textBox.Location = new System.Drawing.Point(754, 3);
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(371, 26);
            this.Contact_textBox.TabIndex = 13;
            this.Contact_textBox.Text = "Contact Number";
            // 
            // Gender_CB
            // 
            this.Gender_CB.AllowDrop = true;
            this.Gender_CB.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.Gender_CB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender_CB.FormattingEnabled = true;
            this.Gender_CB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_CB.Location = new System.Drawing.Point(754, 55);
            this.Gender_CB.Name = "Gender_CB";
            this.Gender_CB.Size = new System.Drawing.Size(371, 28);
            this.Gender_CB.TabIndex = 16;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email_textBox.Location = new System.Drawing.Point(3, 55);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(369, 26);
            this.Email_textBox.TabIndex = 14;
            this.Email_textBox.Text = "Email";
            // 
            // RegNo_textBox
            // 
            this.RegNo_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegNo_textBox.Location = new System.Drawing.Point(378, 55);
            this.RegNo_textBox.Name = "RegNo_textBox";
            this.RegNo_textBox.Size = new System.Drawing.Size(370, 26);
            this.RegNo_textBox.TabIndex = 15;
            this.RegNo_textBox.Text = "Registration No.";
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.ComboBox Gender_CB;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox RegNo_textBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}