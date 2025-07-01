using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class ScoreClass
    {
        DBconnect connect = new DBconnect();

        //create a function to add score
        public bool insertScore(int stdId,string courName, double scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`,`CourseName`,`Score`,`Description`) VALUES (@stid,@cn,@scor,@desc)", connect.getconnection);

            //@stid,@cn,@sco,@desc
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courName;
            command.Parameters.Add("@scor",MySqlDbType.Double).Value = scor;
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

        //create a function to get list
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function to check score of sunject which is already added
        public bool checkScore(int stdId, string courName)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `score` WHERE `StudentId`='"+ stdId +"' AND `CourseName`='"+courName+"'"));
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //create a function to update the score
        public bool updateScore(int stdId,string courName, double scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@scor,`Description`=@desc WHERE `StudentId`=@stdId AND `CourseName`=@courName", connect.getconnection);

            //@stid,@sco,@desc
            command.Parameters.Add("@courName", MySqlDbType.VarChar).Value = courName;
            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = stdId;
            command.Parameters.Add("@scor", MySqlDbType.Double).Value = scor;
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

        //create a function to delet score data
        public bool deleteScore(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentId`=@stdId", connect.getconnection);

            //@id
            command.Parameters.Add("@stdId", MySqlDbType.Int32).Value = id;

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
    }
}
