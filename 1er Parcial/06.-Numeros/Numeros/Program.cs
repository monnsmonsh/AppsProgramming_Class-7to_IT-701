using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" -------- Numero Mayor o Menor ---------");
            Console.WriteLine(" Ingresa el primer numero");
            Console.Write(" R=");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            Console.Write(" R=");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer numero");
            Console.Write(" R=");
            int num3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(" ----------------------- ");
            Console.WriteLine("");
            //Creamos el objeto de la clase Temperatura.
            MayorMenor objMayorMenor = new MayorMenor(num1, num2, num3);

            //Monstramos numeros impares
            objMayorMenor.NumMayor();
            objMayorMenor.NumMenor();

            Console.ReadLine();
        }
    }
}
