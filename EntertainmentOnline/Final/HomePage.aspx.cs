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
            DatabaseConnection Database = new DatabaseConnection();

            try { Database.createRentalList(); }

            catch (Exception exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Failed to communicate with database')", true);
            }

            foreach (rentalRow dbRow in Database.rentalList)
            {
                if (search.Text != "")
                {
                    if (rentalType.Value != "None")
                    {
                        if (dbRow.type == rentalType.Value && dbRow.title == search.Text)
                            addTableRow(dbRow);
                    }
                    else {
                        if (dbRow.title == search.Text)
                            addTableRow(dbRow);
                    }
                }

                else if (rentalType.Value != "None")
                {
                    if (dbRow.type == rentalType.Value)
                        addTableRow(dbRow);
                }

                else
                    addTableRow(dbRow);
            }
        }


        public void addTableRow(rentalRow dbRow)
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

            cell5.Style.Add("color", "green");

            cell1.Style.Add("font-family", "Verdana");
            cell2.Style.Add("font-family", "Verdana");
            cell3.Style.Add("font-family", "Verdana");
            cell4.Style.Add("font-family", "Verdana");
            cell5.Style.Add("font-family", "Verdana");
            cell6.Style.Add("font-family", "Verdana");

            cell1.Style.Add("font-size", "18px");
            cell2.Style.Add("font-size", "18px");
            cell3.Style.Add("font-size", "18px");
            cell4.Style.Add("font-size", "18px");
            cell5.Style.Add("font-size", "18px");
            cell6.Style.Add("font-size", "18px");

            Button addBtn = new Button();
            addBtn.Text = "Add to Cart";
            addBtn.CommandArgument = dbRow.id.ToString();
            addBtn.Command += new CommandEventHandler(addBtnClick);
            addBtn.CssClass = "btn btn-success";


            cell7.Controls.Add(addBtn);

            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);
            row.Cells.Add(cell4);
            row.Cells.Add(cell5);
            row.Cells.Add(cell6);
            row.Cells.Add(cell7);

            rentalTable.Rows.Add(row);
        }


        public void addBtnClick(object sender, CommandEventArgs e)
        {
            if (Session["loggedInUser"].ToString() != "")
            {
                int numItems = (int)Session["shoppingCartItems"];
                numItems++;
                Session["shoppingCartItems"] = numItems;

                List<int> shoppingCart = (List<int>)Session["shoppingCartItemIDs"];
                shoppingCart.Add(Convert.ToInt32(e.CommandArgument.ToString()));
                Session["shoppingCartItemIDs"] = shoppingCart;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Item added to cart'); window.location='" +
                                                    Request.ApplicationPath + "/Final/HomePage.aspx';", true);
            }
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('You must be signed in to access your cart'); window.location='" +
                                                    Request.ApplicationPath + "/Final/HomePage.aspx';", true);
        }

    }


}