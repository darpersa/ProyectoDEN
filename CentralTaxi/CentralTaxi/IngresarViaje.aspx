<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresarViaje.aspx.cs" Inherits="CentralTaxi.IngresarViaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Nombre Cliente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="margin-left: 120px">
                <asp:Label ID="Label4" runat="server" Text="Direccion de Inicio"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDireccionInicio" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="margin-left: 200px">
                <asp:Label ID="Label5" runat="server" Text="Direccion de Fin"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDireccionFin" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="margin-left: 200px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" onclick="btnGuardar_Click" 
                    Text="Guardar Viaje" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
