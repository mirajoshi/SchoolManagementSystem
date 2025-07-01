namespace StudentManagementSystem
{
    partial class CourseForm
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
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            textBox_description = new TextBox();
            button_clearcourse = new Button();
            textBox_Cname = new TextBox();
            textBox_Chours = new TextBox();
            panel2 = new Panel();
            button_addcourse = new Button();
            DataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).BeginInit();
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
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(421, 18);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 0;
            label7.Text = "New Course";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.ForeColor = Color.CadetBlue;
            label9.Location = new Point(12, 18);
            label9.Name = "label9";
            label9.Size = new Size(123, 19);
            label9.TabIndex = 77;
            label9.Text = "Course Name :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(12, 83);
            label8.Name = "label8";
            label8.Size = new Size(59, 19);
            label8.TabIndex = 78;
            label8.Text = "Hours :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(12, 146);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 84;
            label5.Text = "Description :";
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(12, 168);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(568, 68);
            textBox_description.TabIndex = 85;
            // 
            // button_clearcourse
            // 
            button_clearcourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearcourse.BackColor = Color.DarkGray;
            button_clearcourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clearcourse.ForeColor = Color.White;
            button_clearcourse.Location = new Point(679, 204);
            button_clearcourse.Name = "button_clearcourse";
            button_clearcourse.Size = new Size(109, 32);
            button_clearcourse.TabIndex = 90;
            button_clearcourse.Text = "Clear";
            button_clearcourse.UseVisualStyleBackColor = false;
            button_clearcourse.Click += button_clearcourse_Click;
            // 
            // textBox_Cname
            // 
            textBox_Cname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Cname.Location = new Point(12, 40);
            textBox_Cname.Name = "textBox_Cname";
            textBox_Cname.Size = new Size(568, 27);
            textBox_Cname.TabIndex = 91;
            // 
            // textBox_Chours
            // 
            textBox_Chours.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Chours.Location = new Point(12, 105);
            textBox_Chours.Name = "textBox_Chours";
            textBox_Chours.Size = new Size(117, 27);
            textBox_Chours.TabIndex = 92;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox_Chours);
            panel2.Controls.Add(textBox_Cname);
            panel2.Controls.Add(button_clearcourse);
            panel2.Controls.Add(button_addcourse);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 357);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 256);
            panel2.TabIndex = 24;
            // 
            // button_addcourse
            // 
            button_addcourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addcourse.BackColor = Color.DarkGray;
            button_addcourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addcourse.ForeColor = Color.White;
            button_addcourse.Location = new Point(814, 204);
            button_addcourse.Name = "button_addcourse";
            button_addcourse.Size = new Size(109, 32);
            button_addcourse.TabIndex = 89;
            button_addcourse.Text = "Add";
            button_addcourse.UseVisualStyleBackColor = false;
            button_addcourse.Click += button_addcourse_Click;
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
            DataGridView_course.Location = new Point(12, 67);
            DataGridView_course.Name = "DataGridView_course";
            DataGridView_course.RowHeadersVisible = false;
            DataGridView_course.RowTemplate.Height = 80;
            DataGridView_course.Size = new Size(911, 284);
            DataGridView_course.TabIndex = 22;
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
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_course);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label5;
        private TextBox textBox_description;
        private Button button_clearcourse;
        private TextBox textBox_Cname;
        private TextBox textBox_Chours;
        private Panel panel2;
        private Button button_addcourse;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_course;
    }
}