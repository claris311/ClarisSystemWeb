using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

namespace ClarisSystemWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IniciarSesionButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario  = new Usuarios();

            if(usuario.Autenticar(UserNameTextBox.Text, ClaveTextBox.Text )){
                FormsAuthentication.RedirectFromLoginPage(UserNameTextBox.Text , true );
                
                //buscamos la info del usuario para guardar el nivel y nivel.
                usuario.Buscar(usuario.IdUsuario);
                Session["IdUsuario"] = usuario.IdUsuario;
                Session["NivelUsuario"] = usuario.Nivel;
            }
            else
            {
                Response.Write("datos de inicio de sesion incorrectos");
            }
        }
    }
}