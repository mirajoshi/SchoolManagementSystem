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
using DGVPrinterHelper;
using System.Reflection;

namespace StudentManagementSystem
{
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_PrintStd.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId=student.StdID WHERE CONCAT(student.StdFirstName, student.StdLastName, score.CourseName) LIKE '%" + textBox_search.Text + "%'"));
        }

        private void button_PrintScore_Click(object sender, EventArgs e)
        {
            printer.Title = "NextGen  list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "NextGen";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_PrintStd);
        }

        public void showScor()
        {
            DataGridView_PrintStd.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId,student.StdFirstName,student.StdLastName,score.CourseName,score.Score,score.Description FROM student INNER JOIN score ON score.StudentId=student.StdID"));
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScor();
        }
    }
}
