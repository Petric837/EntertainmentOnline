using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();

            userRow user = Database.findUser(Session["loggedInUser"].ToString());

            info.InnerHtml = "Username: " + user.username + "<br/>" +
                             "Address: " + user.address + "<br/>" +
                             "Card Type: " + user.cardType + "<br/>" +
                             "Card Number: " + user.cardNumber + "<br/>";
        }

        public void onReturn(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

    }
}