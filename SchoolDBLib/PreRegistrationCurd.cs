using MySqlConnector;
using SchoolModel;
using System;

namespace SchoolDBLib
{
    public class PreRegistrationCurd
    {

        DBUtility dBUtility = new DBUtility();
        public PreRegistrationCurd()
        {

        }

        public string AddPreRegistration(PreRegistrationModel preRegistration)
        {
            string result = "Registered Successfully";
            var connection = dBUtility.connection;

            dBUtility.ConOpen();

            var cmd = dBUtility.connection.CreateCommand() as MySqlCommand;

            cmd.CommandText = @"INSERT INTO preregistration(username, schoolname, emailid) VALUES (@UserName,@schoolname,@emailid);";

            cmd.Parameters.AddWithValue("@UserName", preRegistration.UserName);
            cmd.Parameters.AddWithValue("@schoolname", preRegistration.SchoolName);
            cmd.Parameters.AddWithValue("@emailid", preRegistration.EmailId);

            var recs = cmd.ExecuteNonQuery();

            if (recs != 1)
                    result = "Sorry! Registration Failed";

            dBUtility.ConClose();

            return result;       
        }
    }
}
