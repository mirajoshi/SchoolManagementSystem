namespace StudentManagementSystem
{
    partial class ManageCourseForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            button_CourseClear = new Button();
            textBox_CId = new TextBox();
            label2 = new Label();
            textBox_Chours = new TextBox();
            textBox_Cname = new TextBox();
            button_Updatecourse = new Button();
            button_Deletecourse = new Button();
            textBox_desc = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            DataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_search = new TextBox();
            button_search = new Button();
            label7 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button_CourseClear);
            panel2.Controls.Add(textBox_CId);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_Chours);
            panel2.Controls.Add(textBox_Cname);
            panel2.Controls.Add(button_Updatecourse);
            panel2.Controls.Add(button_Deletecourse);
            panel2.Controls.Add(textBox_desc);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 230);
            panel2.TabIndex = 27;
            // 
            // button_CourseClear
            // 
            button_CourseClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_CourseClear.BackColor = Color.DarkGray;
            button_CourseClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CourseClear.ForeColor = Color.White;
            button_CourseClear.Location = new Point(814, 83);
            button_CourseClear.Name = "button_CourseClear";
            button_CourseClear.Size = new Size(109, 32);
            button_CourseClear.TabIndex = 103;
            button_CourseClear.Text = "Clear";
            button_CourseClear.UseVisualStyleBackColor = false;
            button_CourseClear.Click += button_CourseClear_Click;
            // 
            // textBox_CId
            // 
            textBox_CId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_CId.Location = new Point(12, 30);
            textBox_CId.Name = "textBox_CId";
            textBox_CId.Size = new Size(147, 32);
            textBox_CId.TabIndex = 102;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(12, 4);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 101;
            label2.Text = "Course Id :";
            // 
            // textBox_Chours
            // 
            textBox_Chours.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Chours.Location = new Point(463, 30);
            textBox_Chours.Name = "textBox_Chours";
            textBox_Chours.Size = new Size(117, 32);
            textBox_Chours.TabIndex = 100;
            // 
            // textBox_Cname
            // 
            textBox_Cname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Cname.Location = new Point(12, 93);
            textBox_Cname.Name = "textBox_Cname";
            textBox_Cname.Size = new Size(568, 32);
            textBox_Cname.TabIndex = 99;
            // 
            // button_Updatecourse
            // 
            button_Updatecourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Updatecourse.BackColor = Color.DarkGray;
            button_Updatecourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Updatecourse.ForeColor = Color.White;
            button_Updatecourse.Location = new Point(813, 132);
            button_Updatecourse.Name = "button_Updatecourse";
            button_Updatecourse.Size = new Size(109, 32);
            button_Updatecourse.TabIndex = 98;
            button_Updatecourse.Text = "Update";
            button_Updatecourse.UseVisualStyleBackColor = false;
            button_Updatecourse.Click += button_Updatecourse_Click;
            // 
            // button_Deletecourse
            // 
            button_Deletecourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Deletecourse.BackColor = Color.DarkGray;
            button_Deletecourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Deletecourse.ForeColor = Color.White;
            button_Deletecourse.Location = new Point(814, 180);
            button_Deletecourse.Name = "button_Deletecourse";
            button_Deletecourse.Size = new Size(109, 32);
            button_Deletecourse.TabIndex = 97;
            button_Deletecourse.Text = "Delete";
            button_Deletecourse.UseVisualStyleBackColor = false;
            button_Deletecourse.Click += button_Deletecourse_Click;
            // 
            // textBox_desc
            // 
            textBox_desc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_desc.Location = new Point(12, 155);
            textBox_desc.Multiline = true;
            textBox_desc.Name = "textBox_desc";
            textBox_desc.Size = new Size(568, 68);
            textBox_desc.TabIndex = 96;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 95;
            label1.Text = "Description :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(463, 4);
            label8.Name = "label8";
            label8.Size = new Size(76, 23);
            label8.TabIndex = 94;
            label8.Text = "Hours :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.ForeColor = Color.CadetBlue;
            label9.Location = new Point(12, 71);
            label9.Name = "label9";
            label9.Size = new Size(157, 23);
            label9.TabIndex = 93;
            label9.Text = "Course Name :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 59);
            panel1.TabIndex = 26;
            // 
            // DataGridView_course
            // 
            DataGridView_course.AllowUserToAddRows = false;
            DataGridView_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridView_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_course.BackgroundColor = Color.Gainsboro;
            DataGridView_course.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_course.ColumnHeadersHeight = 24;
            DataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridView_course.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridView_course.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.Location = new Point(12, 107);
            DataGridView_course.Name = "DataGridView_course";
            DataGridView_course.RowHeadersVisible = false;
            DataGridView_course.RowHeadersWidth = 51;
            DataGridView_course.RowTemplate.Height = 80;
            DataGridView_course.Size = new Size(911, 268);
            DataGridView_course.TabIndex = 25;
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
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(683, 72);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(126, 32);
            textBox_search.TabIndex = 96;
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
            button_search.TabIndex = 95;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(391, 15);
            label7.Name = "label7";
            label7.Size = new Size(200, 28);
            label7.TabIndex = 1;
            label7.Text = "Manage Course";
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_course);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_course;
        private TextBox textBox_Chours;
        private TextBox textBox_Cname;
        private Button button_Updatecourse;
        private Button button_Deletecourse;
        private TextBox textBox_desc;
        private Label label1;
        private Label label8;
        private Label label9;
        private Button button_CourseClear;
        private TextBox textBox_CId;
        private Label label2;
        private TextBox textBox_search;
        private Button button_search;
        private Label label7;
    }
}