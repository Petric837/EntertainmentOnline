<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="Unauthorized.aspx.cs" Inherits="EntertainmentOnline.Unauthorized" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="jumbotron">
        <h1>Invalid Authorization</h1> 
        <div class="alert alert-danger" role="alert">
            <strong>Alert:</strong> Your are not authorized to access this page
        </div>

    </div>

</asp:Content>
