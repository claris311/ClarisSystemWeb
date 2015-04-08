<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultaClientes.aspx.cs" Inherits="ClarisSystemWeb.Consulta.ConsultaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="buscarLabel" runat="server" Font-Bold="True" Font-Size="Large" Text="Buscar"></asp:Label>
        </td>
        <td>
                <asp:DropDownList ID="buscarDropDownList" runat="server" Height="28px" Width="252px">
                    <asp:ListItem>IdCliente</asp:ListItem>
                    <asp:ListItem>Nombre</asp:ListItem>
                    <asp:ListItem>Cedula</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="buscarTextBox" runat="server" Width="251px"></asp:TextBox>
                <asp:Button ID="buscarButton" runat="server" Font-Bold="True" Font-Size="Large" Height="32px" OnClick="buscarButton_Click" Text="Buscar" Width="128px" />
            </td>
    </tr>
    <tr>
        <td colspan="2">
                <asp:GridView ID="buscarGridView" runat="server" Height="332px" Width="772px" Font-Bold="False">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdCliente" DataNavigateUrlFormatString="/Registro/RegistroClientes.aspx?IdCliente={0}" Text="Editar" />
                    </Columns>
                </asp:GridView>
            </td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    </asp:Content>

