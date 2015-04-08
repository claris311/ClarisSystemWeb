using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL; 

namespace ClarisSystemWeb.Consulta
{
    public partial class ConsultaPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buscarGridView.DataSource = Pedidos.Listar("p.IdPedido, c.Nombres as NombreCliente,p.Fecha,pd.IdProducto, pr.Descripcion,pd.Cantidad, pr.Precio,p.Monto","Pedidos p inner join PedidosDetalle pd on (pd.IdPedido = p.IdPedido)  inner join Productos pr on (pd.IdProducto = pr.IdProducto) inner join Clientes c on (p.IdCliente = c.IdCliente)","1 = 1");
            buscarGridView.DataBind();

        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            if (buscarDropDownList.SelectedIndex == 0)
            {

                buscarGridView.DataSource = Pedidos.Listar("p.IdPedido, c.Nombres as NombreCliente,p.Fecha,pd.IdProducto, pr.Descripcion,pd.Cantidad, pr.Precio,p.Monto", "Pedidos p inner join PedidosDetalle pd on (pd.IdPedido = p.IdPedido)  inner join Productos pr on (pd.IdProducto = pr.IdProducto) inner join Clientes c on (p.IdCliente = c.IdCliente)", " p.IdPedido = "+ buscarTextBox.Text);
                buscarGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 1)
            {

                buscarGridView.DataSource = Pedidos.Listar("p.IdPedido, c.Nombres as NombreCliente,p.Fecha,pd.IdProducto, pr.Descripcion,pd.Cantidad, pr.Precio,p.Monto", "Pedidos p inner join PedidosDetalle pd on (pd.IdPedido = p.IdPedido)  inner join Productos pr on (pd.IdProducto = pr.IdProducto) inner join Clientes c on (p.IdCliente = c.IdCliente)", " p.IdCliente = " + buscarTextBox.Text);
                buscarGridView.DataBind();
            }
        }
    }
}