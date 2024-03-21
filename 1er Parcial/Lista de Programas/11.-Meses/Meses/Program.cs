using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------- Informacion de Meses---------");
            System.Console.WriteLine(" Inserta el Numero de tu mes:  ");
            Console.Write(" R=");
            String eleccion = System.Console.ReadLine();
            int valor = Convert.ToInt32(eleccion); //valor del objeto
            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            //Creamos el objeto de la clase Temperatura.
            NumMes objNumeroMes = new NumMes();

            switch (valor)
            {
                case 1://Eleccion de Mes Enero
                    //Monstramos la informacion
                    objNumeroMes.Enero();
                    break;

                case 2://Eleccion de Mes Febreo
                    //Monstramos la informacion
                    objNumeroMes.Febrero();
                    break;
                case 3://Eleccion de Mes Marzo
                    //Monstramos la informacion
                    objNumeroMes.Marzo();
                    break;
                case 4://Eleccion de Mes Abril
                    //Monstramos la informacion
                    objNumeroMes.Abril();
                    break;
                case 5://Eleccion de Mes Mayo
                    //Monstramos la informacion
                    objNumeroMes.Mayo();
                    break;
                case 6://Eleccion de Mes Junio
                    //Monstramos la informacion
                    objNumeroMes.Junio();
                    break;
                case 7://Eleccion de Mes Julio
                    //Monstramos la informacion
                    objNumeroMes.Julio();
                    break;
                case 8://Eleccion de Mes Agosto
                    //Monstramos la informacion
                    objNumeroMes.Agosto();
                    break;
                case 9://Eleccion de Mes Septiembre
                    //Monstramos la informacion
                    objNumeroMes.Septiembre();
                    break;
                case 10://Eleccion de Mes Octubre
                    //Monstramos la informacion
                    objNumeroMes.Octubre();
                    break;
                case 11://Eleccion de Mes Noviembre
                    //Monstramos la informacion
                    objNumeroMes.Noviembre();
                    break;
                case 12://Eleccion de Mes Diciembre
                    //Monstramos la informacion
                    objNumeroMes.Diciembre();
                    break;
                default:
                    System.Console.WriteLine("Mes no valido");
                    break;

            }



                    

            Console.ReadLine();
        }
    }
}
