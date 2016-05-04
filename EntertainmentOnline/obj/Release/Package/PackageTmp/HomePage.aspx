<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="HomePage.aspx.cs" Inherits="EntertainmentOnline.HomePage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <style>.search { width: 400px }</style>
    <div>
        <h1>Available Rentals</h1> <br />

        <strong>Search Title: </strong>
        <asp:TextBox runat="server" id="search" CssClass="search" />
        <span style="padding-left:2em;"><strong>Filter: </strong></span>
        <select runat="server" id="rentalType">
            <option value="None">None</option>
            <option value="movie">Movies</option>
            <option value="videogame">Video Games</option>
        </select>
        <asp:Button runat="server" Text="Search" CssClass="btn btn-sm btn-primary" />
        <br /><br />

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
    </div>

</asp:Content>
