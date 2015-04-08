using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace ClarisSystemWeb
{
    public partial class Carrito : System.Web.UI.Page
    {

        public void CalcularTotal()
        {
            if (Session["datos"] != null)
            {
                DataTable datos = Session["datos"] as DataTable;
                double total = 0;

                foreach (DataRow row in datos.Rows)
                {
                    total += Convert.ToDouble(row["SubTotal"]);
                }

                TotalCompraTextBox.Text = total.ToString();
            }
        }

        public void LimpiarCampos() 
        {
            CarritoGridView.DataSource = null;
            CarritoGridView.DataBind();
            TotalCompraTextBox.Text = "";
            CantidadTextBox.Text = "";
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            CarritoGridView.DataSource = null;
            CarritoGridView.DataBind();

            if (!IsPostBack)
            {
                if (Request.QueryString["add"] != null)
                {
                    int idArticulo = 0;
                    int.TryParse(Request.QueryString["add"], out idArticulo);

                    BLL.Productos producto = new BLL.Productos();
                    producto.IdProducto = idArticulo;
                    producto.Buscar();

                    PrecioLabel.Text = producto.Precio.ToString();
                    NombreLabel.Text = producto.Descripcion;
                }
            }

            if (Session["datos"] != null)
            {
                DataTable datos = Session["datos"] as DataTable;
                CarritoGridView.DataSource = datos;
                CarritoGridView.DataBind();
            }
            CalcularTotal();
        }


        
        protected void guardarButton_Click(object sender, EventArgs e)
        {

        }

        protected void AgregarCarritoButton_Click(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();

            if (Session["datos"] == null)
            {
                datos = new DataTable();
                datos.Columns.Add(new DataColumn("idProducto"));
                datos.Columns.Add(new DataColumn("Descripcion"));
                datos.Columns.Add(new DataColumn("Precio"));
                datos.Columns.Add(new DataColumn("Cantidad"));
                datos.Columns.Add(new DataColumn("SubTotal"));
            }
            else
            {
                datos = Session["datos"] as DataTable;
            }

            DataRow row = datos.NewRow();
            row["IdProducto"] = Request.QueryString["add"];
            row["Descripcion"] = NombreLabel.Text;
            row["Precio"] = PrecioLabel.Text;
            row["Cantidad"] = CantidadTextBox.Text;
            row["SubTotal"] = (int.Parse(PrecioLabel.Text) * int.Parse(CantidadTextBox.Text));
            datos.Rows.Add(row);
            Session["datos"] = datos;
            CarritoGridView.DataSource = datos;
            CarritoGridView.DataBind();
            this.CalcularTotal();
        }

        protected void CarritoGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }

        protected void CarritoGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataTable dt1 = Session["datos"] as DataTable;
            dt1.Rows[index].Delete();
            Session["datos"] = dt1;

            CarritoGridView.DataSource = dt1;
            CarritoGridView.DataBind();
            CalcularTotal();
        }

        protected void cancelarButton_Click(object sender, EventArgs e)
        {
            Session["datos"] = null;
            Response.Redirect("/default.aspx");
        }

        protected void enviarButton0_Click(object sender, EventArgs e)
        {
            if (Session["datos"] != null)
            {
                int idUsuario = int.Parse(Session["IdUsuario"].ToString());
                int idCliente = Usuarios.BuscarIdClientebyUsuario(idUsuario);
                Pedidos pedido = new Pedidos();
                PedidosDetalle pedidodetalle = new PedidosDetalle();

                pedido.IdCliente = idCliente;
                pedido.Fecha = DateTime.Now;
                pedido.Monto = float.Parse(TotalCompraTextBox.Text);
                pedido.EsEntrega = false;

                if (pedido.Insertar())
                {

                    DataTable datos = Session["datos"] as DataTable;
                    foreach (DataRow row in datos.Rows)
                    {
                        pedidodetalle.IdPedido = Pedidos.ultimoId();
                        pedidodetalle.IdProducto = int.Parse(row["idProducto"].ToString());
                        pedidodetalle.Cantidad = int.Parse(row["Cantidad"].ToString());
                        pedidodetalle.Precio = int.Parse(row["Precio"].ToString());

                        pedidodetalle.Insertar();
                    }
                }

                Session["datos"] = null;

                this.LimpiarCampos();
                mensajeLabel.Text = "Pedido enviado correctamente";
            }
            else
            {
                Response.Write("No posee ningun articulo en su carrito");
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Productos.aspx");
        }
    }
}