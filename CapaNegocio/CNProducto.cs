using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static DataTable Listar()
        {
            CDProducto datos = new CDProducto();
            return datos.Listar();
        }

        //Metodo Guardar que llama el metodo Guardar de la clase CDProducto de la CapaDatos
        public static string Guardar(string codigo, string nombre, string descripcion,
                DateTime fingreso, DateTime fvencimiento, double pcompra,
                double pventa, int stock, string estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = estado;
            Datos.Idcategoria = idcategoria;

            return Datos.Guardar(Datos);
        }

        //Metodo editar que llama al metodo Editar de la clase CDProducto de la CapaDatos
        public static string Editar(int idproducto, string codigo, string nombre, string descripcion,
                DateTime fingreso, DateTime fvencimiento, double pcompra,
                double pventa, int stock, string estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = estado;
            Datos.Idcategoria = idcategoria;

            return Datos.Editar(Datos);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase CDProducto de la CapaDatos
        public static string Eliminar(int idproducto)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            return Datos.Eliminar(Datos);
        }

        //Metodo BuscarNombre que llama al metodo Buscar de la clase CDProducto de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        //Metodo BuscarNombre que llama al metodo Buscar de la clase CDProducto de la CapaDatos
        public static DataTable BuscarCodigo(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textobuscar;
            return Datos.BuscarCodigo(Datos);
        }
    }
}
