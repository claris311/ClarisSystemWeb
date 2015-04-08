using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Usuarios
    {
        public int IdUsuario { set; get; }
        public string Nombre { set; get; }
        public string Clave { set; get; }
        public Boolean esActivo { set; get; }
        public int Nivel { get; set; }
        public int IdCliente { get; set; }

        public Usuarios()
        {
            this.IdUsuario = 0;
            this.Nombre = "";
            this.Clave = "";
            esActivo = true;
            this.Nivel = 0;
            IdCliente = 0;
            
        }

        public bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            return  conexion.EjecutarDB("Insert into Usuarios(Nombre,Clave,esActivo, Nivel, IdCliente) values('" + Nombre + "','" + Clave + "','" + esActivo + "', "+Nivel+", "+IdCliente+")");
            
        }

        public bool Modificar()
        {
            ConexionDb conexion = new ConexionDb();
          
           return  conexion.EjecutarDB("Update Usuarios set Nombre = '" + Nombre + "', Clave = '" + Clave + "', esActivo = '" + esActivo + "', Nivel = "+this.Nivel+", IdCliente = "+this.IdCliente+" Where IdUsuario = " + IdUsuario);
           

        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From Usuarios  where IdUsuario =  " + id);
        }

        public bool Buscar(int buscarid)
        {
            bool Retorno = false;
            DataTable Datos = new DataTable();
            ConexionDb conexion = new ConexionDb();

            Datos = conexion.BuscarDb("Select * from Usuarios where IdUsuario = " + buscarid);
            if (Datos.Rows.Count > 0)
            {
                Retorno = true;
                this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
                this.Nombre = (string)Datos.Rows[0]["Nombre"];
                this.Clave = (string)Datos.Rows[0]["Clave"];
                this.Nivel = (int)Datos.Rows[0]["Nivel"];
                this.esActivo = (bool)Datos.Rows[0]["esActivo"];
                this.IdCliente = (int)Datos.Rows[0]["IdCliente"];
            }

            return Retorno;
        }

       public static int BuscarIdClientebyUsuario(int idUsuario){
           
            int Retorno = 0;
            DataTable Datos = new DataTable();
            ConexionDb conexion = new ConexionDb();

            Datos = conexion.BuscarDb("Select Clientes.idCliente from Usuarios  Inner join Clientes on Usuarios.idCliente = Clientes.idCliente where Usuarios.IdUsuario = " + idUsuario );
            if (Datos.Rows.Count > 0)
            {
                Retorno =  (int)Datos.Rows[0]["idCliente"];
            }

            return Retorno;
       }

        public DataTable Listar(string Campos, string Filtro)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable datos = new DataTable();
            datos = conexion.BuscarDb("Select " + Campos + " from Usuarios Where " + Filtro);
            return datos;
        }

        public static DataTable ListarTodo(string Campos, string Filtro)
        {
            ConexionDb conexion = new ConexionDb();
            
          return   conexion.BuscarDb("Select " + Campos + " from Usuarios Where " + Filtro);
            
        }

        public bool BuscarId(string Nombre)
        {
            ConexionDb conexion = new ConexionDb();
            Boolean paso = false;
            DataTable Datos = new DataTable();
            Datos = conexion.BuscarDb("Select * from Usuarios where Nombre = '" + Nombre + "'");

            if (Datos.Rows.Count > 0)
            {
                this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
                paso = true;
            }

            return paso;
        }

        public Boolean Autenticar(string pUserName, string pPassword)
        {
            ConexionDb conexion = new ConexionDb();
            Boolean retorno = false;
            object idUsuario = conexion.ObtenerValorDb("SELECT IdUsuario from Usuarios Where Nombre = '" + pUserName + "' And Clave = '" + pPassword + "'");

            if (idUsuario != null)
            {
                retorno = this.Buscar((int)idUsuario);
            }

            return retorno;
        }

        public bool Eliminar(string p)
        {
            throw new NotImplementedException();
        }
    }
}
