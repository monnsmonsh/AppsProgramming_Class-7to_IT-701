using System;

namespace AnyoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularAnhio objAnhio = new CalcularAnhio();

            Console.WriteLine();
            Console.WriteLine(" -------- Año Bisiesto o no ---------");
            Console.WriteLine(" Digita el año");
            Console.Write(" R=");
            Console.WriteLine();
            Console.WriteLine();
            objAnhio.Anhio = Convert.ToDouble(Console.ReadLine());
            objAnhio.Validar = Convert.ToString(objAnhio.Anhio / 4);
            objAnhio.Validar.ToCharArray();


            

            for (int i = 0; i < objAnhio.Validar.Length; i++)
            {
                if (objAnhio.Validar[i].Equals('.'))
                {
                    objAnhio.Bisiesto = true;
                }
            }
            if (!objAnhio.Bisiesto)
            {
                Console.WriteLine(" El año es bisiesto");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" El año no es bisiesto");
                Console.ReadLine();
            }

        }
    }
}
