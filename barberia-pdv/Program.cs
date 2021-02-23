using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using barberia_pdv.barberia;

namespace barberia_pdv
{
    class Program
    {
        static void Main(string[] args)
        {

            Operacion op = new Operacion();
            Cliente cliente = new Cliente("", "", "", "", "", "");
            Barbero barbero = new Barbero("", "", "", "", "", ""); ;
            Servicio serv;
            int turno = 0;
            char ekis = ' ';



            Console.WriteLine("Bienvenido...");
            while (ekis != 'x')
            {
                Console.WriteLine("\n");
                Console.WriteLine("Introdusca sus credenciales (Correo y Contraseña)");
                string correolog = Console.ReadLine();
                Console.WriteLine("Introdusca la contraseña:");

                string pwslog = null;
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Login...");
                        break;
                    }
                    else
                    {
                        pwslog += key.KeyChar;
                    }

                }
                //Console.WriteLine(pwslog);
                if (op.login(correolog, pwslog))
                {
                    Console.WriteLine(op.BarOrClient().ToString());

                    if (op.listaDeClientes.Count!=0) {
                        while (op.listaDeClientes.Last().GetType() == cliente.GetType() && op.listaDeClientes.Last() != cliente)
                        {
                            cliente = op.listaDeClientes.Last();

                            cliente.menu();
                            cliente=op.ListarServicios(cliente);
                            if (op.tomarTurno(cliente))
                            {
                                Console.WriteLine("Turno asignado favor de pasar a tomar asiento");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error en la asignacion de turno");
                            }
                        }
                    }
                    if (op.listaDeBarberos.Count != 0)
                    {
                        while (op.listaDeBarberos.Last().GetType() == barbero.GetType() && op.listaDeBarberos.Last() != barbero)
                        {
                            barbero = op.listaDeBarberos.Last();
                            barbero.menu();
                            cliente = op.listaDeClientes.First();
                            Console.WriteLine("Tu primer cliente es: " + cliente.getName() + " " + cliente.getLastName());
                            Console.WriteLine("Los servicios solicitados por " + cliente.getName() + " fueron los siguientes: ");

                            cliente.getListServ().ForEach(x => Console.WriteLine(x.servicio + "\t" + x.precio));

                        }
                    }
                }
                else
                {

                    Console.WriteLine("Intentelo denuevo.... o pulse 'x' para salir");
                    ekis = Console.ReadLine().ToLower()[0];
                    if (ekis == 'x')
                    {
                        break;
                    }
                }

            }


        }
    }
}
