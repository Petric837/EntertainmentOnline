<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="Checkout.aspx.cs" Inherits="EntertainmentOnline.Checkout" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="jumbotron">
        <h1>Order Confirmation</h1> 
        <p>Thank you for your order! Your rentals will be shipped to your listed address.</p>
        <p>Order Confirmation ID:  1qaz2wsx3edc4rfv</p>
        <br />
        <strong>Your Account Info:</strong><br />
        <span runat="server" id="info"></span>
        <br /><br />

        <asp:Button runat="server" Text="Return to Home Page" CssClass="btn btn-primary" OnClick="onReturn" />
    </div>

</asp:Content>
