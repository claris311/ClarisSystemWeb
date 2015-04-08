using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PedidosDetalle
    {
        public int IdPedidoDetalle { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public float Cantidad { get; set; }
        public float Precio { get; set; }

        public PedidosDetalle()
        {
            IdPedidoDetalle = 0;
            IdPedido = 0;
            IdProducto = 0;
            Cantidad = 0;
            Precio = 0;
        }

        public void Insertar()
        {
            ConexionDb conectar = new ConexionDb();
            conectar.EjecutarDB("Insert Into PedidosDetalle (IdPedido,IdProducto,Cantidad,Precio) values (" + this.IdPedido + ", " + this.IdProducto+ "," + this.Cantidad+ ", " + this.Precio + ") ");
        }

        public bool Modificar()
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Update PedidosDetalle set IdPedido = " + this.IdPedido+ " , IdProducto = " + this.IdProducto + ",  Cantidad = " + this.Cantidad+ ", Precio = " + this.Precio+ " where IdPedidoDetalle =  " + this.IdPedidoDetalle);
        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From PedidosDetalle  where IdPedidoDetalle = " + id);
        }

        public static DataTable Listar(string campo, string filtro)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.BuscarDb("Select " + campo + " from PedidosDetalle where " + filtro);
        }

        public bool Buscar()
        {
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();
            bool msj = false;

            dt = conectar.BuscarDb("select * from PedidosDetalle where IdPedidoDetalle = " + this.IdPedidoDetalle);
            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdPedidoDetalle = (int)dt.Rows[0]["IdPedidoDetalle"];
                this.IdPedido = (int)dt.Rows[0]["IdPedido"];
                this.IdProducto = (int)dt.Rows[0]["IdProducto"];
                this.Cantidad = (float)dt.Rows[0]["Cantidad"];
                this.Precio = (float)dt.Rows[0]["Precio"];
                
            }
            return msj;
        }

    }
}
