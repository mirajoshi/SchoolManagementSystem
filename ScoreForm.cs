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
    public partial class ScoreForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
        }

        //create a function to display data on data grid view score
        private void showScore()
        {
            DataGridView_Student.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId,student.StdFirstName,student.StdLastName,score.CourseName,score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdID"));
        }
        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //populate combobox with courses name
            comboBox_SelectCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_SelectCourse.DisplayMember = "CourseName";
            comboBox_SelectCourse.ValueMember = "CourseName";

            //to show data on data grid view 
            showScore();

            //To display student list in data grid view
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`,`StdFirstName`,`StdLastName` FROM `student`"));
        }

        private void button_AddScore_Click(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "" || textBox_Score.Text == "")
            {
                MessageBox.Show("Need score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_StdId.Text);
                string courName = comboBox_SelectCourse.Text;
                double scor = Convert.ToDouble(textBox_Score.Text);  // Use Convert.ToDouble for score
                string desc = textBox_description.Text;

                if (!score.checkScore(stdId, courName))  // Check if the score already exists
                {
                    if (score.insertScore(stdId, courName, scor, desc))  // Insert the score
                    {
                        showScore();  // Refresh the DataGridView to display updated scores
                        MessageBox.Show("New Score Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally clear the input fields after adding the score
                        button_ClearScore.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Score can't be added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Score for this subject already exists", "Add score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_ClearScore_Click(object sender, EventArgs e)
        {
            textBox_StdId.Clear();
            textBox_Score.Clear();
            comboBox_SelectCourse.SelectedIndex = 0;
            textBox_description.Clear();
        }

        private void DataGridView_Student_Click(object sender, EventArgs e)
        {
            textBox_StdId.Text = DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_sStudent_Click(object sender, EventArgs e)
        {
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`,`StdFirstName`,`StdLastName` FROM `student`"));
        }

        private void button_sScore_Click(object sender, EventArgs e)
        {
            showScore();
        }
    }
}
