<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebService.aspx.cs" Inherits="JyMRose.WebService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Web Service</h1>
        <label>Cédula</label>
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <asp:GridView ID="gvUser" runat="server"></asp:GridView>
    </div>

</asp:Content>
