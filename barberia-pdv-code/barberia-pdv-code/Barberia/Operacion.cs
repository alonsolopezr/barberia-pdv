using System;
using System.Collections.Generic;

namespace barberia_pdv_code.Barberia
{
    public class Operacion : Persona
    {
        //atributos
        List<Cliente> listaDeClientes = new List<Cliente>();
        List<Barbero> listaDeBarberos = new List<Barbero>();
        List<Servicio> listaDeServicios = new List<Servicio>();
        //las BD
        List<Cliente> bdClientes = new List<Cliente>()
        {
            new Cliente("Alonso", "Lopez", "Romo", "6622331122", "alonso@gmail.com", "123123123"),
            new Cliente("Alfonso", "Lopez", "Romo", "6622556644", "alfonso@gmail.com", "123123123"),
            new Cliente("Antonio", "Lopez", "Romo", "6699887788", "antonio@gmail.com", "123123123")
        };
        List<Barbero> bdBarberos = new List<Barbero>()
        {
            new Barbero("Luis", "Lopez", "Romo", "6622331122", "luis@gmail.com", "123123123"),
            new Barbero("Lewis", "Lopez", "Romo", "6622556644", "lewis@gmail.com", "123123123"),
            new Barbero("Levis", "Lopez", "Romo", "6699887788", "levis@gmail.com", "123123123")
        };


        public Operacion()
        {
            //inicializando servicios
            this.listaDeServicios.Add(new Servicio("Arreglo de Barba", 120.50));
            this.listaDeServicios.Add(new Servicio("Recorte de Barba sin delineado", 145.23));
            this.listaDeServicios.Add(new Servicio("Rasurado completo", 100));
            this.listaDeServicios.Add(new Servicio("Tratamiento de crecimiento de barba", 233.56));
            this.listaDeServicios.Add(new Servicio("Spa de barba", 89.99));
            this.listaDeServicios.Add(new Servicio("arreglo de bigotes", 44.10));
            this.listaDeServicios.Add(new Servicio("Recorte de bigotes sin delineado", 40.10));
            this.listaDeServicios.Add(new Servicio("Recorte de ceja", 23.30));
            this.listaDeServicios.Add(new Servicio("Planchado de ceja", 33.25));
        }

        string[,] arregloClientes = new string[,] 
        { 
            {"Alonso", "Lopez", "Romo", "6622331122", "alonso@gmail.com", "123123123"}, 
            {"Alfonso", "Lopez", "Romo", "6622556644", "alfonso@gmail.com", "123123123"},
            { "Antonio", "Lopez", "Romo", "6699887788", "antonio@gmail.com", "123123123"}
        };
        

        //login
        public bool login(string correo, string pwd)
        {
            int numUsuario = 0;
            
            
            Console.WriteLine("Bienvenido a la barbería, ¿ya se encuentra registrado? s/n");
            string respuesta = Console.ReadLine();
            if (respuesta == ("s"))
            {
                Console.WriteLine("Es usted un Barbero o un Cliente? b/c");
                string respuestaTipoDeUsuario = Console.ReadLine();
                //Si la respuesta es Barbero(b) se hace un conteo
                if (respuestaTipoDeUsuario == ("b"))
                {
                    //Conteo para cada Barbero
                    for(int i = 1; i < 999; i++)
                    {
                        Console.WriteLine("Barbero #"+i);
                        Console.WriteLine("Eliga su usuario Barbero");
                        foreach (var Barbero in bdBarberos)
                        {
                            Console.WriteLine(Barbero.ToString());
                        }
                        //Seleccionar usuario
                        Console.WriteLine("\n>>>Si no encuentra su usuario, pulse \"n\"<<<");
                        string respuestaUsuario = Console.ReadLine();
                        //Si no encuentra su usuario o ingresa "n" la maquina lo mandará con el administrador
                        if (respuestaUsuario == ("n"))
                        {
                            i = i - 1;
                            Console.WriteLine("\nVaya con el administrador\n");
                        }
                        //Ingresar contraseña
                        Console.WriteLine("Ingrese la contraseña de su usuario :");
                        Console.ReadLine();
                        Console.WriteLine("Bienvenido Barbero, tome su lugar.");
                    }
                }

                //Si la respuesta es Cliente(c) se hace un conteo
                if (respuestaTipoDeUsuario == ("c"))
                {
                    //Conteo para cada Cliente
                    for (int i = 1; i < 999; i++)
                    {
                        Console.WriteLine("\nCliente #" + i);
                        Console.WriteLine("Eliga su usuario Cliente");

                        foreach (var cliente in bdClientes)
                        {
                            Console.WriteLine(bdClientes.IndexOf(cliente)+" "+cliente);
                        }
                        //Seleccionar usuario
                        Console.WriteLine("\n>>>Si no encuentra su usuario, pulse \"n\"<<<");
                        string respuestaUsuario = Console.ReadLine();
                        //Si no encuentra su usuario o ingresa "n" la maquina lo mandará con el administrador
                        if (respuestaUsuario == ("n"))
                        {
                            i = i - 1;
                            Console.WriteLine("\nVaya con el administrador para registrarse\n");
                        }
                        //Ingresar contraseña
                        Console.WriteLine("Ingrese la contraseña de su usuario:");
                        Console.ReadLine();
                        Console.WriteLine("Bienvenido <Nombre> <Apellido>, elija su servicio:");

                       
                       foreach (var servicio in listaDeServicios)
                       {
                            Console.WriteLine(listaDeServicios.IndexOf(servicio)+" "+servicio);
                       }
                        Console.ReadLine();


                    }
                }
            }

            if (respuesta == ("n"))
            {
               Console.WriteLine("Usuario no resgitrado.. ve con el admin...");
               
            
            } 
            bool res = false;
            //buscamos en cliente
            //int idxCliente = bdClientes.IndexOf(new Cliente("", "", "", "", correo, pwd));
            //buscamos en bdBarbero
            //int idxBarbero = bdBarberos.IndexOf(new Barbero("", "", "", "", correo, pwd));
            //if (idxCliente < 0 && idxBarbero < 0);
            //{
            //    Console.WriteLine("Usuario no registrado.. ve con al admin...");
            //    
            //    res = false;
            //}
            //else if (idxBarbero >= 0)
            //{
            //    Console.WriteLine("Bienvenido barbero...");
            //    listaDeBarberos.Add(bdBarberos[idxBarbero]);
            //    Console.WriteLine(bdBarberos[idxBarbero]);
            //    res = true;
            //}
            //else if (idxCliente >= 0)
            //{
            //    Console.WriteLine("Bienvenido cliente...");
            //    listaDeClientes.Add(bdClientes[idxCliente]);
            //    Console.WriteLine(listaDeClientes[listaDeClientes.Count - 1]);
            //    res = true;
            //}


            return res;
        }

    }
}
