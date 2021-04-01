<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JyMRose.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>JyMRose</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-default col-md-4">
            <div class="panel-heading">Login</div>
            <div class="form-group">
            <label for="email">Usuario</label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="pwd">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
          </div>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />         
          
        </div>
    </form>
</body>
</html>
