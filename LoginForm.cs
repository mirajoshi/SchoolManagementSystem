﻿using System;
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
    public partial class LoginForm : Form
    {
        StudentClass student = new StudentClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text == "" ||  textBox_password.Text == "")
            {
                MessageBox.Show("Need Login Data","Wrong Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_username.Text;
                string pass = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`='" + uname + "' AND `password`='" + pass + "'"));
                if(table.Rows.Count > 0)
                {
                    Mainform main = new Mainform();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your Username or Password is wrong or doesn't exist","Wrong Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
        }

        private void label_exiticon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exiticon_MouseEnter(object sender, EventArgs e)
        {
            label_exiticon.ForeColor = Color.Black;
        }

        private void label_exiticon_MouseLeave(object sender, EventArgs e)
        {
            label_exiticon.ForeColor = Color.Transparent;
        }
    }
}
