using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    public abstract class  Persona
    {
        //attributos
        protected string Nombre { get; set; }
        protected string ApPaterno { get; set; }
        protected string ApMaterno { get; set; }
        protected string Celular { get; set; }
        protected string Correo { get; set; }
        protected string Constrasenia { get; set; }
        //rescribir metdod toString
        public override string ToString()
        {
            return $"{this.Nombre} {this.ApPaterno} {this.ApMaterno} {this.Celular} {this.Correo}";
        }
        public abstract void menu();


        public Persona()
        {
        }
    }
}
