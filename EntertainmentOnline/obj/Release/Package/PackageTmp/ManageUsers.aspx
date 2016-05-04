<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="ManageUsers.aspx.cs" Inherits="EntertainmentOnline.ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>Manage Users</h1> <br />

        <asp:Table runat="server" ID="userTable">
            <asp:TableRow>
                	<asp:TableCell><strong>Username</strong></asp:TableCell>
                	<asp:TableCell><strong>Password</strong></asp:TableCell>
                	<asp:TableCell><strong>Address</strong></asp:TableCell>
                	<asp:TableCell><strong>Phone</strong></asp:TableCell>
                	<asp:TableCell><strong>Card Type</strong></asp:TableCell>
                	<asp:TableCell><strong>Card Number</strong></asp:TableCell>
                    <asp:TableCell><strong>Role</strong></asp:TableCell>
            	</asp:TableRow>
        </asp:Table>

    </div>

</asp:Content>
