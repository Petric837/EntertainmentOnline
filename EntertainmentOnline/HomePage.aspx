<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="HomePage.aspx.cs" Inherits="EntertainmentOnline.HomePage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1>Test Database Connection</h1> <br />

        <asp:Button runat="server" CssClass="btn btn-primary" Text="Click to test database" OnClick="testdb" />
        <br />
        <div runat="server" class="alert alert-info">
            <strong>Status:</strong>
            <span runat="server" id="status"></span>
        </div>
    </div>

</asp:Content>
