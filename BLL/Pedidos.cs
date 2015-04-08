using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public Boolean EsEntrega { get; set; }

        public Pedidos()
        {
            IdPedido = 0;
            IdCliente = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            EsEntrega = false;
        }

        public bool Insertar()
        {
            ConexionDb conectar = new ConexionDb();
           return  conectar.EjecutarDB("Insert Into Pedidos (IdCliente,Fecha, Monto, EsEntregado) values (" + this.IdCliente + ", '" + this.Fecha.ToString("yyyy/MM/dd") + "'," + this.Monto + ", '" + this.EsEntrega + "') ");
        }

        public bool Modificar()
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Update Pedidos set IdCliente = " + this.IdCliente + " , Fecha ='" + this.Fecha.ToString("yyyy/MM/dd") + "',  Monto = " + this.Monto + ", EsEntregado = '" + this.EsEntrega + "' where IdPedido =  " + this.IdPedido);
        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From Pedidos  where IdPedido = " + id);
        }

        public static DataTable Listar(string campos, string tabla, string filtro)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.BuscarDb("Select " + campos + " from " + tabla + " where " + filtro);
        }

        public bool Buscar()
        {
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();
            bool msj = false;

            dt = conectar.BuscarDb("select * from Pedidos where IdPedido = " + this.IdPedido);
            if (dt.Rows.Count > 0)
            {
                msj = true;
                this.IdPedido = (int)dt.Rows[0]["IdPedido"];
                this.IdCliente = (int)dt.Rows[0]["IdCliente"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Monto = (float)dt.Rows[0]["Monto"];
                this.EsEntrega = (Boolean)dt.Rows[0]["EsEntregado"];

            }
            return msj;
        }

        public static  int ultimoId()
        {
            int id = 0;
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();

            dt = conectar.BuscarDb("Select MAX(IdPedido) as id from Pedidos");

            if (dt.Rows.Count > 0)
            {
                id = (int)dt.Rows[0]["id"];

            }
            return id;
        }



    }
}
