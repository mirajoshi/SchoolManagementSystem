namespace StudentManagementSystem
{
    partial class ManageScoreForm
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
            panel1 = new Panel();
            label7 = new Label();
            button_CourseClear = new Button();
            button_Updatecourse = new Button();
            button_Deletecourse = new Button();
            DataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            button_clearcourse = new Button();
            button_addcourse = new Button();
            button_search = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_phone = new TextBox();
            button_add = new Button();
            label6 = new Label();
            button_upload = new Button();
            pictureBox_student = new PictureBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            textBox_search = new TextBox();
            button_clear = new Button();
            panel2 = new Panel();
            comboBox_SelectCourse = new ComboBox();
            label1 = new Label();
            textBox_Score = new TextBox();
            textBox_StdId = new TextBox();
            textBox_Desc = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            button_ClearScore = new Button();
            button_UpdateScore = new Button();
            buttonDeleteScore = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 59);
            panel1.TabIndex = 98;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(392, 16);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 0;
            label7.Text = "Manage Score";
            // 
            // button_CourseClear
            // 
            button_CourseClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_CourseClear.BackColor = Color.DarkGray;
            button_CourseClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CourseClear.ForeColor = Color.White;
            button_CourseClear.Location = new Point(1548, 213);
            button_CourseClear.Name = "button_CourseClear";
            button_CourseClear.Size = new Size(109, 32);
            button_CourseClear.TabIndex = 103;
            button_CourseClear.Text = "Clear";
            button_CourseClear.UseVisualStyleBackColor = false;
            // 
            // button_Updatecourse
            // 
            button_Updatecourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Updatecourse.BackColor = Color.DarkGray;
            button_Updatecourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Updatecourse.ForeColor = Color.White;
            button_Updatecourse.Location = new Point(1547, 262);
            button_Updatecourse.Name = "button_Updatecourse";
            button_Updatecourse.Size = new Size(109, 32);
            button_Updatecourse.TabIndex = 98;
            button_Updatecourse.Text = "Update";
            button_Updatecourse.UseVisualStyleBackColor = false;
            // 
            // button_Deletecourse
            // 
            button_Deletecourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Deletecourse.BackColor = Color.DarkGray;
            button_Deletecourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Deletecourse.ForeColor = Color.White;
            button_Deletecourse.Location = new Point(1548, 310);
            button_Deletecourse.Name = "button_Deletecourse";
            button_Deletecourse.Size = new Size(109, 32);
            button_Deletecourse.TabIndex = 97;
            button_Deletecourse.Text = "Delete";
            button_Deletecourse.UseVisualStyleBackColor = false;
            // 
            // DataGridView_course
            // 
            DataGridView_course.AllowUserToAddRows = false;
            DataGridView_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_course.BackgroundColor = Color.Gainsboro;
            DataGridView_course.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_course.ColumnHeadersHeight = 24;
            DataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_course.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_course.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.Location = new Point(12, 107);
            DataGridView_course.Name = "DataGridView_course";
            DataGridView_course.RowHeadersVisible = false;
            DataGridView_course.RowTemplate.Height = 80;
            DataGridView_course.Size = new Size(910, 268);
            DataGridView_course.TabIndex = 97;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_course.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_course.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_course.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_course.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_course.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_course.ThemeStyle.ReadOnly = false;
            DataGridView_course.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_course.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_course.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_course.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.Click += DataGridView_course_Click;
            // 
            // button_clearcourse
            // 
            button_clearcourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearcourse.BackColor = Color.DarkGray;
            button_clearcourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clearcourse.ForeColor = Color.White;
            button_clearcourse.Location = new Point(2147, 465);
            button_clearcourse.Name = "button_clearcourse";
            button_clearcourse.Size = new Size(109, 32);
            button_clearcourse.TabIndex = 90;
            button_clearcourse.Text = "Clear";
            button_clearcourse.UseVisualStyleBackColor = false;
            // 
            // button_addcourse
            // 
            button_addcourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addcourse.BackColor = Color.DarkGray;
            button_addcourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addcourse.ForeColor = Color.White;
            button_addcourse.Location = new Point(2282, 465);
            button_addcourse.Name = "button_addcourse";
            button_addcourse.Size = new Size(109, 32);
            button_addcourse.TabIndex = 89;
            button_addcourse.Text = "Add";
            button_addcourse.UseVisualStyleBackColor = false;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.DarkGray;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(815, 69);
            button_search.Name = "button_search";
            button_search.Size = new Size(109, 32);
            button_search.TabIndex = 100;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(12, 429);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(568, 68);
            textBox_description.TabIndex = 85;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(12, 407);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 84;
            label5.Text = "Description :";
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Location = new Point(1778, 228);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(126, 27);
            textBox_phone.TabIndex = 76;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.DarkGray;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(3021, 628);
            button_add.Name = "button_add";
            button_add.Size = new Size(109, 32);
            button_add.TabIndex = 72;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.CadetBlue;
            label6.Location = new Point(1706, 232);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 71;
            label6.Text = "Phone :";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.None;
            button_upload.BackColor = Color.DarkGray;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(1919, 349);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(110, 32);
            button_upload.TabIndex = 70;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.None;
            pictureBox_student.BackColor = Color.LightGray;
            pictureBox_student.Location = new Point(1919, 228);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(110, 108);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 69;
            pictureBox_student.TabStop = false;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.CadetBlue;
            radioButton_female.Location = new Point(1818, 271);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(86, 23);
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
            radioButton_male.Location = new Point(1744, 272);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(66, 23);
            radioButton_male.TabIndex = 65;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(683, 72);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(126, 27);
            textBox_search.TabIndex = 101;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.DarkGray;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(2896, 628);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(109, 32);
            button_clear.TabIndex = 73;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox_SelectCourse);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_Score);
            panel2.Controls.Add(textBox_StdId);
            panel2.Controls.Add(textBox_Desc);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(button_ClearScore);
            panel2.Controls.Add(button_UpdateScore);
            panel2.Controls.Add(buttonDeleteScore);
            panel2.Controls.Add(button_CourseClear);
            panel2.Controls.Add(button_Updatecourse);
            panel2.Controls.Add(button_Deletecourse);
            panel2.Controls.Add(button_clearcourse);
            panel2.Controls.Add(button_addcourse);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_student);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 230);
            panel2.TabIndex = 99;
            // 
            // comboBox_SelectCourse
            // 
            comboBox_SelectCourse.FormattingEnabled = true;
            comboBox_SelectCourse.Location = new Point(142, 55);
            comboBox_SelectCourse.Name = "comboBox_SelectCourse";
            comboBox_SelectCourse.Size = new Size(442, 29);
            comboBox_SelectCourse.TabIndex = 107;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(16, 60);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 114;
            label1.Text = "Select Course :";
            // 
            // textBox_Score
            // 
            textBox_Score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Score.Location = new Point(142, 100);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(117, 27);
            textBox_Score.TabIndex = 113;
            // 
            // textBox_StdId
            // 
            textBox_StdId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_StdId.Location = new Point(142, 11);
            textBox_StdId.Name = "textBox_StdId";
            textBox_StdId.Size = new Size(113, 27);
            textBox_StdId.TabIndex = 112;
            // 
            // textBox_Desc
            // 
            textBox_Desc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Desc.Location = new Point(142, 149);
            textBox_Desc.Multiline = true;
            textBox_Desc.Name = "textBox_Desc";
            textBox_Desc.Size = new Size(442, 68);
            textBox_Desc.TabIndex = 111;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(34, 149);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 110;
            label2.Text = "Description :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(76, 104);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 109;
            label8.Text = "Score :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.ForeColor = Color.CadetBlue;
            label9.Location = new Point(43, 15);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 108;
            label9.Text = "Student Id :";
            // 
            // button_ClearScore
            // 
            button_ClearScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_ClearScore.BackColor = Color.DarkGray;
            button_ClearScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ClearScore.ForeColor = Color.White;
            button_ClearScore.Location = new Point(813, 89);
            button_ClearScore.Name = "button_ClearScore";
            button_ClearScore.Size = new Size(109, 32);
            button_ClearScore.TabIndex = 106;
            button_ClearScore.Text = "Clear";
            button_ClearScore.UseVisualStyleBackColor = false;
            button_ClearScore.Click += button_ClearScore_Click;
            // 
            // button_UpdateScore
            // 
            button_UpdateScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_UpdateScore.BackColor = Color.DarkGray;
            button_UpdateScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_UpdateScore.ForeColor = Color.White;
            button_UpdateScore.Location = new Point(812, 138);
            button_UpdateScore.Name = "button_UpdateScore";
            button_UpdateScore.Size = new Size(109, 32);
            button_UpdateScore.TabIndex = 105;
            button_UpdateScore.Text = "Update";
            button_UpdateScore.UseVisualStyleBackColor = false;
            button_UpdateScore.Click += button_UpdateScore_Click;
            // 
            // buttonDeleteScore
            // 
            buttonDeleteScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeleteScore.BackColor = Color.DarkGray;
            buttonDeleteScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteScore.ForeColor = Color.White;
            buttonDeleteScore.Location = new Point(813, 186);
            buttonDeleteScore.Name = "buttonDeleteScore";
            buttonDeleteScore.Size = new Size(109, 32);
            buttonDeleteScore.TabIndex = 104;
            buttonDeleteScore.Text = "Delete";
            buttonDeleteScore.UseVisualStyleBackColor = false;
            buttonDeleteScore.Click += buttonDeleteScore_Click;
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(panel1);
            Controls.Add(DataGridView_course);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ManageScoreForm";
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button button_CourseClear;
        private Button button_Updatecourse;
        private Button button_Deletecourse;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_course;
        private Button button_clearcourse;
        private Button button_addcourse;
        private Button button_search;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_phone;
        private Button button_add;
        private Label label6;
        private Button button_upload;
        private PictureBox pictureBox_student;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private TextBox textBox_search;
        private Button button_clear;
        private Panel panel2;
        private Button button_ClearScore;
        private Button button_UpdateScore;
        private Button buttonDeleteScore;
        private ComboBox comboBox_SelectCourse;
        private Label label1;
        private TextBox textBox_Score;
        private TextBox textBox_StdId;
        private TextBox textBox_Desc;
        private Label label2;
        private Label label8;
        private Label label9;
    }
}