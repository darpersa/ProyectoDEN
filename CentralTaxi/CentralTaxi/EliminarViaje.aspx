<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EliminarViaje.aspx.cs" Inherits="CentralTaxi.EliminarViaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" 
                    Text="Ingrese Id del Viaje que desea Eliminar"></asp:Label>
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
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Id del viaje"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblId" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Nombre del Cliente"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Direccion Inicio"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDireccionInicio" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Direccion Final"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDireccionFinal" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
                    Text="Eliminar Viaje" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>
