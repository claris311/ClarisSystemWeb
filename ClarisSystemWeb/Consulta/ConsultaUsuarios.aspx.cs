using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ClarisSystemWeb.Consulta
{
    public partial class ConsultaUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            this.buscarGridView.DataSource = Usuarios.ListarTodo("*", "1=1");
            this.buscarGridView.DataBind();
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            if (buscarDropDownList.SelectedIndex == 0)
            {

                buscarGridView.DataSource = Usuarios.ListarTodo("*", "IdUsuario like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 1)
            {

                buscarGridView.DataSource = Usuarios.ListarTodo("*", "Nombre like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 2)
            {

                buscarGridView.DataSource = Usuarios.ListarTodo("*", "Nivel like '" + buscarTextBox.Text + "%'");
                buscarGridView.DataBind();
            }

        }
    }
}