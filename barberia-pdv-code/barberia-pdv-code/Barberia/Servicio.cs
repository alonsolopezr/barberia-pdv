using System;
namespace barberia_pdv_code.Barberia
{
    public class Servicio
    {
        public string servicio { get; set; }
        public double Precio { get; set; }


        public Servicio(string nom, double precio)
        {
            this.servicio = nom;
            this.Precio = precio;
        }
    }
}
