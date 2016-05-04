using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class Add_Edit_Rental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["editRental"].ToString() != "")
            {
                if (!IsPostBack)
                {
                    header.InnerText = "Edit Rental";
                    addBtn.Visible = false;

                    DatabaseConnection Database = new DatabaseConnection();
                    rentalRow rental = Database.findRental(Session["editRental"].ToString());

                    type.Value = rental.type;
                    title.Text = rental.title;
                    genre.Text = rental.genre;
                    releaseDate.Text = rental.releaseDate;
                    price.Text = rental.price;
                    reviewScore.Text = rental.reviewScore;
                }
            }
            else {
                header.InnerText = "Add Rental";
                editBtn.Visible = false;
            }
        }

        public void onAdd(object sender, EventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();

            Database.addRental(type.Value, title.Text, genre.Text, releaseDate.Text, price.Text, reviewScore.Text);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Rental added successfully'); window.location='" +
                                                Request.ApplicationPath + "/Final/ManageRentals.aspx';", true);
        }

        public void onEdit(object sender, EventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();

            Database.editRental(Session["editRental"].ToString(), type.Value, title.Text, genre.Text, releaseDate.Text, price.Text, reviewScore.Text);

            Session["editRental"] = "";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Changes applied successfully'); window.location='" +
                                                Request.ApplicationPath + "/Final/ManageRentals.aspx';", true);
        }
    }
}