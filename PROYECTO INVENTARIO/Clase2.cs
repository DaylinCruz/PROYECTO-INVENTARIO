using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INVENTARIO
{
    public class Clase2 :Clase1
    {


        public int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double preciodeventa ;

        public double Preciodeventa
        {
            get { return preciodeventa ; }
            set { preciodeventa  = value; }
        }
        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public Clase2() : base()
        {
            cantidad = 0;
            preciodeventa = double.NaN;
            costo = 0;
        }
        public Clase2(string producto,string codigo, DateTime? fecha, int cantidad, double preciodeventa, int costo) : base(producto,codigo,fecha)
        {
            this.cantidad = cantidad;
            this.preciodeventa = preciodeventa;
            this.costo = costo;
        }



    }
}
