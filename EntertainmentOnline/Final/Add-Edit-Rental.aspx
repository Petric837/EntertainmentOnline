<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="Add-Edit-Rental.aspx.cs" Inherits="EntertainmentOnline.Add_Edit_Rental" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <h1 runat="server" id="header"></h1> <br />

        <strong>Type</strong> <br />
        <select runat="server" id="type">
            <option value="movie">movie</option>
            <option value="videogame">videogame</option>
        </select>
        <br /><br />

        <strong>Title</strong> <br />
        <asp:TextBox runat="server" ID="title" />
        <br /><br />

        <strong>Genre</strong> <br />
        <asp:TextBox runat="server" ID="genre" />
        <br /><br />

        <strong>Release Date</strong> <br />
        <asp:TextBox runat="server" ID="releaseDate" />
        <br /><br />

        <strong>Price</strong> <br />
        <asp:TextBox runat="server" ID="price" />
        <br /><br />

        <strong>Review Score</strong> <br />
        <asp:TextBox runat="server" ID="reviewScore" />
        <br /><br />

        <asp:Button runat="server" ID="addBtn" CssClass="btn btn-primary" Text="Add Rental" OnClick="onAdd" />
        <asp:Button runat="server" ID="editBtn" CssClass="btn btn-primary" Text="Apply Changes" OnClick="onEdit" />

    </div>

</asp:Content>