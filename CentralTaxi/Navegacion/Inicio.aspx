<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Navegacion.Inicio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="* BIENVENIDO !"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="LOGIN"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNombre" runat="server" Width="125px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtClave" runat="server" 
            Width="125px"></asp:TextBox>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIngresar" runat="server" 
            style="margin-left: 0px" Text="Ingresar" onclick="btnIngresar_Click" />
    
    </div>
    </form>
</body>
</html>
