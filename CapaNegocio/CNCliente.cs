using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNCliente
    {

        public static DataTable Listar()
        {
            CDCliente datos = new CDCliente();
            return datos.Listar();
        }

        //Metodo Guardar que llama el metodo Guardar de la clase CDCliente de la CapaDatos
        public static string Guardar(string nombre, string apellidos, string dni, string rfc, string telefono, string estado)
        {
            CDCliente Datos = new CDCliente();
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Estado = estado;
            return Datos.Guardar(Datos);
        }

        //Metodo editar que llama al metodo Editar de la clase CDCliente de la CapaDatos
        public static string Editar(int idcliente, string nombre, string apellidos, string dni, string rfc, string telefono, string estado)
        {
            CDCliente Datos = new CDCliente();
            Datos.IdCliente = idcliente;
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Estado = estado;
            return Datos.Editar(Datos);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase CDCliente de la CapaDatos
        public static string Eliminar(int idcliente)
        {
            CDCliente Datos = new CDCliente();
            Datos.IdCliente = idcliente;
            return Datos.Eliminar(Datos);
        }

        //Metodo BuscarNombre que llama al metodo Buscar de la clase CDCliente de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        //Metodo Buscar Dni que llama al metodo BuscarDni de la clase CDCliente de la CapaDatos
        public static DataTable BuscarDni(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarDni(Datos);
        }

    }
}
