using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class EntregasDetalle
    {
        public int IdEntregaDetalle { get; set; }
        public int IdEntrega{ get; set; }
        public int IdPedido { get; set; }
        public Boolean Estado { get; set; }

       public EntregasDetalle()
        {
            IdEntregaDetalle = 0;
            IdEntrega = 0;
            IdPedido = 0;
            Estado = false;
        }

       public void Insertar()
       {
           ConexionDb conectar = new ConexionDb();
           conectar.EjecutarDB("Insert Into EntregasDetalle (IdEntrega, IdPedido,Estado) values ( " + this.IdEntrega + "," + this.IdPedido+ ",'"+this.Estado+"') ");
       }

       public bool Modificar()
       {
           ConexionDb conectar = new ConexionDb();
           return conectar.EjecutarDB("Update EntregasDetalle set IdEntrega =" + this.IdEntrega + ",  IdPedido = " + this.IdPedido + ", Estado = '"+this.Estado+"' where IdEntregaDetalle =  " + this.IdEntregaDetalle);
       }

       public static bool Eliminar(int id)
       {
           ConexionDb conectar = new ConexionDb();
           return conectar.EjecutarDB("Delete From EntregasDetalle  where IdEntrega = " + id);
       }

       public static DataTable Listar(string campo, string filtro)
       {
           ConexionDb conectar = new ConexionDb();
           return conectar.BuscarDb("Select " + campo + " from EntregasDetalle where " + filtro);
       }

       public bool Buscar()
       {
           ConexionDb conectar = new ConexionDb();
           DataTable dt = new DataTable();
           bool msj = false;

           dt = conectar.BuscarDb("select * from EntregasDetalle where IdEntregaDetalle = " + this.IdEntregaDetalle);
           if (dt.Rows.Count > 0)
           {
               msj = true;
               this.IdEntregaDetalle = (int)dt.Rows[0]["IdEntregaDetalle"];
               this.IdEntrega = (int)dt.Rows[0]["IdEntrega"];
               this.IdPedido = (int)dt.Rows[0]["IdPedido"];
               this.Estado = (Boolean)dt.Rows[0]["Estado"];

           }
           return msj;
       }
       
    }
}
