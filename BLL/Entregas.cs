using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Entregas
    {
        public int IdEntrega { get; set; }
        public DateTime Fecha { get; set; }
        public int IdDelivery { get; set; }

        public Entregas()
        {
            IdEntrega = 0;
            Fecha = DateTime.Now;
            IdDelivery = 0;
        }

        public void Insertar()
        {
            ConexionDb conectar = new ConexionDb();
            conectar.EjecutarDB("Insert Into Entregas (Fecha, IdDelivery) values ( '" + this.Fecha.ToString("yyyy/MM/dd") + "'," + this.IdDelivery + ") "); 
        }

        public bool Modificar()
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Update Entregas set Fecha ='" + this.Fecha.ToString("yyyy/MM/dd") + "', IdDelivery = " + this.IdDelivery + " where IdEntrega = " + this.IdEntrega);
        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From Entregas  where IdEntrega = " + id);
        }

        public static DataTable Listar(string campo, string filtro)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.BuscarDb("Select " + campo + " from Entregas where " + filtro);
        }

        public bool Buscar()
        {
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();
            bool msj = false;

            dt = conectar.BuscarDb("select * from Entregas where IdEntrega = " + this.IdEntrega);
            if (dt.Rows.Count > 0)
            {
                msj = true;
                this.IdEntrega = (int)dt.Rows[0]["IdEntrega"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdDelivery = (int)dt.Rows[0]["IdDelivery"];

            }
            return msj;
        }

    }
}
