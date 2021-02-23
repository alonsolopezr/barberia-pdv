using System;
namespace barberia_pdv_code.Barberia
{
    public class Barbero : Persona
    {
        public Barbero()
        {
        }

        public Barbero(string nom, string apP, string apM, string cel, string correo, string contra)
        {
            this.Nombre = nom;
            this.ApPaterno = apP;
            this.ApMaterno = apM;
            this.Celular = cel;
            this.Correo = correo;
            this.Constrasenia = contra;

        }
        public void menu()
        {
            Console.WriteLine("Bienvenido Barbero: " + this.Nombre + this.ApPaterno);
            Console.WriteLine("¿Empezar a trabajar ya? s/n");
            string userResponse = Console.ReadLine();
            if (userResponse == ("s"))
            {
                Console.WriteLine("Adelante, tome su puesto.");
            }
            if (userResponse == ("n"))
            {
                Console.WriteLine("Gracias por la visita");
            }
        }
    }
}
