<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="ShoppingCart.aspx.cs" Inherits="EntertainmentOnline.ShoppingCart" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>Shopping Cart</h1> <br />

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

        <strong><span runat="server" id="total" style="font-size:18px"></span></strong>
        <br /><br />

        <asp:Button runat="server" Text="Checkout" CssClass="btn btn-lg btn-primary" OnClick="checkoutBtnClick" />
    </div>

</asp:Content>
