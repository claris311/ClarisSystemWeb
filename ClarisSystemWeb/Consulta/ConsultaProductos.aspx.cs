using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Consulta
{
    public partial class ConsultaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.buscarGridView.DataSource = BLL.Productos.Listar("*", "1=1");
            this.buscarGridView.DataBind();

        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            
            if (buscarDropDownList.SelectedIndex == 0)
            {

                buscarGridView.DataSource = BLL.Productos.Listar("*", "IdProducto like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 1)
            {

                buscarGridView.DataSource = BLL.Productos.Listar("*", "Descripcion like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
        }
    }
}