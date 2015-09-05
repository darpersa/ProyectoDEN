
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarTaxi.aspx.cs" Inherits="Navegacion.BuscarTaxi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
            <br />
&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Buscar Taxi"></asp:Label>
            <br />
            &nbsp;<asp:RadioButton ID="rdbPatente" runat="server" Text="Por Patente" />
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdbConductor" runat="server" Text="Por Conductor" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRefrescar" runat="server" Height="21px" 
    Text="Refrescar" Width="62px" onclick="btnRefrescar_Click"/>
            <br />
            <br />
&nbsp;
            <asp:Label ID="lblTmpBusca" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="158px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label6" runat="server" Text="Informacion"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMuestraTaxi" runat="server" Width="231px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
