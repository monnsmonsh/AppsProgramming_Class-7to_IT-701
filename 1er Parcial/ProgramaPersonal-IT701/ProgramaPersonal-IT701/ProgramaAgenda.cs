using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class ProgramaAgenda
    {
        static void Main(string[] args)
        {
            //Creamos un arreglo del objeto de la clase persona.
            Persona[] listaPersonas = new Persona[50];

            //Agregamos nuevos objetos al arreglo
            listaPersonas[0] = new Persona
            {
                Clave = 1,
                Nombre = "Pedro López",
                Direccion = "5 de Mayo",
                Telefono = "477 126 9136",
                Email = "pedro126@gmail.com",
                FechaNacimineto = DateTime.Parse("22/09/2000"),
            };
            listaPersonas[1] = new Persona
            {
                Clave = 2,
                Nombre = "Ana Medina",
                Direccion = "San Pedro 506",
                Telefono = "477 656 5436",
                Email = "ana656@gmail.com",
                FechaNacimineto = DateTime.Parse("25/10/1995"),
            };






            //Captura de datos del objeto
            System.Console.WriteLine(" Programa Agenda");
            System.Console.WriteLine("_________________");
            System.Console.WriteLine("1.-Capturar Persona");
            System.Console.WriteLine("2.-Mostrar Listado");
            System.Console.WriteLine("3.-Salir");
            String eleccion = System.Console.ReadLine();
            int valor = Convert.ToInt32(eleccion); //valor del objeto
            System.Console.WriteLine("--------------------------------------");


            switch (valor)
            {
                case 1://Eleccion Capturar Personas
                    //Capturando los datos del arreglo
                    for (int i = 0; i < listaPersonas.Length; i++)
                    {
                        Console.Write(" Clave:  ");
                        listaPersonas[i].Clave = Int32.Parse(Console.ReadLine());
                        Console.Write(" Nombre:  ");
                        listaPersonas[i].Nombre = Console.ReadLine();
                        Console.Write(" Direccion:  ");
                        listaPersonas[i].Direccion = Console.ReadLine();
                        Console.Write(" Telefono:  ");
                        listaPersonas[i].Telefono = Console.ReadLine();
                        Console.Write(" e-mail:  ");
                        listaPersonas[i].Email = Console.ReadLine();
                        Console.Write(" Fecha de Nacimiento:  ");
                        listaPersonas[i].FechaNacimineto = DateTime.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    //Mostramos la lista de personas
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(" Lista de personas Registradas");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();

                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(" Clave: " + listaPersonas[i].Clave);
                        Console.WriteLine(" Direccion: " + listaPersonas[i].Direccion);
                        Console.WriteLine(" Telefono: " + listaPersonas[i].Telefono);
                        Console.WriteLine(" E-mail: " + listaPersonas[i].Email);
                        Console.WriteLine(" Fecha de Nacimiento: " + listaPersonas[i].FechaNacimineto/*.ToShortDateString*/);
                        Console.WriteLine();
                    }
                    break;
            }
            int cont = 0;
            do
            {
                cont++;
                if (cont < 50)
                {
                   
                    cont++;
                }

            } while (valor > 3);



            Console.Read();

        }
    }
}
