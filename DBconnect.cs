﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class DBconnect
    {
        //to create connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;database=studentdb");

        //to get conncetion
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to open connection
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //create a function to close connection
        public void closeConnect()
        {
            if(connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
