<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="JyMRose.Finca.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Editar Finca</h1>
        <table style="width:100%;"><tr><td colspan="2">
            
            <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td></tr><tr><td style="width: 174px">Nombre</td><td>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td></tr><tr><td style="width: 174px; height: 20px">Descripcion</td><td style="height: 20px">
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </td></tr><tr><td style="width: 174px">&nbsp;</td><td>
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            </td></tr>

        </table>
        </div>
</asp:Content>
