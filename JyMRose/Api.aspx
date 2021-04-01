<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Api.aspx.cs" Inherits="JyMRose.Api" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Api-Obtener token</h1>
        <div>
            <asp:Button ID="btnToken" runat="server" Text="Obtener token" OnClick="btnToken_Click" />
        </div>
        <label>Token</label>
        <asp:Label ID="lblToken" runat="server" Text=""></asp:Label>
        
        
    </div>
</asp:Content>
