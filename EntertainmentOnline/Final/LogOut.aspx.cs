using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loggedInUser"] = "";
            Session["role"] = "";
            Session["shoppingCartItems"] = 0;
            List<int> shoppingCart = (List<int>)Session["shoppingCartItemIDs"];
            shoppingCart.Clear();
            Session["shoppingCartItemIDs"] = shoppingCart;

            Response.Redirect("HomePage.aspx");
        }
    }
}