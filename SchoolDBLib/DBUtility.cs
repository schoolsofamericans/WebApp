using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SchoolDBLib
{
    public class DBUtility
    {
        public string ConStr { get; set; }

        public MySqlConnection connection = new MySqlConnection("server = localhost; user = root; password = JaiKrishna@5; database = schoolssch");
        public DBUtility()
        {
            //ConStr = "server = localhost; user = root; password = JaiKrishna@5; database = schoolssch";
        }

        public void ConOpen()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
        }

        public void ConClose()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


    }
}
