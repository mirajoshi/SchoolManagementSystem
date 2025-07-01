namespace StudentManagementSystem
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            label1 = new Label();
            ProgressIndicator = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.White;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = SystemColors.Window;
            guna2CircleButton1.Location = new Point(649, -26);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(294, 309);
            guna2CircleButton1.TabIndex = 0;
            // 
            // guna2CircleButton2
            // 
            guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton2.FillColor = Color.White;
            guna2CircleButton2.Font = new Font("Segoe UI", 9F);
            guna2CircleButton2.ForeColor = SystemColors.Window;
            guna2CircleButton2.Location = new Point(-55, 259);
            guna2CircleButton2.Name = "guna2CircleButton2";
            guna2CircleButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton2.Size = new Size(241, 252);
            guna2CircleButton2.TabIndex = 1;
            // 
            // guna2CircleButton3
            // 
            guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton3.FillColor = Color.White;
            guna2CircleButton3.Font = new Font("Segoe UI", 9F);
            guna2CircleButton3.ForeColor = SystemColors.Window;
            guna2CircleButton3.Location = new Point(-55, -65);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(213, 209);
            guna2CircleButton3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 97);
            label1.Name = "label1";
            label1.Size = new Size(497, 28);
            label1.TabIndex = 3;
            label1.Text = "Welcome to NextGen International School";
            // 
            // ProgressIndicator
            // 
            ProgressIndicator.Location = new Point(352, 352);
            ProgressIndicator.Name = "ProgressIndicator";
            ProgressIndicator.ProgressColor = Color.Gainsboro;
            ProgressIndicator.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ProgressIndicator.Size = new Size(79, 74);
            ProgressIndicator.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.training__1_;
            pictureBox1.Location = new Point(345, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(808, 438);
            Controls.Add(pictureBox1);
            Controls.Add(ProgressIndicator);
            Controls.Add(label1);
            Controls.Add(guna2CircleButton3);
            Controls.Add(guna2CircleButton2);
            Controls.Add(guna2CircleButton1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += SplashForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressIndicator;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}