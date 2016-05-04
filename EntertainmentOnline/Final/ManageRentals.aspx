<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="ManageRentals.aspx.cs" Inherits="EntertainmentOnline.ManageRentals" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>Manage Rentals</h1> <br />

        <asp:Table runat="server" ID="rentalTable">
            <asp:TableRow>
                	<asp:TableCell><strong>Type</strong></asp:TableCell>
                	<asp:TableCell><strong>Title</strong></asp:TableCell>
                	<asp:TableCell><strong>Genre</strong></asp:TableCell>
                	<asp:TableCell><strong>Release Date</strong></asp:TableCell>
                	<asp:TableCell><strong>Price</strong></asp:TableCell>
                	<asp:TableCell><strong>Review Score</strong></asp:TableCell>
            	</asp:TableRow>
        </asp:Table>
        <br /><br />

        <asp:Button runat="server" Text="Add Rental" CssClass="btn btn-primary" OnClick="onAddBtnClick" />
    </div>

</asp:Content>
