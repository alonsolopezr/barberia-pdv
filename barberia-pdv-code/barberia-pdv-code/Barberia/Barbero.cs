using System;
namespace barberia_pdv_code.Barberia
{
    public class Barbero : Persona
    {
        public Barbero(string nom, string apP, string apM, string cel, string correo, string contra)
        {
            this.Nombre = nom;
            this.ApPaterno = apP;
            this.ApMaterno = apM;
            this.Celular = cel;
            this.Correo = correo;
            this.Constrasenia = contra;

        }
        public override void menu()
        {
            Console.WriteLine("Bienvenido Barbero: " + this);
            Console.WriteLine("¿Quieres empezar a trabajar? s/n");

        }
    }
}
