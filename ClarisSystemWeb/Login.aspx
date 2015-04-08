<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClarisSystemWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio de Sesion</title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding-top: 50px;">
            <div class="login-card">
                <h1>Inicio de Sesion</h1>
                <br />
                <asp:TextBox ID="UserNameTextBox" required="true" name="user" placeholder="Username" runat="server"></asp:TextBox>
                <asp:TextBox ID="ClaveTextBox" required="true" TextMode="Password" name="pass" placeholder="Password" runat="server"></asp:TextBox>
                <asp:Button ID="IniciarSesionButton" name="login" class="login login-submit" runat="server" Text="Iniciar Sesion" OnClick="IniciarSesionButton_Click" />

                <div class="login-help">
                    <a href="#">Register</a>
                </div>
            </div>

            <!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

            <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>
        </div>
        <div id="footer">
            <div>
                <div style="padding-bottom: 10px;">
                    <ul>
                        <li>&nbsp;<h2><a href="index.html">Mision</a></h2>
                            <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet... <a class="more" href="index.html">Read more</a></p>
                        </li>
                        <li>&nbsp;<h2><a href="index.html">Vision</a></h2>
                            <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet... <a class="more" href="index.html">Read more</a></p>
                        </li>
                        <li>&nbsp;<h2><a href="index.html">Valores</a></h2>
                            <p>Honestidad, Eficiencia, Responsabilidad,Excelente </p>
                            <p>servicio <a class="more" href="index.html">Read more</a></p>
                        </li>
                    </ul>
                </div>
                <p class="footnote">&copy; 2011 Healthy Life. All Rights Reserved.</p>
            </div>
        </div>
    </form>
</body>
</html>
