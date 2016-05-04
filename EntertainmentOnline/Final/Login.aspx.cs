using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class Login : System.Web.UI.Page
    {

        public void onLogin(object sender, EventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();

            try
            {
                if (Database.userExists(username.Text, password.Text))
                {
                    DatabaseConnection Database2 = new DatabaseConnection();
                    userRow user = new userRow();
                    user = Database2.findUser(username.Text);
                    Session["loggedInUser"] = user.username;
                    Session["role"] = user.role;
                    Response.Redirect("HomePage.aspx");
                }
                else
                    status.InnerText = "Could not log in. Invalid username or password.";
            }
            catch (Exception exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Failed to communicate with database')", true);
            }
        }

    }
}