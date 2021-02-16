using System;
namespace barberia_pdv_code.Barberia
{
    public class Persona
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
