using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    public class Cliente : Persona
    {
        int turno { get; set; }
        public List<Servicio> listServ;
        public Cliente(string nom, string apP, string apM, string cel, string correo, string contra)
        {
            this.Nombre = nom;
            this.ApPaterno = apP;
            this.ApMaterno = apM;
            this.Celular = cel;
            this.Correo = correo;
            this.Constrasenia = contra;

        }

        public List<Servicio> getListServ() 
        {
            return listServ;
        }
        public string getLastName() 
        {
            return ApPaterno +" "+ ApMaterno;
        } 
        public string getName() 
        {
            return Nombre;
        }

        public override void menu()
        {
            Console.WriteLine(this.Nombre +" "+this.ApPaterno);
            char resp = ' ';

            while (resp!='s' && resp!='n') 
            {
                Console.WriteLine("¿Quieres tomar turno ya? s/n");
                resp = Console.ReadLine().ToLower()[0];

                if (resp == 's')
                {
                    Console.Write("Su turno es: ");

                }
                else if (resp == 'n')
                {
                    Console.WriteLine("Tenga un buen dia!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion no valida..");

                }
            }

        }
        public string getCorreo() {

            return this.Correo;
        }
        public string getCont()
        {

            return this.Constrasenia;
        }
    }
}
