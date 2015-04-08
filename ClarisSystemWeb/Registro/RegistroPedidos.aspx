<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RegistroPedidos.aspx.cs" Inherits="ClarisSystemWeb.Registro.RegistroPedidos" %>
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
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="458px" Width="810px" Font-Bold="True" Font-Names="Georgia" Font-Size="Large">
        <table class="auto-style8">
            <tr>
                <td colspan="2" style="font-family: Georgia, 'Times New Roman', Times, serif; font-size: 22px; color: #000000; background-color: #FF0066">Registro Pedidos</td>
            </tr>
            <tr>
                <td class="auto-style9">Delivery</td>
                <td>
                    <asp:DropDownList ID="DeliveryDropDownList" runat="server" Height="25px" Width="217px">
                    </asp:DropDownList>
                    <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" Text="Buscar Pedidos" Width="106px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2">
                    <asp:GridView ID="PedidosGridView" runat="server" AutoGenerateColumns="False" Width="100%">
                        <Columns>
                            <asp:CommandField ButtonType="Button" SelectText="Entregado" ShowSelectButton="True" />
                            <asp:BoundField DataField="idPedido" HeaderText="idPedido" />
                            <asp:BoundField DataField="Cliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="Monto" HeaderText="Monto" />
                            <asp:TemplateField HeaderText="Entregado?">
                                <ItemTemplate>
                                    <span></span>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
