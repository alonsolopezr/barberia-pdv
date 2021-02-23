using System;
namespace barberia_pdv_code.Barberia
{
    public class Cliente: Persona
    {
        public Cliente()
        {
        }

        public Cliente(string nom, string apP, string apM, string cel, string correo, string contra)
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
            Console.WriteLine("Bienvenido Cliente: "+this.Nombre+this.ApPaterno);
            Console.WriteLine("¿Quieres tomar turno ya? s/n");
            string userResponse = Console.ReadLine();
            if(userResponse == ("s"))
            {
                Console.WriteLine("Bienvenido a la barbería, por favor ingrese sus datos y servicio para tomar su turno:");
            }
            if (userResponse == ("n"))
            {
                Console.WriteLine("Gracias por la visita");
            }

        }
    }
}
