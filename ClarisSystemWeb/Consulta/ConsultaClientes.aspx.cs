using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Consulta
{
    public partial class ConsultaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.buscarGridView.DataSource = Clientes.Listar("*","1=1");
            this.buscarGridView.DataBind();
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            if (buscarDropDownList.SelectedIndex == 0)
            {

                buscarGridView.DataSource = Clientes.Listar("*", "IdCliente like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 1)
            {

                buscarGridView.DataSource = Clientes.Listar("*", "Nombres like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 2)
            {

                buscarGridView.DataSource = Clientes.Listar("*", "Cedula like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
        }
    }
}