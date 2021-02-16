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
    }
}
