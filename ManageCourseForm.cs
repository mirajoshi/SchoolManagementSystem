using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `Course`"));
        }

        private void button_CourseClear_Click(object sender, EventArgs e)
        {
            textBox_CId.Clear();
            textBox_Cname.Clear();
            textBox_Chours.Clear();
            textBox_desc.Clear();
        }

        private void button_Updatecourse_Click(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chours.Text == "" || textBox_CId.Text.Equals(""))
            {
                MessageBox.Show("Need course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_CId.Text);
                string cName = textBox_Cname.Text;
                int chr = Convert.ToInt32(textBox_Chours.Text);
                string desc = textBox_desc.Text;

                if (course.updateCourse(id, cName, chr, desc))
                {
                    showData();
                    button_CourseClear.PerformClick();
                    MessageBox.Show("Course updated successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course can't be updated", "Update course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Deletecourse_Click(object sender, EventArgs e)
        {
            if (textBox_CId.Text.Equals(""))
            {
                MessageBox.Show("Need course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_CId.Text);

                    if (course.deleteCourse(id))
                    {
                        showData();
                        button_CourseClear.PerformClick();
                        MessageBox.Show("Course deleted successfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_course_Click(object sender, EventArgs e)
        {
            // Safely access each cell with null checking
            textBox_CId.Text = DataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_Cname.Text = DataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_Chours.Text = DataGridView_course.CurrentRow.Cells[2].Value.ToString();
            textBox_desc.Text = DataGridView_course.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }
    }
}
