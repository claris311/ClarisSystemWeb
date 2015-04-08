using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Registro
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        public void LLenarClase(Usuarios usuario)
        {
            usuario.Nombre = usuarioTextBox.Text;
            usuario.Clave = claveTextBox.Text;
            usuario.esActivo = esactivoCheckBox.Checked;
            usuario.Nivel = int.Parse(nivelDropDownList0.SelectedValue);
            usuario.IdCliente = int.Parse(idclienteDropDownList.SelectedValue);

        }

        public void LLenarCampos(Usuarios usuario)
        {
            usuarioTextBox.Text = usuario.Nombre;
            claveTextBox.Text =  usuario.Clave;
            esactivoCheckBox.Checked = usuario.esActivo;
            nivelDropDownList0.Text = usuario.Nivel.ToString();
            idclienteDropDownList.SelectedValue = usuario.IdCliente.ToString();


        }

        public void LimpiarCampos()
        {
            usuarioTextBox.Text = "";
            claveTextBox.Text = "";
            esactivoCheckBox.Checked = false;
           
           

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Usuarios usuario = new Usuarios();
                    if (Request.QueryString["IdUsuario"] != null)
                    {
                        usuario.IdCliente = int.Parse(Request.QueryString["IdUsuario"]);
                        if (usuario.Buscar(int.Parse(Request.QueryString["IdUsuario"])));
                            this.LLenarCampos(usuario);

                    }
                }
            }

            Clientes cliente = new Clientes();
            idclienteDropDownList.DataSource = Clientes.Listar("IdCliente,Nombres", "1=1");
            idclienteDropDownList.DataValueField = "IdCliente";
            idclienteDropDownList.DataTextField = "Nombres";
            idclienteDropDownList.DataBind();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            this.LLenarClase(usuario);
            
                      
          if (Request.QueryString["IdUsuario"] != null)
            {
                usuario.IdUsuario= Convert.ToInt32(Request.QueryString["IdUsuario"]);
                usuario.Modificar();
                mensajeLabel.Text = "El registro se ha Modificado Correctamente";
            }
            else
            {
                usuario.Insertar();
                mensajeLabel.Text = "El registro se ha guardado";


            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Usuarios.Eliminar(int.Parse(Request.QueryString["IdUsuario"]));
            mensajeLabel.Text = "El registro se ha eliminado";
            this.LimpiarCampos();
           
        }
    }
}