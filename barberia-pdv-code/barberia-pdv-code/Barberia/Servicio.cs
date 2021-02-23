using System;
namespace barberia_pdv_code.Barberia
{
    public class Servicio
    {
        public string servicio { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return " Servicio: "+servicio + " Precio $"+Precio;
        }


        public Servicio(string serv, double precio)
        {
            this.servicio = serv;
            this.Precio = precio;
        }
    }
}
