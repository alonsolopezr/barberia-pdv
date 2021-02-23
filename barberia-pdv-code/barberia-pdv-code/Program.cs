using barberia_pdv_code.Barberia;
using System;

namespace barberia_pdv_code
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa de barbería");

            Cliente cliente = new Cliente();
            Operacion operacion = new Operacion();
            Persona persona = new Persona();
            Barbero barbero = new Barbero();
            //login
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Bienvenido a la barbería");
                operacion.login("", "");
            }
            
            //barbero

            //Cliente
            //cliente.menu();

            //servicio
            
            

            //COMNETARIO PRUEBA


        }
    }
}
