using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Registro
{
    public partial class RegistroClientes : System.Web.UI.Page
    {

        public void LLenarClase(Clientes cliente)
        {
            cliente.Nombres = nombresTextBox.Text;
            cliente.Telefono = telefonoTextBox.Text;
            cliente.Celular = celularTextBox.Text;
            cliente.Cedula = cedulaTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Direccion = direccionTextBox.Text;


        }

        public void LLenarCampos(Clientes cliente)
        {
            idClienteTextBox.Text = cliente.IdCliente.ToString();
            nombresTextBox.Text = cliente.Nombres;
            telefonoTextBox.Text = cliente.Telefono;
            celularTextBox.Text = cliente.Celular;
            cedulaTextBox.Text = cliente.Cedula;
            emailTextBox.Text = cliente.Email;
            direccionTextBox.Text = cliente.Direccion;


        }

        public void LimpiarCampos()
        {
            idClienteTextBox.Text = "";
            nombresTextBox.Text = "";
            telefonoTextBox.Text = "";
            celularTextBox.Text = "";
            cedulaTextBox.Text = "";
            emailTextBox.Text = "";
            direccionTextBox.Text = "";

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Clientes cliente = new Clientes();
                    if (Request.QueryString["IdCliente"] != null)
                    {
                        cliente.IdCliente = int.Parse(Request.QueryString["IdCliente"]);
                        if (cliente.Buscar())
                            this.LLenarCampos(cliente);

                    }
                }
            }


        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {

            Clientes cliente = new Clientes();
            this.LLenarClase(cliente);


            if (Request.QueryString["IdCliente"] != null)
            {
                cliente.IdCliente = Convert.ToInt32(Request.QueryString["IdCliente"]);
                cliente.Modificar();
                mensajeLabel.Text = "El registro se ha Modificado Correctamente";
            }
            else
            {
                cliente.Insertar();
                mensajeLabel.Text = "El registro se ha Guardado Correctamente";

            }



        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Clientes.Eliminar(int.Parse(Request.QueryString["IdCliente"]));
            mensajeLabel.Text = "El registro se ha eliminado";
            this.LimpiarCampos();
        }
    }
}