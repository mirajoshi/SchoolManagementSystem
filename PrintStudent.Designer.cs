namespace StudentManagementSystem
{
    partial class PrintStudent
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
            panel2 = new Panel();
            button_print = new Button();
            radioButton_all = new RadioButton();
            radioButton_femaleP = new RadioButton();
            radioButton_maleP = new RadioButton();
            label1 = new Label();
            panel3 = new Panel();
            DataGridView_PrintStd = new Guna.UI2.WinForms.Guna2DataGridView();
            label2 = new Label();
            button_search = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_PrintStd).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 79);
            panel1.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(490, 25);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 0;
            label7.Text = "To Print";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_print);
            panel2.Controls.Add(radioButton_all);
            panel2.Controls.Add(radioButton_femaleP);
            panel2.Controls.Add(radioButton_maleP);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 671);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 133);
            panel2.TabIndex = 42;
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.DarkGray;
            button_print.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(932, 77);
            button_print.Margin = new Padding(3, 4, 3, 4);
            button_print.Name = "button_print";
            button_print.Size = new Size(126, 43);
            button_print.TabIndex = 71;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_all.AutoSize = true;
            radioButton_all.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_all.ForeColor = Color.CadetBlue;
            radioButton_all.Location = new Point(107, 58);
            radioButton_all.Margin = new Padding(3, 4, 3, 4);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(56, 27);
            radioButton_all.TabIndex = 4;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_femaleP
            // 
            radioButton_femaleP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_femaleP.AutoSize = true;
            radioButton_femaleP.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_femaleP.ForeColor = Color.CadetBlue;
            radioButton_femaleP.Location = new Point(250, 58);
            radioButton_femaleP.Margin = new Padding(3, 4, 3, 4);
            radioButton_femaleP.Name = "radioButton_femaleP";
            radioButton_femaleP.Size = new Size(104, 27);
            radioButton_femaleP.TabIndex = 3;
            radioButton_femaleP.TabStop = true;
            radioButton_femaleP.Text = "Female";
            radioButton_femaleP.UseVisualStyleBackColor = true;
            // 
            // radioButton_maleP
            // 
            radioButton_maleP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton_maleP.AutoSize = true;
            radioButton_maleP.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_maleP.ForeColor = Color.CadetBlue;
            radioButton_maleP.Location = new Point(168, 58);
            radioButton_maleP.Margin = new Padding(3, 4, 3, 4);
            radioButton_maleP.Name = "radioButton_maleP";
            radioButton_maleP.Size = new Size(80, 27);
            radioButton_maleP.TabIndex = 2;
            radioButton_maleP.TabStop = true;
            radioButton_maleP.Text = "Male";
            radioButton_maleP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 1;
            label1.Text = "Gender :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Location = new Point(14, 5);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1040, 11);
            panel3.TabIndex = 0;
            // 
            // DataGridView_PrintStd
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_PrintStd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_PrintStd.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_PrintStd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_PrintStd.ColumnHeadersHeight = 28;
            DataGridView_PrintStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_PrintStd.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_PrintStd.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_PrintStd.Location = new Point(12, 145);
            DataGridView_PrintStd.Margin = new Padding(3, 4, 3, 4);
            DataGridView_PrintStd.Name = "DataGridView_PrintStd";
            DataGridView_PrintStd.RowHeadersVisible = false;
            DataGridView_PrintStd.RowHeadersWidth = 51;
            DataGridView_PrintStd.RowTemplate.Height = 25;
            DataGridView_PrintStd.Size = new Size(1046, 528);
            DataGridView_PrintStd.TabIndex = 43;
            DataGridView_PrintStd.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_PrintStd.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_PrintStd.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_PrintStd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_PrintStd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_PrintStd.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_PrintStd.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_PrintStd.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_PrintStd.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_PrintStd.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DataGridView_PrintStd.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_PrintStd.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_PrintStd.ThemeStyle.HeaderStyle.Height = 28;
            DataGridView_PrintStd.ThemeStyle.ReadOnly = false;
            DataGridView_PrintStd.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_PrintStd.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_PrintStd.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DataGridView_PrintStd.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_PrintStd.ThemeStyle.RowsStyle.Height = 25;
            DataGridView_PrintStd.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_PrintStd.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(598, 97);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 72;
            label2.Text = "Select Class :";
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.DarkGray;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(928, 87);
            button_search.Margin = new Padding(3, 4, 3, 4);
            button_search.Name = "button_search";
            button_search.Size = new Size(126, 43);
            button_search.TabIndex = 73;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // PrintStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 804);
            Controls.Add(button_search);
            Controls.Add(label2);
            Controls.Add(DataGridView_PrintStd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintStudent";
            Text = "PrintStudent";
            Load += PrintStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_PrintStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_PrintStd;
        private Panel panel3;
        private Label label1;
        private RadioButton radioButton_maleP;
        private RadioButton radioButton_all;
        private RadioButton radioButton_femaleP;
        private Button button_print;
        private Label label2;
        private Button button_search;
    }
}