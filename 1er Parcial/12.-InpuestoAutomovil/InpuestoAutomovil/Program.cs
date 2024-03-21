using System;

namespace InpuestoAutomovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ---------- Vender Automovil ----------");
            System.Console.Write(" Marca: ");
            string marca = System.Console.ReadLine();
            Console.Write(" Precio: ");
            double costo = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine(" Pais: ");
            Console.WriteLine(" (1) Alemania");
            Console.WriteLine(" (2) Japon");
            Console.WriteLine(" (3) Italia");
            Console.WriteLine(" (4) USA");
            Console.Write(" R: ");
            String eleccion = System.Console.ReadLine();
            int pais = Convert.ToInt32(eleccion); //valor del objeto


            Console.WriteLine();
            Console.WriteLine("---------------");

            //Creamos el objeto de la clase Temperatura.
            VenderAutomovil objVenta = new VenderAutomovil(marca, costo);

            switch (pais)
            {
                case 1://Pais Alemania
                    objVenta.TickeAlemania();
                    break;
                case 2://Pais Japon
                    objVenta.TickeJapon();
                    break;
                case 3://Pais Italia
                    objVenta.TickeItalia();
                    break;
                case 4://Pais USA
                    objVenta.TickeUSA();
                    break;
            }
            //Monstramos el estado del agua

            Console.ReadLine();
        }
    }
}
