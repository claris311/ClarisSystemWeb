using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class Productos
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Existencia  { get; set; }
        public string Foto { get; set; }

        public Productos()
        {
            IdProducto = 0;
            Descripcion = "";
            Precio = 0;
            Existencia = 0;
            Foto = "";
        }

        public void Insertar()
        {
            ConexionDb conectar = new ConexionDb();
            conectar.EjecutarDB("Insert Into Productos (Descripcion,Precio,Existencia,Foto) values ('" + this.Descripcion+ "', " + this.Precio + "," + this.Existencia + ", '" + this.Foto+ "') ");
        }

        public bool Modificar()
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Update Productos set Descripcion = '" + this.Descripcion + "' , Precio = " + this.Precio + ",  Existencia = " + this.Existencia + ", Foto = '" + this.Foto + "' where IdProducto =  " + this.IdProducto);
        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From Productos  where IdProducto = " + id);
        }

        public static DataTable Listar(string campo, string filtro)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.BuscarDb("Select " + campo + " from Productos where " + filtro);
        }

        public bool Buscar()
        {
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();
            bool msj = false;

            dt = conectar.BuscarDb("select * from Productos where IdProducto = " + this.IdProducto);
            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdProducto = (int)dt.Rows[0]["IdProducto"];
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
                this.Precio = (double)dt.Rows[0]["Precio"];
                this.Existencia = (double)dt.Rows[0]["Existencia"];
                this.Foto = (string)dt.Rows[0]["Foto"];

            }
            return msj;
        }



    }
}
