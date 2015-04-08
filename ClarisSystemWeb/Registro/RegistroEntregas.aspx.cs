using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Registro
{
    public partial class RegistroEntregas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PedidosGridView.DataSource = Pedidos.Listar("p.idPedido,c.idCliente,c.Nombres,p.Fecha,p.Monto,p.EsEntregado", "Pedidos p  Inner Join Clientes c on p.IdCliente = c.IdCliente", "p.idCliente > 0");
                PedidosGridView.DataBind();
            }
        }

    }
}