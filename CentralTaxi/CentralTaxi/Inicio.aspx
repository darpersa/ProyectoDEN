<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="CentralTaxi.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ViajeSource">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Cliente" HeaderText="Cliente" 
                    SortExpression="Cliente" />
                <asp:BoundField DataField="DireccionInicio" HeaderText="DireccionInicio" 
                    SortExpression="DireccionInicio" />
                <asp:BoundField DataField="DirecconFinal" HeaderText="DirecconFinal" 
                    SortExpression="DirecconFinal" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ViajeSource" runat="server" 
            SelectMethod="obtenerListaViaje" TypeName="CentralTaxi.Inicio">
        </asp:ObjectDataSource>
        <br />
    </p>
</asp:Content>
