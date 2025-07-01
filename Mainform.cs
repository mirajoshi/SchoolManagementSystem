namespace StudentManagementSystem
{
    public partial class Mainform : Form
    {
        StudentClass student = new StudentClass();
        public Mainform()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            studentcount();
        }

        private void studentcount()
        {
            //Display the values
            label_totalStd.Text = "Total Students : " + student.totalStudents();
            label_maleStd.Text = "Male : " + student.maleStudents();
            label_femaleStd.Text = "Female : " + student.femaleStudents();
        }
        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_scoresubmenu.Visible = false;
            panel_coursesubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;

            if (panel_scoresubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;

            if (panel_coursesubmenu.Visible == true)
                panel_coursesubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        #region StdSubmenu

        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            hideSubmenu();
        }

        private void button_managestd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentsForm());
            hideSubmenu();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            hideSubmenu();
        }

        #endregion StdSubmenu

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursesubmenu);
        }

        #region CourseSubmenu

        private void button_newcourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            hideSubmenu();
        }

        private void button_managecourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            hideSubmenu();
        }

        private void button_courseprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            hideSubmenu();
        }

        #endregion CourseSubmenu

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoresubmenu);
        }

        #region ScoreSubmenu

        private void button_newscore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            hideSubmenu();
        }

        private void button_managescore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());
            hideSubmenu();
        }

        private void button_scoreprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            hideSubmenu();
        }

        #endregion ScoreSubmenu

        // to show register form in main form
        private Form activeForm = null;
        private void openChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childFrom);
            panel_main.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void button_dashboard_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentcount();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
