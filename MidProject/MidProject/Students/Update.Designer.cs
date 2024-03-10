namespace MidProject.Student
{
    partial class Update
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
            this.RegNo_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Contact_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.Gender_CB = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Update_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.RegNo_textBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Email_textBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Contact_textBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LastName_textBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FirstName_textBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Gender_CB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Update_btn, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RegNo_textBox
            // 
            this.RegNo_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegNo_textBox.Location = new System.Drawing.Point(3, 279);
            this.RegNo_textBox.Name = "RegNo_textBox";
            this.RegNo_textBox.Size = new System.Drawing.Size(282, 26);
            this.RegNo_textBox.TabIndex = 6;
            this.RegNo_textBox.Text = "Registration No";
            this.RegNo_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email_textBox.Location = new System.Drawing.Point(3, 141);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(282, 26);
            this.Email_textBox.TabIndex = 3;
            this.Email_textBox.Text = "Email";
            this.Email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contact_textBox
            // 
            this.Contact_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact_textBox.Location = new System.Drawing.Point(3, 95);
            this.Contact_textBox.Name = "Contact_textBox";
            this.Contact_textBox.Size = new System.Drawing.Size(282, 26);
            this.Contact_textBox.TabIndex = 2;
            this.Contact_textBox.Text = "Contact";
            this.Contact_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastName_textBox.Location = new System.Drawing.Point(3, 49);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(282, 26);
            this.LastName_textBox.TabIndex = 1;
            this.LastName_textBox.Text = "LastName";
            this.LastName_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName_textBox.Location = new System.Drawing.Point(3, 3);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(282, 26);
            this.FirstName_textBox.TabIndex = 0;
            this.FirstName_textBox.Text = "FirstName";
            this.FirstName_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gender_CB
            // 
            this.Gender_CB.FormattingEnabled = true;
            this.Gender_CB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_CB.Location = new System.Drawing.Point(3, 233);
            this.Gender_CB.Name = "Gender_CB";
            this.Gender_CB.Size = new System.Drawing.Size(282, 28);
            this.Gender_CB.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Update_btn
            // 
            this.Update_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_btn.Location = new System.Drawing.Point(3, 325);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(282, 66);
            this.Update_btn.TabIndex = 9;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Update";
            this.Text = "Update";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox RegNo_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Contact_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.ComboBox Gender_CB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Update_btn;
    }
}