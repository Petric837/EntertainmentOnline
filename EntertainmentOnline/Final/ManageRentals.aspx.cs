using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class ManageRentals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"].ToString() != "admin")
            {
                Response.Redirect("Unauthorized.aspx");
            }

            else
            {
                DatabaseConnection Database = new DatabaseConnection();

                try { Database.createRentalList(); }

                catch (Exception exc)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Failed to communicate with database')", true);
                }

                foreach (rentalRow dbRow in Database.rentalList)
                {
                    TableRow row = new TableRow();
                    TableCell cell1 = new TableCell();
                    TableCell cell2 = new TableCell();
                    TableCell cell3 = new TableCell();
                    TableCell cell4 = new TableCell();
                    TableCell cell5 = new TableCell();
                    TableCell cell6 = new TableCell();
                    TableCell cell7 = new TableCell();
                    TableCell cell8 = new TableCell();

                    cell1.Text = dbRow.type.ToUpper();
                    cell2.Text = dbRow.title;
                    cell3.Text = dbRow.genre;
                    cell4.Text = dbRow.releaseDate;
                    cell5.Text = "$" + dbRow.price;
                    cell6.Text = dbRow.reviewScore + " / 10";

                    Button editBtn = new Button();
                    editBtn.Text = "Edit";
                    editBtn.CommandArgument = dbRow.id.ToString();
                    editBtn.Command += new CommandEventHandler(editBtnClick);
                    editBtn.CssClass = "btn btn-primary";

                    Button deleteBtn = new Button();
                    deleteBtn.Text = "Delete";
                    deleteBtn.CommandArgument = dbRow.id.ToString();
                    deleteBtn.Command += new CommandEventHandler(deleteBtnClick);
                    deleteBtn.CssClass = "btn btn-primary";


                    cell7.Controls.Add(editBtn);
                    cell8.Controls.Add(deleteBtn);

                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);
                    row.Cells.Add(cell4);
                    row.Cells.Add(cell5);
                    row.Cells.Add(cell6);
                    row.Cells.Add(cell7);
                    row.Cells.Add(cell8);

                    rentalTable.Rows.Add(row);
                }
            }
        }

        public void editBtnClick(object sender, CommandEventArgs e)
        {
            Session["editRental"] = e.CommandArgument.ToString();
            Response.Redirect("Add-Edit-Rental.aspx");
        }

        public void deleteBtnClick(object sender, CommandEventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();

            try { Database.deleteRental(e.CommandArgument.ToString()); }
            catch (Exception exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Failed to communicate with database')", true);
                return;
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Rental was deleted'); window.location='" +
                                                Request.ApplicationPath + "/Final/ManageRentals.aspx';", true);
        }

        public void onAddBtnClick(object sender, EventArgs e)
        {
            Response.Redirect("Add-Edit-Rental.aspx");
        }
    }
}