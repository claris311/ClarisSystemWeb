<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultaPedidos.aspx.cs" Inherits="ClarisSystemWeb.Consulta.ConsultaPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="buscarLabel" runat="server" Font-Bold="True" Font-Size="Large" Text="Buscar"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="buscarDropDownList" runat="server" Height="28px" Width="252px">
                <asp:ListItem>IdPedido</asp:ListItem>
                <asp:ListItem>IdCliente</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="buscarTextBox" runat="server" Width="251px"></asp:TextBox>
            <asp:Button ID="buscarButton" runat="server" Font-Bold="True" Font-Size="Large" Height="32px" OnClick="buscarButton_Click" Text="Buscar" Width="128px" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="buscarGridView" runat="server" Font-Bold="False" Height="332px" Width="772px">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="IdProducto" DataNavigateUrlFormatString="/Registro/RegistroProductos.aspx?IdProducto={0}" Text="Editar" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
