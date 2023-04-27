using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INVENTARIO
{
    internal class Clase3:Clase2
    {
        protected double total;

        public double Total
        {
            get
            {
                double total;
                total = cantidad * preciodeventa;
                return total;
            }
        }
    }
}
