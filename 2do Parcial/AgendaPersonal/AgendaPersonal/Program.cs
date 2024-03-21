using System;

namespace AgendaPersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int elec = 0;
            Agenda objAgenda = new Agenda();
            Persona[] arrPersona = new Persona[100];

            do
            {
                //Menu del Programa Agenda
                Console.WriteLine(" ____________________________________");
                Console.WriteLine("        AGENDA PERSONAL");
                Console.WriteLine("  ----------------------------------");
                Console.WriteLine(" Numero de Personas: " + objAgenda.Cont);
                Console.WriteLine("  (1) Agregar Persona");
                Console.WriteLine("  (2) Mostrar Agenda");
               /* Console.WriteLine("  (3) Buscar");*/
                Console.WriteLine("  (4) Salir");
                Console.Write("  R=");
                elec = Int16.Parse(Console.ReadLine());
                Console.WriteLine(" ____________________________________");
                Console.WriteLine();
                switch (elec)
                {
                    case 1://Eleccion Agregar nueva persona
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine("            NUEVA PERSONA");
                        Console.WriteLine("  ----------------------------------");
                        objAgenda.CapturarPersona();
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine();
                        break;
                    case 2://Eleccion Mostrar Agenda
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine("                AGENDA");
                        Console.WriteLine("  ----------------------------------");
                        objAgenda.MostrarAgenda();
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine();
                        break;
                   /* case 3://Eleccion Buscar
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine("                BUSCAR");
                        Console.WriteLine("  ----------------------------------");
                        objAgenda.BuscarContacto();
                        break;*/
                    case 4://Eleccion Cerrar programa
                        Console.WriteLine(" Fin del programa...");
                        elec = 0;
                        break;
                    default://Eleccion no valida
                        Console.WriteLine(" Error Selecciona una opcion del menu...");
                        Console.WriteLine("_______________________________________");
                        break;
                }
            } while (elec != 0);
        }
    }
}
