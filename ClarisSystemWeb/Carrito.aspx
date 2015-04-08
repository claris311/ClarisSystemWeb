<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="ClarisSystemWeb.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 100%;
        }

        .auto-style11 {
        }

        .auto-style16 {
        }

        .auto-style18 {
            width: 163px;
        }

        .auto-style21 {
            height: 27px;
        }

        .auto-style22 {
            height: 27px;
        }

        .auto-style25 {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <% if (Request.QueryString["add"] != null)
       {
    %>
    <div>
        <table class="auto-style8">
            <tr>
                <td class="auto-style11" colspan="3" style="font-family: georgia, 'Times New Roman', Times, serif; font-size: 22px; background-color: #FF0066; color: #000000;">Carrito De Compra</td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">Articulo:
                <asp:Label ID="NombreLabel" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style25">Precio:<asp:Label ID="PrecioLabel" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style18">Cantidad:&nbsp;
                <asp:TextBox ID="CantidadTextBox" runat="server" Style="margin-left: 0px" Width="79px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style18">
                    <asp:Button ID="AgregarCarritoButton" runat="server" Text="Agregar al Carrito" OnClick="AgregarCarritoButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style16" colspan="3">
                    <hr />
                </td>
            </tr>
        </table>
    </div>
    <%} %>
    <table class="auto-style8">

        <tr>
            <td class="auto-style16" colspan="2" rowspan="2">
                <h1>Carrito de Compras</h1>
                <asp:GridView ID="CarritoGridView" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" OnRowCommand="CarritoGridView_RowCommand" OnRowDeleting="CarritoGridView_RowDeleting">
                    <Columns>

                        <asp:CommandField ButtonType="Image" DeleteImageUrl="~/images/trash.png" ShowDeleteButton="True" />

                        <asp:BoundField DataField="idProducto" Visible="false" HeaderText="idProducto" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Producto" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" />
                    </Columns>

                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />

                </asp:GridView>
            </td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22" colspan="2">Total a Pagar &nbsp;<asp:TextBox ID="TotalCompraTextBox" runat="server" Height="28px" Width="131px" Font-Bold="True" Font-Size="Large">0</asp:TextBox>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Button ID="cancelarButton" runat="server" Font-Bold="True" Font-Size="Large" Height="38px" OnClick="cancelarButton_Click" Text="Cancelar Compra" Width="221px" />
            </td>
            <td class="auto-style25">
                <asp:Button ID="continuarButton0" runat="server" Font-Bold="True" Font-Size="Large" Height="38px" OnClick="NuevoButton_Click" Text="Continuar Compra" Width="221px" />
            </td>
            <td class="auto-style18">
                <asp:Button ID="enviarButton0" runat="server" Font-Bold="True" Font-Size="Large" Height="38px" OnClick="enviarButton0_Click" Text="Enviar Pedido" Width="221px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16" colspan="3">
                <asp:Label ID="mensajeLabel" runat="server" Font-Size="25pt"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style18">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
