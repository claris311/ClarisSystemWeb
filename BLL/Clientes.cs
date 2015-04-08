using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public Clientes()
        {
            IdCliente = 0;
            Nombres = "";
            Telefono = "";
            Celular = "";
            Cedula = "";
            Email = "";
            Direccion = "";
        }

        public void Insertar()
        {
            ConexionDb conectar = new ConexionDb();
            conectar.EjecutarDB("Insert Into Clientes (Nombres,Telefono,Celular,Cedula,Email,Direccion) values ( '" + this.Nombres + "','" + this.Telefono + "', '" + this.Celular + "', '" + this.Cedula + "', '" + this.Email + "', '" + this.Direccion + "') ");
        }

        public bool Modificar()
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Update Clientes set Nombres = '" + this.Nombres + "',  Telefono = '" + this.Telefono + "',  Cedula = '" + this.Cedula + "',  Email = '" + this.Email + "',  Direccion = '" + this.Direccion + "' where IdCliente =  " + this.IdCliente);
        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From Clientes  where IdCliente =  " + id);
        }

        public static DataTable Listar(string campo, string filtro)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.BuscarDb("Select " + campo + " from Clientes where " + filtro);
        }

        public bool Buscar()
        {
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();
            bool msj = false;

            dt = conectar.BuscarDb("select * from Clientes where IdCliente =  " + this.IdCliente);
            if (dt.Rows.Count > 0)
            {
                msj = true;
                this.IdCliente = (int)dt.Rows[0]["IdCliente"];
                this.Nombres = (string)dt.Rows[0]["Nombres"];
                this.Telefono = (string)dt.Rows[0]["Telefono"];
                this.Celular = (string)dt.Rows[0]["Celular"];
                this.Cedula = (string)dt.Rows[0]["Cedula"];
                this.Email = (string)dt.Rows[0]["Email"];
                this.Direccion = (string)dt.Rows[0]["Direccion"];


            }
            return msj;
        }


    }
}
