namespace StudentManagementSystem
{
    partial class ScoreForm
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
            DataGridView_Student = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_Score = new TextBox();
            textBox_StdId = new TextBox();
            textBox_description = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            comboBox_SelectCourse = new ComboBox();
            label1 = new Label();
            button_ClearScore = new Button();
            button_AddScore = new Button();
            panel1 = new Panel();
            button_sScore = new Button();
            button_sStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Student).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView_Student
            // 
            DataGridView_Student.AllowUserToAddRows = false;
            DataGridView_Student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_Student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_Student.BackgroundColor = Color.Gainsboro;
            DataGridView_Student.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_Student.ColumnHeadersHeight = 24;
            DataGridView_Student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_Student.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_Student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Student.Location = new Point(12, 66);
            DataGridView_Student.Name = "DataGridView_Student";
            DataGridView_Student.RowHeadersVisible = false;
            DataGridView_Student.RowHeadersWidth = 51;
            DataGridView_Student.RowTemplate.Height = 80;
            DataGridView_Student.Size = new Size(910, 284);
            DataGridView_Student.TabIndex = 25;
            DataGridView_Student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_Student.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_Student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_Student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_Student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_Student.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_Student.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_Student.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_Student.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_Student.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_Student.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_Student.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_Student.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_Student.ThemeStyle.ReadOnly = false;
            DataGridView_Student.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_Student.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_Student.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_Student.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Student.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_Student.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_Student.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_Student.Click += DataGridView_Student_Click;
            // 
            // textBox_Score
            // 
            textBox_Score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Score.Location = new Point(155, 113);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(117, 32);
            textBox_Score.TabIndex = 92;
            // 
            // textBox_StdId
            // 
            textBox_StdId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_StdId.Location = new Point(164, 21);
            textBox_StdId.Name = "textBox_StdId";
            textBox_StdId.Size = new Size(113, 32);
            textBox_StdId.TabIndex = 91;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(167, 158);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(442, 68);
            textBox_description.TabIndex = 85;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(30, 158);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 84;
            label5.Text = "Description :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.ForeColor = Color.CadetBlue;
            label8.Location = new Point(72, 113);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 78;
            label8.Text = "Score :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.ForeColor = Color.CadetBlue;
            label9.Location = new Point(39, 24);
            label9.Name = "label9";
            label9.Size = new Size(119, 23);
            label9.TabIndex = 77;
            label9.Text = "Student Id :";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(comboBox_SelectCourse);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button_ClearScore);
            panel2.Controls.Add(button_AddScore);
            panel2.Controls.Add(textBox_Score);
            panel2.Controls.Add(textBox_StdId);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 256);
            panel2.TabIndex = 27;
            // 
            // comboBox_SelectCourse
            // 
            comboBox_SelectCourse.FormattingEnabled = true;
            comboBox_SelectCourse.Location = new Point(175, 66);
            comboBox_SelectCourse.Name = "comboBox_SelectCourse";
            comboBox_SelectCourse.Size = new Size(442, 31);
            comboBox_SelectCourse.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 97;
            label1.Text = "Select Course :";
            // 
            // button_ClearScore
            // 
            button_ClearScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_ClearScore.BackColor = Color.DarkGray;
            button_ClearScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ClearScore.ForeColor = Color.White;
            button_ClearScore.Location = new Point(678, 194);
            button_ClearScore.Name = "button_ClearScore";
            button_ClearScore.Size = new Size(109, 32);
            button_ClearScore.TabIndex = 94;
            button_ClearScore.Text = "Clear";
            button_ClearScore.UseVisualStyleBackColor = false;
            button_ClearScore.Click += button_ClearScore_Click;
            // 
            // button_AddScore
            // 
            button_AddScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_AddScore.BackColor = Color.DarkGray;
            button_AddScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_AddScore.ForeColor = Color.White;
            button_AddScore.Location = new Point(813, 194);
            button_AddScore.Name = "button_AddScore";
            button_AddScore.Size = new Size(109, 32);
            button_AddScore.TabIndex = 93;
            button_AddScore.Text = "Add";
            button_AddScore.UseVisualStyleBackColor = false;
            button_AddScore.Click += button_AddScore_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(button_sScore);
            panel1.Controls.Add(button_sStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 59);
            panel1.TabIndex = 26;
            // 
            // button_sScore
            // 
            button_sScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_sScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sScore.ForeColor = Color.CadetBlue;
            button_sScore.Location = new Point(751, 12);
            button_sScore.Name = "button_sScore";
            button_sScore.Size = new Size(171, 30);
            button_sScore.TabIndex = 1;
            button_sScore.Text = "Show Score";
            button_sScore.UseVisualStyleBackColor = true;
            button_sScore.Click += button_sScore_Click;
            // 
            // button_sStudent
            // 
            button_sStudent.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sStudent.ForeColor = Color.CadetBlue;
            button_sStudent.Location = new Point(12, 12);
            button_sStudent.Name = "button_sStudent";
            button_sStudent.Size = new Size(185, 30);
            button_sStudent.TabIndex = 0;
            button_sStudent.Text = "Show Student";
            button_sStudent.UseVisualStyleBackColor = true;
            button_sStudent.Click += button_sStudent_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(DataGridView_Student);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_Student).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Student;
        private TextBox textBox_Score;
        private TextBox textBox_StdId;
        private TextBox textBox_description;
        private Label label5;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Panel panel1;
        private Button button_ClearScore;
        private Button button_AddScore;
        private Label label1;
        private ComboBox comboBox_SelectCourse;
        private Button button_sScore;
        private Button button_sStudent;
    }
}