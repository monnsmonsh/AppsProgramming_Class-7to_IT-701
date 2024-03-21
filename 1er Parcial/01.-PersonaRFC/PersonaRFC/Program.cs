using System;

namespace PersonaRFC
{
    class Program
    {
        static void Main(string[] args)
        {


            //Capturamos cuantos numeros se van a manejar
            Console.WriteLine();
            Console.WriteLine(" ---------------------");
            Console.WriteLine("    Calcula tu RFC");
            Console.WriteLine();
            Console.WriteLine("Nombre: ");
            Console.Write("R= ");
            string nombre = Console.ReadLine();//ya se asigno prro
            Console.WriteLine("Apellido Paterno: ");
            Console.Write("R= ");
            string apePat = Console.ReadLine();
            Console.WriteLine("Apellido Materno: ");
            Console.Write("R= ");
            string apeMat = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento usando DD/MM/AAAA ");
            Console.Write("R= ");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());//Convert se usa para convertir a un tipo de dato en este caso DateTime

            Console.WriteLine();
            Console.WriteLine();

            //Creamos el objeto de la clase ArregloNumeros.
            PersonaDatos objDatos = new PersonaDatos(nombre, apePat, apeMat, fecha);


            //Mandar llamar a los metodos.
            objDatos.MostrarRFC();
            objDatos.Edad();

            Console.Read();
        }
    }
}
