using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["loggedInUser"].ToString() != "")
            {
                userSection.InnerHtml = "<li style='padding:14px;color:white;'><strong>You are logged in as " + Session["loggedInUser"].ToString() + "</strong></li>" +
                                        "<li><a href='ShoppingCart.aspx'><span class='glyphicon glyphicon-shopping-cart'></span> Shopping Cart <span class='badge'>" + Session["shoppingCartItems"].ToString() + "</span></a></li>" +
                                        "<li><a href='LogOut.aspx'><strong>Log Out</strong></a></li>";
            }
        }

    }
}