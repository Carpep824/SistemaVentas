using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CNCategoria
    {

        public static DataTable Listar()
        {
            CDCategoria datos = new CDCategoria();
            return datos.Listar();
        }

        //Metodo Guardar que llama el metodo Guardar de la clase CDCategoria de la CapaDatos
        public static string Guardar(string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Descripcion = descripcion;
            return Datos.Guardar(Datos);
        }

        //Metodo editar que llama al metodo Editar de la clase CDCategoria de la CapaDatos
        public static string Editar(int idcategoria, string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            Datos.Descripcion = descripcion;
            return Datos.Editar(Datos);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase CDCategoria de la CapaDatos
        public static string Eliminar(int idcategoria)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            return Datos.Eliminar(Datos);
        }

        //Metodo BuscarNombre que llama al metodo Buscar de la clase CDCategoria de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }
    }
}
