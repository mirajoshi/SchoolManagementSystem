namespace StudentManagementSystem
{
    partial class LoginForm
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
            panel1 = new Panel();
            label_exiticon = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button_login = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label_exiticon);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 56);
            panel1.TabIndex = 0;
            // 
            // label_exiticon
            // 
            label_exiticon.AutoSize = true;
            label_exiticon.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_exiticon.ForeColor = Color.White;
            label_exiticon.Location = new Point(930, 0);
            label_exiticon.Name = "label_exiticon";
            label_exiticon.Size = new Size(20, 19);
            label_exiticon.TabIndex = 8;
            label_exiticon.Text = "X";
            label_exiticon.Click += label_exiticon_Click;
            label_exiticon.MouseEnter += label_exiticon_MouseEnter;
            label_exiticon.MouseLeave += label_exiticon_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 18);
            label1.Name = "label1";
            label1.Size = new Size(234, 19);
            label1.TabIndex = 1;
            label1.Text = "NextGen International School";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.training;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.training__1_;
            pictureBox2.Location = new Point(392, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(392, 282);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 2;
            label2.Text = "Please Login First";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(320, 360);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(308, 27);
            textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(320, 434);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(308, 27);
            textBox_password.TabIndex = 4;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.CadetBlue;
            label3.Location = new Point(320, 336);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 5;
            label3.Text = "Username : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(320, 410);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 6;
            label4.Text = "Password : ";
            // 
            // button_login
            // 
            button_login.BackColor = Color.CadetBlue;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(320, 489);
            button_login.Name = "button_login";
            button_login.Size = new Size(308, 39);
            button_login.TabIndex = 7;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(button_login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Label label3;
        private Label label4;
        private Button button_login;
        private Label label_exiticon;
    }
}