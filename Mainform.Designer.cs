namespace StudentManagementSystem
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_slide = new Panel();
            button_exit = new Button();
            button_dashboard = new Button();
            panel_scoresubmenu = new Panel();
            button_scoreprint = new Button();
            button_managescore = new Button();
            button_newscore = new Button();
            button_score = new Button();
            panel_coursesubmenu = new Panel();
            button_courseprint = new Button();
            button_managecourse = new Button();
            button_newcourse = new Button();
            button_course = new Button();
            panel_stdsubmenu = new Panel();
            button_print = new Button();
            button_status = new Button();
            button_managestd = new Button();
            button_registration = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label_femaleStd = new Label();
            label_maleStd = new Label();
            label_totalStd = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            panel_slide.SuspendLayout();
            panel_scoresubmenu.SuspendLayout();
            panel_coursesubmenu.SuspendLayout();
            panel_stdsubmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.CadetBlue;
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(panel_scoresubmenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_coursesubmenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_stdsubmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Margin = new Padding(3, 4, 3, 4);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(208, 804);
            panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 821);
            button_exit.Margin = new Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(11, 0, 0, 0);
            button_exit.Size = new Size(187, 55);
            button_exit.TabIndex = 8;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 765);
            button_dashboard.Margin = new Padding(3, 4, 3, 4);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(11, 0, 0, 0);
            button_dashboard.Size = new Size(187, 56);
            button_dashboard.TabIndex = 7;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click_1;
            // 
            // panel_scoresubmenu
            // 
            panel_scoresubmenu.BackColor = Color.Azure;
            panel_scoresubmenu.Controls.Add(button_scoreprint);
            panel_scoresubmenu.Controls.Add(button_managescore);
            panel_scoresubmenu.Controls.Add(button_newscore);
            panel_scoresubmenu.Dock = DockStyle.Top;
            panel_scoresubmenu.Location = new Point(0, 630);
            panel_scoresubmenu.Margin = new Padding(3, 4, 3, 4);
            panel_scoresubmenu.Name = "panel_scoresubmenu";
            panel_scoresubmenu.Size = new Size(187, 135);
            panel_scoresubmenu.TabIndex = 6;
            // 
            // button_scoreprint
            // 
            button_scoreprint.Dock = DockStyle.Top;
            button_scoreprint.FlatAppearance.BorderSize = 0;
            button_scoreprint.FlatStyle = FlatStyle.Flat;
            button_scoreprint.Font = new Font("Century Gothic", 9.75F);
            button_scoreprint.ForeColor = Color.Black;
            button_scoreprint.Location = new Point(0, 82);
            button_scoreprint.Margin = new Padding(3, 4, 3, 4);
            button_scoreprint.Name = "button_scoreprint";
            button_scoreprint.Padding = new Padding(40, 0, 0, 0);
            button_scoreprint.Size = new Size(187, 47);
            button_scoreprint.TabIndex = 3;
            button_scoreprint.Text = "Print";
            button_scoreprint.TextAlign = ContentAlignment.MiddleLeft;
            button_scoreprint.UseVisualStyleBackColor = true;
            button_scoreprint.Click += button_scoreprint_Click;
            // 
            // button_managescore
            // 
            button_managescore.Dock = DockStyle.Top;
            button_managescore.FlatAppearance.BorderSize = 0;
            button_managescore.FlatStyle = FlatStyle.Flat;
            button_managescore.Font = new Font("Century Gothic", 9.75F);
            button_managescore.ForeColor = Color.Black;
            button_managescore.Location = new Point(0, 41);
            button_managescore.Margin = new Padding(3, 4, 3, 4);
            button_managescore.Name = "button_managescore";
            button_managescore.Padding = new Padding(40, 0, 0, 0);
            button_managescore.Size = new Size(187, 41);
            button_managescore.TabIndex = 1;
            button_managescore.Text = "Manage Score";
            button_managescore.TextAlign = ContentAlignment.MiddleLeft;
            button_managescore.UseVisualStyleBackColor = true;
            button_managescore.Click += button_managescore_Click;
            // 
            // button_newscore
            // 
            button_newscore.Dock = DockStyle.Top;
            button_newscore.FlatAppearance.BorderSize = 0;
            button_newscore.FlatStyle = FlatStyle.Flat;
            button_newscore.Font = new Font("Century Gothic", 9.75F);
            button_newscore.ForeColor = Color.Black;
            button_newscore.Location = new Point(0, 0);
            button_newscore.Margin = new Padding(3, 4, 3, 4);
            button_newscore.Name = "button_newscore";
            button_newscore.Padding = new Padding(40, 0, 0, 0);
            button_newscore.Size = new Size(187, 41);
            button_newscore.TabIndex = 0;
            button_newscore.Text = "New Score";
            button_newscore.TextAlign = ContentAlignment.MiddleLeft;
            button_newscore.UseVisualStyleBackColor = true;
            button_newscore.Click += button_newscore_Click;
            // 
            // button_score
            // 
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 575);
            button_score.Margin = new Padding(3, 4, 3, 4);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(11, 0, 0, 0);
            button_score.Size = new Size(187, 55);
            button_score.TabIndex = 5;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = true;
            button_score.Click += button_score_Click;
            // 
            // panel_coursesubmenu
            // 
            panel_coursesubmenu.BackColor = Color.Azure;
            panel_coursesubmenu.Controls.Add(button_courseprint);
            panel_coursesubmenu.Controls.Add(button_managecourse);
            panel_coursesubmenu.Controls.Add(button_newcourse);
            panel_coursesubmenu.Dock = DockStyle.Top;
            panel_coursesubmenu.Location = new Point(0, 446);
            panel_coursesubmenu.Margin = new Padding(3, 4, 3, 4);
            panel_coursesubmenu.Name = "panel_coursesubmenu";
            panel_coursesubmenu.Size = new Size(187, 129);
            panel_coursesubmenu.TabIndex = 4;
            // 
            // button_courseprint
            // 
            button_courseprint.Dock = DockStyle.Top;
            button_courseprint.FlatAppearance.BorderSize = 0;
            button_courseprint.FlatStyle = FlatStyle.Flat;
            button_courseprint.Font = new Font("Century Gothic", 9.75F);
            button_courseprint.ForeColor = Color.Black;
            button_courseprint.Location = new Point(0, 82);
            button_courseprint.Margin = new Padding(3, 4, 3, 4);
            button_courseprint.Name = "button_courseprint";
            button_courseprint.Padding = new Padding(40, 0, 0, 0);
            button_courseprint.Size = new Size(187, 41);
            button_courseprint.TabIndex = 3;
            button_courseprint.Text = "Print";
            button_courseprint.TextAlign = ContentAlignment.MiddleLeft;
            button_courseprint.UseVisualStyleBackColor = true;
            button_courseprint.Click += button_courseprint_Click;
            // 
            // button_managecourse
            // 
            button_managecourse.Dock = DockStyle.Top;
            button_managecourse.FlatAppearance.BorderSize = 0;
            button_managecourse.FlatStyle = FlatStyle.Flat;
            button_managecourse.Font = new Font("Century Gothic", 9.75F);
            button_managecourse.ForeColor = Color.Black;
            button_managecourse.Location = new Point(0, 41);
            button_managecourse.Margin = new Padding(3, 4, 3, 4);
            button_managecourse.Name = "button_managecourse";
            button_managecourse.Padding = new Padding(40, 0, 0, 0);
            button_managecourse.Size = new Size(187, 41);
            button_managecourse.TabIndex = 1;
            button_managecourse.Text = "Manage Course";
            button_managecourse.TextAlign = ContentAlignment.MiddleLeft;
            button_managecourse.UseVisualStyleBackColor = true;
            button_managecourse.Click += button_managecourse_Click;
            // 
            // button_newcourse
            // 
            button_newcourse.Dock = DockStyle.Top;
            button_newcourse.FlatAppearance.BorderSize = 0;
            button_newcourse.FlatStyle = FlatStyle.Flat;
            button_newcourse.Font = new Font("Century Gothic", 9.75F);
            button_newcourse.ForeColor = Color.Black;
            button_newcourse.Location = new Point(0, 0);
            button_newcourse.Margin = new Padding(3, 4, 3, 4);
            button_newcourse.Name = "button_newcourse";
            button_newcourse.Padding = new Padding(40, 0, 0, 0);
            button_newcourse.Size = new Size(187, 41);
            button_newcourse.TabIndex = 0;
            button_newcourse.Text = "New Course";
            button_newcourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newcourse.UseVisualStyleBackColor = true;
            button_newcourse.Click += button_newcourse_Click;
            // 
            // button_course
            // 
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 391);
            button_course.Margin = new Padding(3, 4, 3, 4);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(11, 0, 0, 0);
            button_course.Size = new Size(187, 55);
            button_course.TabIndex = 3;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = true;
            button_course.Click += button_course_Click;
            // 
            // panel_stdsubmenu
            // 
            panel_stdsubmenu.BackColor = Color.Azure;
            panel_stdsubmenu.Controls.Add(button_print);
            panel_stdsubmenu.Controls.Add(button_status);
            panel_stdsubmenu.Controls.Add(button_managestd);
            panel_stdsubmenu.Controls.Add(button_registration);
            panel_stdsubmenu.Dock = DockStyle.Top;
            panel_stdsubmenu.ForeColor = SystemColors.ControlText;
            panel_stdsubmenu.Location = new Point(0, 224);
            panel_stdsubmenu.Margin = new Padding(3, 4, 3, 4);
            panel_stdsubmenu.Name = "panel_stdsubmenu";
            panel_stdsubmenu.Size = new Size(187, 167);
            panel_stdsubmenu.TabIndex = 2;
            // 
            // button_print
            // 
            button_print.Dock = DockStyle.Top;
            button_print.FlatAppearance.BorderSize = 0;
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.Font = new Font("Century Gothic", 9.75F);
            button_print.ForeColor = Color.Black;
            button_print.Location = new Point(0, 123);
            button_print.Margin = new Padding(3, 4, 3, 4);
            button_print.Name = "button_print";
            button_print.Padding = new Padding(40, 0, 0, 0);
            button_print.Size = new Size(187, 41);
            button_print.TabIndex = 3;
            button_print.Text = "Print";
            button_print.TextAlign = ContentAlignment.MiddleLeft;
            button_print.UseVisualStyleBackColor = true;
            button_print.Click += button_print_Click;
            // 
            // button_status
            // 
            button_status.Dock = DockStyle.Top;
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Century Gothic", 9.75F);
            button_status.ForeColor = Color.Black;
            button_status.Location = new Point(0, 82);
            button_status.Margin = new Padding(3, 4, 3, 4);
            button_status.Name = "button_status";
            button_status.Padding = new Padding(40, 0, 0, 0);
            button_status.Size = new Size(187, 41);
            button_status.TabIndex = 2;
            button_status.Text = "Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_managestd
            // 
            button_managestd.Dock = DockStyle.Top;
            button_managestd.FlatAppearance.BorderSize = 0;
            button_managestd.FlatStyle = FlatStyle.Flat;
            button_managestd.Font = new Font("Century Gothic", 9.75F);
            button_managestd.ForeColor = Color.Black;
            button_managestd.Location = new Point(0, 41);
            button_managestd.Margin = new Padding(3, 4, 3, 4);
            button_managestd.Name = "button_managestd";
            button_managestd.Padding = new Padding(40, 0, 0, 0);
            button_managestd.Size = new Size(187, 41);
            button_managestd.TabIndex = 1;
            button_managestd.Text = "Manage Students";
            button_managestd.TextAlign = ContentAlignment.MiddleLeft;
            button_managestd.UseVisualStyleBackColor = true;
            button_managestd.Click += button_managestd_Click;
            // 
            // button_registration
            // 
            button_registration.Dock = DockStyle.Top;
            button_registration.FlatAppearance.BorderSize = 0;
            button_registration.FlatStyle = FlatStyle.Flat;
            button_registration.Font = new Font("Century Gothic", 9.75F);
            button_registration.ForeColor = Color.Black;
            button_registration.Location = new Point(0, 0);
            button_registration.Margin = new Padding(3, 4, 3, 4);
            button_registration.Name = "button_registration";
            button_registration.Padding = new Padding(40, 0, 0, 0);
            button_registration.Size = new Size(187, 41);
            button_registration.TabIndex = 0;
            button_registration.Text = "Registration";
            button_registration.TextAlign = ContentAlignment.MiddleLeft;
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_Click;
            // 
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 169);
            button_std.Margin = new Padding(3, 4, 3, 4);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(11, 0, 0, 0);
            button_std.Size = new Size(187, 55);
            button_std.TabIndex = 1;
            button_std.Text = "Student";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.AutoScroll = true;
            panel_logo.Controls.Add(label5);
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label4);
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Margin = new Padding(3, 4, 3, 4);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(187, 169);
            panel_logo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 117);
            label5.Name = "label5";
            label5.Size = new Size(156, 22);
            label5.TabIndex = 4;
            label5.Text = "NextGen school";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 91);
            label3.Name = "label3";
            label3.Size = new Size(119, 22);
            label3.TabIndex = 2;
            label3.Text = "Welcome to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.CadetBlue;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 104);
            label4.Name = "label4";
            label4.Size = new Size(0, 22);
            label4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Engravers MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 12);
            label2.Name = "label2";
            label2.Size = new Size(72, 51);
            label2.TabIndex = 1;
            label2.Text = "M";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_cover);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(208, 0);
            panel_main.Margin = new Padding(3, 4, 3, 4);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1086, 804);
            panel_main.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(pictureBox2);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Margin = new Padding(3, 4, 3, 4);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(1086, 804);
            panel_cover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Azure;
            pictureBox2.Image = Properties.Resources._10790;
            pictureBox2.Location = new Point(-1, 155);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1088, 543);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(label_femaleStd);
            panel3.Controls.Add(label_maleStd);
            panel3.Controls.Add(label_totalStd);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 692);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1086, 112);
            panel3.TabIndex = 2;
            // 
            // label_femaleStd
            // 
            label_femaleStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_femaleStd.AutoSize = true;
            label_femaleStd.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_femaleStd.Location = new Point(146, 59);
            label_femaleStd.Name = "label_femaleStd";
            label_femaleStd.Size = new Size(86, 22);
            label_femaleStd.TabIndex = 3;
            label_femaleStd.Text = "Female :";
            // 
            // label_maleStd
            // 
            label_maleStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_maleStd.AutoSize = true;
            label_maleStd.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_maleStd.Location = new Point(31, 59);
            label_maleStd.Name = "label_maleStd";
            label_maleStd.Size = new Size(65, 22);
            label_maleStd.TabIndex = 2;
            label_maleStd.Text = "Male :";
            // 
            // label_totalStd
            // 
            label_totalStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalStd.AutoSize = true;
            label_totalStd.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_totalStd.Location = new Point(31, 19);
            label_totalStd.Name = "label_totalStd";
            label_totalStd.Size = new Size(147, 22);
            label_totalStd.TabIndex = 1;
            label_totalStd.Text = "Total Students :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label_role);
            panel2.Controls.Add(label_user);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 81);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.graduated;
            pictureBox1.Location = new Point(1017, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_role.Location = new Point(138, 39);
            label_role.Name = "label_role";
            label_role.Size = new Size(70, 22);
            label_role.TabIndex = 3;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_user.Location = new Point(138, 12);
            label_user.Name = "label_user";
            label_user.Size = new Size(70, 22);
            label_user.TabIndex = 2;
            label_user.Text = "Meera";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(75, 39);
            label6.Name = "label6";
            label6.Size = new Size(59, 22);
            label6.TabIndex = 1;
            label6.Text = "Role :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Welcome :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 79);
            panel1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.CadetBlue;
            label13.Location = new Point(22, 24);
            label13.Name = "label13";
            label13.Size = new Size(388, 23);
            label13.TabIndex = 1;
            label13.Text = "NextGen International School, Porbandar";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1294, 804);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1312, 851);
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Mainform_Load;
            panel_slide.ResumeLayout(false);
            panel_scoresubmenu.ResumeLayout(false);
            panel_coursesubmenu.ResumeLayout(false);
            panel_stdsubmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Panel panel_stdsubmenu;
        private Button button_registration;
        private Button button_print;
        private Button button_status;
        private Button button_managestd;
        private Panel panel_scoresubmenu;
        private Button button_scoreprint;
        private Button button_managescore;
        private Button button_newscore;
        private Button button_score;
        private Panel panel_coursesubmenu;
        private Button button_courseprint;
        private Button button_managecourse;
        private Button button_newcourse;
        private Button button_course;
        private Button button_dashboard;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Panel panel_main;
        private Panel panel_cover;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label6;
        private Label label1;
        private Label label_totalStd;
        private Label label_role;
        private Label label_user;
        private Label label_femaleStd;
        private Label label_maleStd;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label13;
        private Button button_exit;
    }
}
