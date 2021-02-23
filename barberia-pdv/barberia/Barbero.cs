using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    public class Barbero: Persona
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
            Console.WriteLine( this.Nombre+" "+this.ApPaterno);
            Console.WriteLine("¿Quieres empezar tu turno ya? s/n");
            string resp;
            do
            {
                resp = Console.ReadLine();
                resp = resp.ToLower();
                if (resp[0] != 's' && resp[0] != 'n')
                {
                    Console.WriteLine("Respuesta no valida porfavor ingrese 's' o 'n'");
                }
                else 
                {
                    if (resp[0]=='s')
                    {
                        Console.WriteLine("Turno de "+this.Nombre+" iniciado");
                    }
                
                
                }
            } while (resp.ToLower()[0]!='s');
        }

        public string getCorreo()
        {
            return this.Correo;
        }
        public string getCont()
        {

            return this.Constrasenia;
        }
    }
}
