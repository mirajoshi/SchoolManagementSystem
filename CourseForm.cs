using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button_addcourse_Click(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chours.Text == "")
            {
                MessageBox.Show("Need course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_Cname.Text;
                int chr = Convert.ToInt32(textBox_Chours.Text);
                string desc = textBox_description.Text;

                if (course.insertCourse(cName, chr, desc))
                {
                    showData();
                    button_clearcourse.PerformClick();
                    MessageBox.Show("New course inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course can't be inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_clearcourse_Click(object sender, EventArgs e)
        {
            textBox_Cname.Clear();
            textBox_Chours.Clear();
            textBox_description.Clear();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `Course`"));
        }
    }
}
