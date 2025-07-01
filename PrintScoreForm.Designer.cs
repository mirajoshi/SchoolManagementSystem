namespace StudentManagementSystem
{
    partial class PrintScoreForm
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
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            button_PrintScore = new Button();
            panel3 = new Panel();
            textBox_search = new TextBox();
            button_search = new Button();
            DataGridView_PrintStd = new Guna.UI2.WinForms.Guna2DataGridView();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 59);
            panel1.TabIndex = 81;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(373, 19);
            label7.Name = "label7";
            label7.Size = new Size(228, 28);
            label7.TabIndex = 0;
            label7.Text = "NextGen Score List";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_PrintScore);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 704);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 100);
            panel2.TabIndex = 82;
            // 
            // button_PrintScore
            // 
            button_PrintScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_PrintScore.BackColor = Color.DarkGray;
            button_PrintScore.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_PrintScore.ForeColor = Color.White;
            button_PrintScore.Location = new Point(948, 56);
            button_PrintScore.Name = "button_PrintScore";
            button_PrintScore.Size = new Size(110, 32);
            button_PrintScore.TabIndex = 73;
            button_PrintScore.Text = "Print";
            button_PrintScore.UseVisualStyleBackColor = false;
            button_PrintScore.Click += button_PrintScore_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Location = new Point(12, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 8);
            panel3.TabIndex = 0;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(798, 70);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(144, 32);
            textBox_search.TabIndex = 85;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.DarkGray;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(948, 67);
            button_search.Name = "button_search";
            button_search.Size = new Size(110, 32);
            button_search.TabIndex = 84;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // DataGridView_PrintStd
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridView_PrintStd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_PrintStd.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView_PrintStd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_PrintStd.ColumnHeadersHeight = 28;
            DataGridView_PrintStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridView_PrintStd.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridView_PrintStd.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_PrintStd.Location = new Point(12, 109);
            DataGridView_PrintStd.Name = "DataGridView_PrintStd";
            DataGridView_PrintStd.RowHeadersVisible = false;
            DataGridView_PrintStd.RowHeadersWidth = 51;
            DataGridView_PrintStd.RowTemplate.Height = 25;
            DataGridView_PrintStd.Size = new Size(1046, 396);
            DataGridView_PrintStd.TabIndex = 83;
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
            // PrintScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 804);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(DataGridView_PrintStd);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PrintScoreForm";
            Text = "PrintScoreForm";
            Load += PrintScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_PrintStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox_search;
        private Button button_search;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_PrintStd;
        private Button button_PrintScore;
    }
}