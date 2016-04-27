using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace EntertainmentOnline
{
    public class databaseRow
    {
        public string username;
        public string password;
        public string address;
        public string phone;
        public string cardType;
        public string cardNumber;
        public string role;
    }

    public class DatabaseConnection
    {
        public List<databaseRow> userList = new List<databaseRow>();
        public List<databaseRow> rentalList = new List<databaseRow>();

        public void createUserList()
        {
            userList.Clear();

            // Setup connection to DB
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "server=db1.cs.uakron.edu;database=WP_jgp18;uid=jgp18;pwd=Goose12345;allow zero datetime=yes";

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Users;", myConnection);

                // Read result data
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    databaseRow row = new databaseRow();
                    row.username    = reader["username"].ToString();
                    row.password    = reader["password"].ToString();
                    row.address     = reader["address"].ToString();
                    row.phone       = reader["phone"].ToString();
                    row.cardType    = reader["cardType"].ToString();
                    row.cardNumber  = reader["cardNumber"].ToString();
                    row.role        = reader["role"].ToString();

                    userList.Add(row);
                }

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { }
        }
    }
}