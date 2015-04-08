using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Registro
{
    public partial class RegistroProductos : System.Web.UI.Page
    {
        public void LLenarClase(BLL.Productos producto)
        {
            producto.Descripcion = descripcionTextBox.Text;
            producto.Precio = double.Parse(precioTextBox.Text);
            producto.Existencia = double.Parse(existenciaTextBox.Text);
            producto.Foto = fotoTextBox.Text;
        }

        public void LLenarCampos(BLL.Productos producto)
        {
            idproductoTextBox.Text = producto.IdProducto.ToString();
            descripcionTextBox.Text = producto.Descripcion;
            precioTextBox.Text = producto.Precio.ToString();
            existenciaTextBox.Text =   producto.Existencia.ToString();
            fotoTextBox.Text =  producto.Foto;

        }

        public void LimpiarCampos()
        {
            idproductoTextBox.Text = "";
            descripcionTextBox.Text = "";
            precioTextBox.Text = "";
            existenciaTextBox.Text = "";
            fotoTextBox.Text = "";
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BLL.Productos producto = new BLL.Productos();
                if (Request.QueryString["IdProducto"] != null)
                {
                    producto.IdProducto = int.Parse(Request.QueryString["IdProducto"]);
                    if (producto.Buscar())
                        this.LLenarCampos(producto);

                }
                fotoImage.ImageUrl = fotoTextBox.Text;
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        protected void guardarButton_Click(object sender, EventArgs e)
        {
            BLL.Productos producto = new BLL.Productos();
            this.LLenarClase(producto);
            
            if (Request.QueryString["IdProducto"] != null)
            {
                producto.IdProducto = int.Parse(Request.QueryString["IdProducto"]);
                producto.Modificar();
                mensajeLabel.Text = "El registro se ha Modificado Correctamente";
            }
            else
            {
                producto.Insertar();
                mensajeLabel.Text = "El registro se ha Guardado Correctamente";

            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {

            BLL.Productos.Eliminar(int.Parse(Request.QueryString["IdProducto"]));
            mensajeLabel.Text = "El registro se ha Eliminado Correctamente";

        }
    }
}