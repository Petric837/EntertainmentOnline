<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="SignUp.aspx.cs" Inherits="EntertainmentOnline.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>Sign Up Form</h1> <br />

        <strong>Username</strong> <br />
        <asp:TextBox runat="server" ID="username" />
        <br /><br />

        <strong>Password</strong> <br />
        <asp:TextBox runat="server" ID="password" />
        <br /><br />

        <strong>Address</strong> <br />
        <asp:TextBox runat="server" ID="address" />
        <br /><br />

        <strong>Phone</strong> ###-###-#### <br />
        <asp:TextBox runat="server" ID="phone" />
        <br /><br />

        <strong>Credit Card</strong> <br />
        Type: 
        <select runat="server" id="cardType">
            <option value="Visa">Visa</option>
            <option value="Discover">Discover</option>
            <option value="MasterCard">MasterCard</option>
            <option value="American Express">American Express</option>
        </select>
        <br />
        Card Number: <asp:TextBox runat="server" ID="cardNumber" />
        <br /><br />

        <asp:Button runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="onSubmit" />

    </div>

</asp:Content>
