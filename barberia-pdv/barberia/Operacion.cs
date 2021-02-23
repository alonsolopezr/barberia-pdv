using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberia_pdv.barberia
{
    public class Operacion
    {
        public List<Cliente> listaDeClientes = new List<Cliente>();
        public List<Barbero> listaDeBarberos = new List<Barbero>();
        public List<Servicio> listaDeServicios = new List<Servicio>();

        private List<Cliente> bdClientes = new List<Cliente>()
        {
            new Cliente("Alonso1","Lopez1","Romo1", "6622331122", "alonso1@gmail.com","12345"),
            new Cliente("Alonso2","Lopez2","Romo2", "6622331122", "alonso2@gmail.com","12345"),
            new Cliente("Alonso3","Lopez3","Romo3", "6622331122", "alonso3@gmail.com","12345"),
            new Cliente("Alonso4","Lopez4","Romo4", "6622331122", "alonso4@gmail.com","12345"),
            new Cliente("Alonso5","Lopez5","Romo5", "6622331122", "alonso5@gmail.com","12345")
        };
        private List<Barbero> bdBarberos = new List<Barbero>()
        {
            new Barbero("bar1","bero1","uno", "6622331122", "barshop@gmail.com","12345"),
            new Barbero("bar2","bero2","dos", "6622331122", "barber29@gmail.com","12345"),
            new Barbero("bar3","bero3","tres", "6622331122", "bar_bear@gmail.com","12345"),
            new Barbero("bar4","bero4","cuatro", "6622331122", "TrimIt@gmail.com","12345")
        };
        public int[] turnos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public Type tipo { get; set; }
        private int idxC;
        private int idxB;


        public Operacion()
        {
            //inicializando servicios
            this.listaDeServicios.Add(new Servicio("Arreglo De Barba", 120.50));
            this.listaDeServicios.Add(new Servicio("Recorte de barba sin delineado", 145.23));
            this.listaDeServicios.Add(new Servicio("Rasurado completo", 100.00));
            this.listaDeServicios.Add(new Servicio("Tratamiento de crecimiento de barba", 233.56));
            this.listaDeServicios.Add(new Servicio("Spa de barba", 89.99));
            this.listaDeServicios.Add(new Servicio("Arreglo de bigote", 44.10));
            this.listaDeServicios.Add(new Servicio("recorde de bigote sin delineado", 40.10));
            this.listaDeServicios.Add(new Servicio("Recorte de ceja", 23.30));
            this.listaDeServicios.Add(new Servicio("Planchado de ceja", 33.25));
        }


        public bool login(string correo, string pws)
        {
            //int idxC = bdClientes.IndexOf(new Cliente("", "","" ,"" , correo, pws));
            //int idxB = bdBarberos.IndexOf(new Barbero("", "", "", "", correo, pws));
            // lambda expresion (args => {code to run    return var};) = var 

            this.idxC = bdClientes.FindIndex(x => x.getCorreo() == correo);

            this.idxB = bdBarberos.FindIndex(x => x.getCorreo() == correo);


            if (this.idxC == -1 && this.idxB == -1)
            {
                Console.WriteLine("ERROR");
                return false;
            }
            else
            {
                if (this.idxB != -1 && bdBarberos[idxB].getCont() == pws)
                {
                    Console.WriteLine("Bienvenido Barbero...");
                    listaDeBarberos.Add(bdBarberos[this.idxB]);
                }
                else if (idxB != -1 && bdBarberos[idxB].getCont() != pws)
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
                if (this.idxC != -1 && bdClientes[idxC].getCont() == pws)
                {
                    Console.WriteLine("Bienvenido Cliente...");
                    listaDeClientes.Add(bdClientes[this.idxC]);
                }
                else if (idxC != -1 && bdClientes[idxB].getCont() != pws)
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
                return true;
            }
        }
        public Cliente ListarServicios(Cliente c)
        {
            int resp;
            Console.WriteLine("Que servicio desea solicitar (ingrese uno a la ves)");
            for (int i = 0; i < listaDeServicios.Count; i++)
            {
                Console.WriteLine(i+". "+listaDeServicios[i].servicio+"\t\t"+listaDeServicios[i].precio);
            }
            Console.WriteLine(listaDeServicios.Count + ". Terminar de agregar servicios" );
            resp = int.Parse(Console.ReadLine()[0].ToString());

            while (resp != (listaDeServicios.Count ))
            {
                c.listServ.Add(listaDeServicios[resp]);
                Console.WriteLine("Se agrego el servicio "+listaDeServicios[resp].servicio);
                resp = int.Parse(Console.ReadLine()[0].ToString());
            }
            if (c.listServ.Count == 0)
            {
                Console.WriteLine("Seguro que no desea solicitar algun servicio?");
            }
            return c;
        }
        public Type BarOrClient()
        {
            if (this.tipo == null)
            {
                if (this.idxB == -1)
                {
                    this.tipo = listaDeClientes.Last().GetType();
                }
                if (this.idxC == -1)
                {
                    this.tipo = listaDeBarberos.Last().GetType();
                }
            }
            return this.tipo;
        }

        public bool asignarBarberoACliente(Cliente cliente, Barbero barbero)
        {
            return true;
        }

        public bool tomarTurno(Cliente cliente)
        {
            idxC = listaDeClientes.IndexOf(cliente);
            Console.WriteLine(turnos[idxC]);

            return true;
        }

    }
}
