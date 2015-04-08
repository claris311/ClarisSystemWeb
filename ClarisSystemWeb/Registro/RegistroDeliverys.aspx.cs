using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Registro
{
    public partial class RegistroDeliverys : System.Web.UI.Page
    {
        public void LLenarClase(Deliverys delivery)
        {
            delivery.Nombres = nombresTextBox.Text;
            delivery.Telefono = telefonoTextBox.Text;
            delivery.Celular = celularTextBox.Text;
            delivery.Cedula = cedulaTextBox.Text;
            delivery.Email = emailTextBox.Text;
            delivery.Direccion = direccionTextBox.Text;


        }

        public void LLenarCampos(Deliverys delivery)
        {
            iddeliveryTextBox.Text = delivery.IdDelivery.ToString();
            nombresTextBox.Text = delivery.Nombres;
            telefonoTextBox.Text = delivery.Telefono;
            celularTextBox.Text = delivery.Celular;
            cedulaTextBox.Text = delivery.Cedula;
            emailTextBox.Text = delivery.Email;
            direccionTextBox.Text = delivery.Direccion;


        }

        public void LimpiarCampos()
        {
            iddeliveryTextBox.Text = "";
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
                    Deliverys delivery = new Deliverys();
                    if (Request.QueryString["IdDelivery"] != null)
                    {
                        delivery.IdDelivery = int.Parse(Request.QueryString["IdDelivery"]);
                        if (delivery.Buscar())
                            this.LLenarCampos(delivery);

                    }
                }
            }

        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            Deliverys delivery = new Deliverys();
            this.LLenarClase(delivery);
           

            if (Request.QueryString["IdDelivery"] != null)
            {
                delivery.IdDelivery = int.Parse(Request.QueryString["IdDelivery"]);
                delivery.Modificar();
                mensajeLabel.Text = "El registro se ha Modificado Correctamente";
            }
            else
            {
                delivery.Insertar();
                mensajeLabel.Text = "El registro se ha Guardado Correctamente";
 
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Deliverys.Eliminar(int.Parse(Request.QueryString["IdDelivery"]));
            mensajeLabel.Text = "El registro se ha Eliminado Correctamente";
        }
    }
}