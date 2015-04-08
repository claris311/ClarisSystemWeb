<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ClarisSystemWeb.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 230px;
        }

        .auto-style4 {
            width: 554px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="458px" Width="810px" Font-Bold="True" Font-Names="Georgia" Font-Size="Large">

        <asp:Repeater ID="ProductosRepeater" runat="server">
            <ItemTemplate>
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3" rowspan="4">
                            <img src="<%# Eval("Foto") %>" alt="Imagen del producto" height="117" width="231" />
                        </td>
                        <td class="auto-style4">
                            <span><%# Eval("Descripcion") %></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <span><%# "Precio: " + Eval("Precio") %></span>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style4">
                            <a href="/Carrito.aspx?add=<%# Eval("IdProducto") %>"  title="Agregar al Carrito" style="font-style: normal;">Agregar al Carrito</a>
                        </td>
                    </tr>
                </table>

            </ItemTemplate>
        </asp:Repeater>
    </asp:Panel>
</asp:Content>
