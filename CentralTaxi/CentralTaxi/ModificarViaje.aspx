<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarViaje.aspx.cs" Inherits="CentralTaxi.ModificarViaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="lblIdda" runat="server" 
                    Text="Ingrese Id del Viaje que desea Modificar"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                    Text="Buscar Viaje" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Id Viaje"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblId" runat="server"></asp:Label>
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
            <td>
                <asp:Label ID="Label4" runat="server" Text="Direccion Inicio"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDireccionInicio" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Direccion Final"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDireccionFinal" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnModificar" runat="server" onclick="btnModificar_Click" 
                    Text="Guardar Modificaciones" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
