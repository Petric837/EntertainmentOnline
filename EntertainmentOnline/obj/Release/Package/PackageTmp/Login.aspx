<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="Login.aspx.cs" Inherits="EntertainmentOnline.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>Log In</h1> <br />

        <p runat="server" id="status" style="color:red;"></p>

        <strong>Username</strong> <br />
        <asp:TextBox runat="server" ID="username" />
        <br /><br />

        <strong>Password</strong> <br />
        <asp:TextBox runat="server" ID="password" />
        <br /><br />

        <asp:Button runat="server" CssClass="btn btn-primary" Text="Log In" OnClick="onLogin" />

    </div>

</asp:Content>
