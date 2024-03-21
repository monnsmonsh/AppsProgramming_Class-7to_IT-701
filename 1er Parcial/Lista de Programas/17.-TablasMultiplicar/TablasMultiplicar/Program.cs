using System;

namespace TablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" -------- Tablas de Multiplicar ---------");
            Console.WriteLine("");

            //Creamos el objeto de la clase TblMultiplicar.
            TblMultiplicar objMulti = new TblMultiplicar();

            //Imprimimos los metodos
            objMulti.CalcularTabla();
            Console.Read();
        }
    }
}
