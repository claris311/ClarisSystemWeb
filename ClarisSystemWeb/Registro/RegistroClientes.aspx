<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RegistroClientes.aspx.cs" Inherits="ClarisSystemWeb.Registro.RegistroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
    }
    .auto-style5 {
    }
    .auto-style6 {
        width: 321px;
    }
    .auto-style7 {
        width: 117px;
    }
    .auto-style8 {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" Height="356px" Width="619px" Font-Bold="True" Font-Names="Georgia" Font-Size="Large">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5" colspan="3" style="border-style: inset; border-width: medium; font-family: Georgia, 'Times New Roman', Times, serif; background-color: #FF0066">&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Names="Snap ITC" Font-Size="X-Large" ForeColor="Black" Text="Registro Clientes"></asp:Label>
                 </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    IdCliente</td>
                <td class="auto-style6">
                    <asp:TextBox ID="idClienteTextBox" runat="server" Height="23px" Width="183px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    Nombres</td>
                <td class="auto-style6">
                    <asp:TextBox ID="nombresTextBox" runat="server" Height="23px" Width="243px" MaxLength="50"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    Telefono</td>
                <td class="auto-style6">
                    <asp:TextBox ID="telefonoTextBox" runat="server" Height="23px" Width="180px" MaxLength="12"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    Celular</td>
                <td class="auto-style6">
                    <asp:TextBox ID="celularTextBox" runat="server" Height="23px" Width="182px" MaxLength="12"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    Cedula</td>
                <td class="auto-style6">
                    <asp:TextBox ID="cedulaTextBox" runat="server" Height="23px" Width="182px" MaxLength="13"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    Email</td>
                <td class="auto-style6">
                    <asp:TextBox ID="emailTextBox" runat="server" Height="23px" Width="270px" MaxLength="50"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    Direccion</td>
                <td class="auto-style6">
                    <asp:TextBox ID="direccionTextBox" runat="server" Height="23px" Width="267px" MaxLength="100"></asp:TextBox>
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

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    </asp:Content>


