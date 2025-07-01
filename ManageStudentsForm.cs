using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class ManageStudentsForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        //to show student table in data grid view
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        //display student data from student to textbox
        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)DataGridView_student.CurrentRow.Cells[3].Value;
            textBox_address.Text = DataGridView_student.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_student.CurrentRow.Cells[7].Value;

            MemoryStream ms = new MemoryStream(img);
            pictureBox_StdImg.Image = Image.FromStream(ms);
        }

        private void button_MngClear_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_mobile.Clear();
            textBox_address.Clear();
            radioButton_maleG.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_StdImg.Image = null;
        }

        private void button_MngUpload_Click(object sender, EventArgs e)
        {
            //browse photo from computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_StdImg.Image = Image.FromFile(opf.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        //create function to verify
        bool verify()
        {
            if ((textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_mobile.Text == "") || (textBox_address.Text == "") ||
                (pictureBox_StdImg.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            // Update student's record
            int id = Convert.ToInt32(textBox_Id.Text);
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_mobile.Text;
            string address = textBox_address.Text;
            string gender = radioButton_maleG.Checked ? "Male" : "Female";

            // Check whether the student's age is between 10 and 100
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student's age must be between 10 and 100", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // Get picture from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_StdImg.Image.Save(ms, pictureBox_StdImg.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Student data updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error in updating the student data", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the student's ID from the textbox
                int id = Convert.ToInt32(textBox_Id.Text);

                // Ask for confirmation before deleting
                if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Call the delete function from the student class
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student deleted successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the form fields after deletion
                        textBox_Id.Clear();
                        textBox_Fname.Clear();
                        textBox_Lname.Clear();
                        textBox_mobile.Clear();
                        textBox_address.Clear();
                        radioButton_maleG.Checked = true;
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox_StdImg.Image = null;

                        // Refresh the DataGridView to reflect the deletion
                        showTable();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting student", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
