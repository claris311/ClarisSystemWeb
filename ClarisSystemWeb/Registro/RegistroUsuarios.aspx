<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="ClarisSystemWeb.Registro.RegistroUsuarios" %>
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
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="356px" Width="619px" Font-Bold="True" Font-Names="Georgia" Font-Size="Large">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5" colspan="3" style="border-style: inset; border-width: medium; font-family: Georgia, 'Times New Roman', Times, serif; background-color: #FF0066">&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Names="Snap ITC" Font-Size="X-Large" ForeColor="Black" Text="Registro Usuarios"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">IdUsuario</td>
            <td class="auto-style6">
                <asp:TextBox ID="idusuarioTextBox" runat="server" Height="23px" Width="183px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Usuario</td>
            <td class="auto-style6">
                <asp:TextBox ID="usuarioTextBox" runat="server" Height="23px" Width="243px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Clave</td>
            <td class="auto-style6">
                <asp:TextBox ID="claveTextBox" runat="server" Height="23px" Width="180px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Nivel</td>
            <td class="auto-style6">
                <asp:DropDownList ID="nivelDropDownList0" runat="server" Height="25px" Width="193px">
                    <asp:ListItem Value="1">Administrador</asp:ListItem>
                    <asp:ListItem Value="0">Cliente</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Cliente</td>
            <td class="auto-style6">
                <asp:DropDownList ID="idclienteDropDownList" runat="server" Height="25px" Width="193px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">
                <asp:CheckBox ID="esactivoCheckBox" runat="server" Text="Es Activo" />
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
