<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="JyMRose.Finca.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h1>Fincas</h1>
             
         <a href="Nuevo.aspx">Nuevo</a>
         <asp:GridView ID="gvFinca" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333">
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 
                 <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                 <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                 <asp:TemplateField HeaderText="Opciones">
                     <ItemTemplate>
                         <asp:LinkButton ID="linkbtnBorrar" runat="server" OnClientClick="return confirm('Desea Borrar registro?')" OnClick="linkbtnBorrar_Click">Borrar</asp:LinkButton>
                         <a href="Editar.aspx?nombre=<%# Eval("Nombre") %>">Editar</a>
                         <asp:HiddenField ID="HiddenFieldNombre" runat="server" Value='<%# Eval("Nombre") %>' />
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
             <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
             <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
             <SortedAscendingCellStyle BackColor="#FDF5AC" />
             <SortedAscendingHeaderStyle BackColor="#4D0000" />
             <SortedDescendingCellStyle BackColor="#FCF6C0" />
             <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>

    </div>
</asp:Content>
