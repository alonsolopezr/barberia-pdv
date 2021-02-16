using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    public class Cliente : Persona
    {
        public Cliente(string nom, string apP, string apM, string cel, string correo, string contra)
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
            Console.WriteLine("Bienvenido Cliente: " + this);
            Console.WriteLine("¿Quieres tomar turno ya? s/n");

        }
    }
}
