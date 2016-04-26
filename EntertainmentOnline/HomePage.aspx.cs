using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace EntertainmentOnline
{
    public partial class HomePage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void testdb(object sender, EventArgs e)
        {
            // Setup connection to DB
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "server=db1.cs.uakron.edu;database=WP_jgp18;uid=jgp18;pwd=Goose12345;allow zero datetime=yes";

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Users WHERE username='jgp18';", myConnection);

                MySqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                    status.InnerHtml = "Success!";

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc)
            {
                status.InnerHtml = exc.ToString();
            }
        } // End of test


    }


}