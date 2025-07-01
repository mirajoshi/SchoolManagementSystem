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
    public partial class ManageScoreForm : Form
    {
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //populate combobox with courses name
            comboBox_SelectCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_SelectCourse.DisplayMember = "CourseName";
            comboBox_SelectCourse.ValueMember = "CourseName";

            //to show score data on data grid view
            showScor();
        }
        public void showScor()
        {
            DataGridView_course.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId,student.StdFirstName,student.StdLastName,score.CourseName,score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdID"));
        }


        private void button_UpdateScore_Click(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "" || textBox_Score.Text == "")
            {
                MessageBox.Show("Need score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_StdId.Text);
                string courName = comboBox_SelectCourse.Text;
                double scor = Convert.ToDouble(textBox_Score.Text);
                string desc = textBox_description.Text;
                if (score.updateScore(stdId, courName, scor, desc))
                {
                    showScor();
                    button_clearcourse.PerformClick();
                    MessageBox.Show("Score updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score can't be updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button_ClearScore_Click(object sender, EventArgs e)
        {
            textBox_StdId.Clear();
            textBox_Score.Clear();
            textBox_description.Clear();
            textBox_search.Clear();
        }

        private void buttonDeleteScore_Click(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "")
            {
                MessageBox.Show("Field Error - we need student ID", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_StdId.Text);

                // Confirm deletion
                if (MessageBox.Show("Are you sure you want to delete this score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Call the delete function from the score class
                    if (score.deleteScore(stdId))
                    {
                        MessageBox.Show("Score removed", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the score list in the DataGridView
                        showScor();

                        // Clear input fields
                        button_ClearScore.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Score could not be deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DataGridView_course_Click(object sender, EventArgs e)
        {
            textBox_StdId.Text = DataGridView_course.CurrentRow.Cells[0].Value.ToString();
            comboBox_SelectCourse.Text = DataGridView_course.CurrentRow.Cells[3].Value.ToString();
            textBox_Score.Text = DataGridView_course.CurrentRow.Cells[4].Value.ToString();
            textBox_description.Text = DataGridView_course.CurrentRow.Cells[5].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId=student.StdID WHERE CONCAT(student.StdFirstName, student.StdLastName, score.CourseName) LIKE '%" + textBox_search.Text + "%'"));
        }
    }
}
