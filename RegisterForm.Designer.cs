namespace StudentManagementSystem
{
    partial class RegisterForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            textBox_phone = new TextBox();
            textBox_Lname = new TextBox();
            textBox_Fname = new TextBox();
            button_clear = new Button();
            button_add = new Button();
            label6 = new Label();
            button_upload = new Button();
            pictureBox_student = new PictureBox();
            textBox_address = new TextBox();
            label5 = new Label();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            SuspendLayout();
            // 
            // DataGridView_student
            // 
            DataGridView_student.AllowUserToAddRows = false;
            DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_student.BackgroundColor = Color.Gainsboro;
            DataGridView_student.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_student.ColumnHeadersHeight = 24;
            DataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.Location = new Point(12, 65);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(1047, 477);
            DataGridView_student.TabIndex = 3;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_student.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_student.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_student.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_student.ThemeStyle.ReadOnly = false;
            DataGridView_student.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_student.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_student.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_student.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 59);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(421, 16);
            label7.Name = "label7";
            label7.Size = new Size(147, 28);
            label7.TabIndex = 0;
            label7.Text = "Registration";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(textBox_Lname);
            panel2.Controls.Add(textBox_Fname);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_student);
            panel2.Controls.Add(textBox_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 548);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 256);
            panel2.TabIndex = 21;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Location = new Point(714, 20);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(170, 32);
            textBox_phone.TabIndex = 76;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Anchor = AnchorStyles.None;
            textBox_Lname.Location = new Point(449, 20);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(170, 32);
            textBox_Lname.TabIndex = 75;
            // 
            // textBox_Fname
            // 
            textBox_Fname.Anchor = AnchorStyles.None;
            textBox_Fname.Location = new Point(142, 20);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(170, 32);
            textBox_Fname.TabIndex = 74;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.DarkGray;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(780, 206);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(135, 44);
            button_clear.TabIndex = 73;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click_1;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.DarkGray;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(923, 206);
            button_add.Name = "button_add";
            button_add.Size = new Size(135, 44);
            button_add.TabIndex = 72;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(625, 25);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 71;
            label6.Text = "Phone :";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.None;
            button_upload.BackColor = Color.DarkGray;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(923, 141);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(135, 44);
            button_upload.TabIndex = 70;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click_1;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.None;
            pictureBox_student.BackColor = Color.LightGray;
            pictureBox_student.Location = new Point(923, 15);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(135, 108);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 69;
            pictureBox_student.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.None;
            textBox_address.Location = new Point(118, 120);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(766, 68);
            textBox_address.TabIndex = 68;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(12, 120);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 67;
            label5.Text = "Address :";
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.CadetBlue;
            radioButton_female.Location = new Point(780, 72);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(104, 27);
            radioButton_female.TabIndex = 66;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.None;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.CadetBlue;
            radioButton_male.Location = new Point(694, 72);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 65;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(592, 74);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 64;
            label4.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(162, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 32);
            dateTimePicker1.TabIndex = 63;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 62;
            label3.Text = "Date Of Birth :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(318, 25);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 61;
            label2.Text = "Last Name :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 60;
            label1.Text = "First Name :";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1070, 804);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_student);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private TextBox textBox_phone;
        private TextBox textBox_Lname;
        private TextBox textBox_Fname;
        private Button button_clear;
        private Button button_add;
        private Label label6;
        private Button button_upload;
        private PictureBox pictureBox_student;
        private TextBox textBox_address;
        private Label label5;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}