using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class EditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DatabaseConnection Database = new DatabaseConnection();

                userRow user = Database.findUser(Session["editUser"].ToString());

                username.Text = user.username;
                password.Text = user.password;
                address.Text = user.address;
                phone.Text = user.phone;
                cardType.Value = user.cardType;
                cardNumber.Text = user.cardNumber;
                role.Value = user.role;
            }
        }

        public void onApply(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection Database = new DatabaseConnection();

                Database.editUser(username.Text, password.Text, address.Text, phone.Text, cardType.Value, cardNumber.Text, role.Value);

                Session["editUser"] = "";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect", "alert('Changes have been applied'); window.location='" +
                                                Request.ApplicationPath + "/Final/ManageUsers.aspx';", true);
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error: Could not perform this task')", true);
            }
        }
    }
}