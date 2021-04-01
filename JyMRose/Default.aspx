<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JyMRose._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Bienvenido</h1>
        <p class="lead"><asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></p>
        <p class="lead"><asp:Label ID="lblApellido" runat="server" Text=""></asp:Label></p>
       
    </div>

</asp:Content>
