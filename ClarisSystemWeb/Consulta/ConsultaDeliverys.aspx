<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultaDeliverys.aspx.cs" Inherits="ClarisSystemWeb.Consulta.ConsultaDeliverys" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style8 {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Panel ID="menuPanel" runat="server" BackColor="#CCFFFF" Height="346px" Width="254px">
        <table class="auto-style8">
            <tr>
                <td style="background-color: #FF0066; font-family: georgia, 'Times New Roman', Times, serif; font-size: 22px; color: #000000;">Registros</td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="registroclientesHyperLink1" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Registro/RegistroClientes.aspx">Registro Clientes</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="registrodeliverysHyperLink2" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Registro/RegistroDeliverys.aspx">Registro Deliverys</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="registroproductosHyperLink2" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Registro/RegistroProductos.aspx">Registro Productos</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="registropedidosHyperLink2" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Registro/RegistroPedidos.aspx">Registro Pedidos</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="registroentregasHyperLink2" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Registro/RegistroEntregas.aspx">Registro Entregas</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="font-family: georgia, 'Times New Roman', Times, serif; font-size: 22px; color: #000000; background-color: #FF0066">Consultas</td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="consultaclientesHyperLink0" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Consulta/ConsultaClientes.aspx">Consulta Clientes</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="consultadeliverysHyperLink1" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Consulta/ConsultaDeliverys.aspx">Consulta Deliverys</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="consultaproductosHyperLink1" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Consulta/ConsultaProductos.aspx">Consulta Productos</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="consultapedidosHyperLink1" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Consulta/ConsultaPedidos.aspx">Consulta Pedidos</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="consultaentregasHyperLink1" runat="server" Font-Bold="False" Font-Size="Medium" NavigateUrl="~/Consulta/ConsultaEntregas.aspx">Consulta Entregas</asp:HyperLink>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="buscarLabel" runat="server" Font-Bold="True" Font-Size="Large" Text="Buscar"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="buscarDropDownList" runat="server" Height="28px" Width="252px">
                    <asp:ListItem>IdDelivery</asp:ListItem>
                    <asp:ListItem>Nombre</asp:ListItem>
                    <asp:ListItem>Cedula</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="buscarTextBox" runat="server" Width="251px"></asp:TextBox>
                <asp:Button ID="buscarButton" runat="server" Font-Bold="True" Font-Size="Large" Height="32px" OnClick="buscarButton_Click" Text="Buscar" Width="128px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="buscarGridView" runat="server" Font-Bold="False" Height="332px" Width="772px">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="IdDelivery" DataNavigateUrlFormatString="/Registro/RegistroDeliverys.aspx?IdDelivery={0}" Text="Editar" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
