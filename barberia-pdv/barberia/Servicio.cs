using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    public class Servicio
    {
        public string servicio { get; set; }
        public double precio { get; set; }

        public Servicio(string servicio, double precio) {

            this.servicio = servicio;
            this.precio = precio;
        
        }
    }
}
