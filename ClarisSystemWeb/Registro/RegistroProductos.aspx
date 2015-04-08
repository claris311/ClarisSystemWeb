<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RegistroProductos.aspx.cs" Inherits="ClarisSystemWeb.Registro.RegistroProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style7 {
        width: 117px;
    }
    .auto-style6 {
        width: 321px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="388px" Width="619px" Font-Bold="True" Font-Names="Georgia" Font-Size="Large">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5" colspan="3" style="border-style: inset; border-width: medium; font-family: Georgia, 'Times New Roman', Times, serif; background-color: #FF0066">&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Names="Snap ITC" Font-Size="X-Large" ForeColor="Black" Text="Registro Productos"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">IdProducto</td>
                <td class="auto-style6">
                    <asp:TextBox ID="idproductoTextBox" runat="server" Height="23px" Width="183px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Descripcion</td>
                <td class="auto-style6">
                    <asp:TextBox ID="descripcionTextBox" runat="server" Height="68px" Width="265px"></asp:TextBox>
                </td>
                <td rowspan="2">
                    <asp:Image ID="fotoImage" runat="server" Height="139px" Width="158px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Precio</td>
                <td class="auto-style6">
                    <asp:TextBox ID="precioTextBox" runat="server" Height="23px" Width="180px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Existencia</td>
                <td class="auto-style6">
                    <asp:TextBox ID="existenciaTextBox" runat="server" Height="23px" Width="182px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">url Foto</td>
                <td class="auto-style6">
                    <asp:TextBox ID="fotoTextBox" runat="server" Height="23px" Width="182px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="3">&nbsp;&nbsp;<asp:Button ID="NuevoButton" runat="server" Font-Bold="True" Font-Size="X-Large" Height="38px" Text="Nuevo" Width="108px" OnClick="NuevoButton_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="guardarButton" runat="server" Font-Bold="True" Font-Size="X-Large" Height="34px" Text="Guardar" Width="113px" OnClick="guardarButton_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="EliminarButton" runat="server" Font-Bold="True" Font-Size="X-Large" Height="39px" Text="Eliminar" Width="117px" OnClick="EliminarButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="3">
                    <asp:Label ID="mensajeLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
