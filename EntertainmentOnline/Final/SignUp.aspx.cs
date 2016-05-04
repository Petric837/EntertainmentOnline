using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class SignUp : System.Web.UI.Page
    {

        public void onSubmit(object sender, EventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();
            try
            {
                Database.addUser(username.Text, password.Text, address.Text, phone.Text, cardType.Value, cardNumber.Text);
            }
            catch(Exception exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Failed to communicate with database')", true);
                return;
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Account was successfully created!'); window.location='" +
                                                Request.ApplicationPath + "/Final/HomePage.aspx';", true);
        }

    }
}