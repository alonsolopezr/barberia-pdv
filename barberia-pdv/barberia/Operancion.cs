using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    class Operancion
    {
        List<Cliente> listaDeClientes= new List<Cliente>();
        List<Barbero> listaDeBarberos= new List<Barbero>(); 
        List<Servicio> listaDeServicios = new List<Servicio>();
        List<Cliente> bdClientes = new List<Cliente>() {

            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123")

        };
        List<Cliente> bdBarberos = new List<Cliente>() {

            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123"),
            new Cliente("Alonso","Lopez","Romo", "6622331122", "alonso@gmail.com","123123123")


        };
        int[] turnos = new int[20];


        public Operancion() {

            //inicializando servicios
            this.listaDeServicios.Add(new Servicio("Arreglo De Barba" ,120.50));
            this.listaDeServicios.Add(new Servicio("Recorte de barba sin delineado", 120.50));
            this.listaDeServicios.Add(new Servicio("Rasurado completo", 120.50));
            this.listaDeServicios.Add(new Servicio("Tratamiento de crecimiento de barba", 120.50));
            this.listaDeServicios.Add(new Servicio("Spa de barba", 120.50));
            this.listaDeServicios.Add(new Servicio("Arreglo de bigote", 120.50));
            this.listaDeServicios.Add(new Servicio("recorde de bigote sin delineado", 120.50));
            this.listaDeServicios.Add(new Servicio("Recorte de ceja", 120.50));
            this.listaDeServicios.Add(new Servicio("Planchado de ceja", 120.50));


        }


        public bool login(string correo, string pws)
        {




            return true;
        }

        public bool asignarBarberoACliente(Cliente cliente, Barbero barbero)
        {




            return true;

        }

        public bool tomarTurno(Cliente cliente)
        {


            return true;
        }

    }
}
