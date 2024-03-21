using System;

namespace Fraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int rep;
            do{
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("  OPERACIONES FRACCIONARIAS");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.WriteLine(" -- Fraccion 1 --");
                Console.WriteLine(" ¿Cual es su numerador?");
                Console.Write(" R= ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ¿Cual es su denominador");
                Console.Write(" R= ");
                int den1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" -- Fraccion 2 --");
                Console.WriteLine(" ¿Cual es su numerador?");
                Console.Write(" R= ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ¿Cual es su denominador");
                Console.Write(" R= ");
                int den2 = Convert.ToInt32(Console.ReadLine());

                //Creamos el objeto de la clase OperacionFraccion.
                OperacionFraccion objOperaciones = new OperacionFraccion(num1, num2, den1, den2);


                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("  ¿Que operación deseas hacer?");
                Console.WriteLine("   (1)Suma");
                Console.WriteLine("   (2)Resta");
                Console.WriteLine("   (3)Multiplicar");
                Console.WriteLine("   (4)Dividir");
                Console.WriteLine(" -----------------");
                Console.Write("   R= ");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        objOperaciones.Suma();
                        break;
                    case 2:
                        objOperaciones.Resta();
                        break;
                    case 3:
                        objOperaciones.Multiplicacion();
                        break;
                    case 4:
                        objOperaciones.Division();
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" ¿Deseas Regresar al inicio?");
                Console.WriteLine("  1.-SI                         0.-NO");
                Console.Write(" R= ");
                rep = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (rep != 0);
        }
    }
}
