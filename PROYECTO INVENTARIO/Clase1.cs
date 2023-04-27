using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INVENTARIO
{
    public class Clase1
    {

        protected string producto;

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        protected string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected DateTime? fecha;

        public DateTime? Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Clase1()
        {
            producto = string.Empty;
            codigo= string.Empty;
            fecha = null;

        }
        public Clase1(string producto, string codigo, DateTime? fecha)
        {
            this.producto = producto;
            this.codigo = codigo;
            this.fecha = fecha;
        }

        public Clase1(string producto, string codigo)
        {
            this.producto = producto;
            this.codigo = codigo;
        }
        //public Clase1(string producto, string codigo, DateTime? fecha,int cantidad) : this (producto,codigo,fecha)
        //{

        //}

    }
}
