using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double priceTotal = 0;
            DatabaseConnection Database = new DatabaseConnection();

            try { Database.createRentalList(); }

            catch (Exception exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Failed to communicate with database')", true);
            }

            foreach (rentalRow dbRow in Database.rentalList)
            {
                foreach(int item in (List<int>)Session["shoppingCartItemIDs"])
                {
                    if(dbRow.id == item)
                    {
                        TableRow row = new TableRow();
                        TableCell cell1 = new TableCell();
                        TableCell cell2 = new TableCell();
                        TableCell cell3 = new TableCell();
                        TableCell cell4 = new TableCell();
                        TableCell cell5 = new TableCell();
                        TableCell cell6 = new TableCell();
                        TableCell cell7 = new TableCell();

                        cell1.Text = dbRow.type.ToUpper();
                        cell2.Text = dbRow.title;
                        cell3.Text = dbRow.genre;
                        cell4.Text = dbRow.releaseDate;
                        cell5.Text = "$" + dbRow.price;
                        cell6.Text = dbRow.reviewScore + " / 10";

                        Button removeBtn = new Button();
                        removeBtn.Text = "Remove from Cart";
                        removeBtn.CommandArgument = dbRow.id.ToString();
                        removeBtn.Command += new CommandEventHandler(removeBtnClick);
                        removeBtn.CssClass = "btn btn-danger";

                        cell7.Controls.Add(removeBtn);

                        row.Cells.Add(cell1);
                        row.Cells.Add(cell2);
                        row.Cells.Add(cell3);
                        row.Cells.Add(cell4);
                        row.Cells.Add(cell5);
                        row.Cells.Add(cell6);
                        row.Cells.Add(cell7);

                        rentalTable.Rows.Add(row);

                        priceTotal += Convert.ToDouble(dbRow.price);
                    }
                }
            }

            total.InnerText = "Total: $" + priceTotal.ToString();
        }


        public void removeBtnClick(object sender, CommandEventArgs e)
        {
            int numItems = (int)Session["shoppingCartItems"];
            numItems--;
            Session["shoppingCartItems"] = numItems;

            List<int> shoppingCart = (List<int>)Session["shoppingCartItemIDs"];
            shoppingCart.Remove(Convert.ToInt32(e.CommandArgument.ToString()));
            Session["shoppingCartItemIDs"] = shoppingCart;

            Response.Redirect("ShoppingCart.aspx");
        }


        public void checkoutBtnClick(object sender, EventArgs e)
        {
            List<int> shoppingCart = (List<int>)Session["shoppingCartItemIDs"];
            if(shoppingCart.Count != 0)
            {
                Session["shoppingCartItems"] = 0;
                shoppingCart.Clear();
                Session["shoppingCartItemIDs"] = shoppingCart;
                Response.Redirect("Checkout.aspx");
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have no items in your shopping cart')", true);
        }

    }
}