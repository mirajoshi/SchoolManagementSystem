using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StudentManagementSystem
{
    class CourseClass
    {
        DBconnect connect = new DBconnect();
        //create a function to insert course
        public bool insertCourse(string cName, int hr, string desc)
        {
            MySqlCommand command  = new MySqlCommand("INSERT INTO `course`(`CourseName`,`CourseHours`,`Description`) VALUES (@cn,@ch,@desc)",connect.getconnection);

            //@cn,@ch,@desc
            command.Parameters.Add("@cn",MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch",MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc",MySqlDbType.VarChar).Value= desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        //create a function to get course list
        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function to update/edit course details
        public bool updateCourse(int id, string cName, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `Course` SET `CourseName`=@cn,`CourseHours`=@ch,`Description`=@desc WHERE `CourseId`=@id", connect.getconnection);

            //@id,@cn,@ch,@desc
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        //create a function to delete the course
        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `Course` WHERE `CourseId`=@id",connect.getconnection);
            command.Parameters.Add("@id",MySqlDbType.Int32).Value = id;

            connect.openConnect();

            // Execute the command and check if exactly one row was affected
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true; // Successfully deleted
            }
            else
            {
                connect.closeConnect();
                return false; // Deletion failed or course not found
            }
        }
    }
}
