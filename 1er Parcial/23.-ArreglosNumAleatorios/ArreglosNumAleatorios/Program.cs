using System;

namespace ArreglosNumAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int elec = 0;
            NumAleatorios ObjNumAleatorios = new NumAleatorios(100);

            //Imprimimos los metodos.
            ObjNumAleatorios.CapturaArreglo();
            ObjNumAleatorios.ContarNum();
            ObjNumAleatorios.MostrarNum();
            do
            {
                //Captura de datos.
                Console.WriteLine(" ____________________________________");
                Console.WriteLine(" ------ Deseas buscar un numero -------");
                Console.WriteLine("  (1) Buscar");
                Console.WriteLine("  (2) Salir");
                Console.Write("  R=");
                elec = Int16.Parse(Console.ReadLine());
                Console.WriteLine(" ____________________________________");
                Console.WriteLine();
                switch (elec)
                {
                    case 1://Buscar numero
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine(" ¿Que numero buscar?");
                        Console.Write(" R= ");
                        ObjNumAleatorios.BuscarNum(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine();
                        break;
                    case 2://Eleccion Cerrar programa
                        Console.WriteLine(" Fin del programa...");
                        elec = 0;
                        break;
                    default://Eleccion no valida
                        Console.WriteLine(" Error Selecciona una opcion del menu...");
                        Console.WriteLine("_______________________________________");
                        elec = 0;
                        break;
                }


                
            } while (elec != 0);
        }
    }
}
