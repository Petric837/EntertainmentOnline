using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntertainmentOnline
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseConnection Database = new DatabaseConnection();

            Database.createUserList();

            foreach (databaseRow dbRow in Database.userList)
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
                TableCell cell9 = new TableCell();

                cell1.Text = dbRow.username;
                cell2.Text = dbRow.password;
                cell3.Text = dbRow.address;
                cell4.Text = dbRow.phone;
                cell5.Text = dbRow.cardType;
                cell6.Text = dbRow.cardNumber;
                cell7.Text = dbRow.role;

                Button editBtn = new Button();
                editBtn.Text = "Edit";
                editBtn.CommandArgument = dbRow.username;
                editBtn.Command += new CommandEventHandler(editBtnClick);
                editBtn.CssClass = "btn btn-primary";

                Button deleteBtn = new Button();
                deleteBtn.Text = "Delete";
                deleteBtn.CommandArgument = dbRow.username;
                deleteBtn.Command += new CommandEventHandler(deleteBtnClick);
                deleteBtn.CssClass = "btn btn-primary";

                cell8.Controls.Add(editBtn);
                cell9.Controls.Add(deleteBtn);

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                row.Cells.Add(cell7);
                row.Cells.Add(cell8);
                row.Cells.Add(cell9);
                userTable.Rows.Add(row);
            }

        }

        public void editBtnClick(object sender, CommandEventArgs e)
        {
            
        }

        public void deleteBtnClick(object sender, CommandEventArgs e)
        {
            
        }

    }
}