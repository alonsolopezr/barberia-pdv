using System;
namespace barberia_pdv_code.Barberia
{
    public class Persona
    {
        //attributos
        private string nombre;
        protected string Nombre 
        { 
          get => this.nombre; 
          set => this.nombre=value;
        }
        protected string ApPaterno 
        { 
          get; 
          set; 
        }
        protected string ApMaterno 
        { 
          get; 
          set; 
        }
        protected string Celular 
        { 
          get; 
          set; 
        }
        protected string Correo 
        { 
          get; 
          set; 
        }
        protected string Constrasenia 
        { 
          get; 
          set; 
        }
        //rescribir metdod toString
        public override string ToString()
        {
            return $"{this.Nombre} {this.ApPaterno} {this.ApMaterno} {this.Celular} {this.Correo}";
        }

        public Persona()
        {
        }
    }
}
