using System;

namespace Distancia2Dy3D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu de Seleccion
            System.Console.WriteLine("  ------------------------------  ");
            System.Console.WriteLine("     CACULADOR DE DISTANCIA ");
            System.Console.WriteLine("  ------------------------------  ");
            System.Console.WriteLine("¿Que tipo de distacia quieres calcular? ");
            System.Console.WriteLine("Distancia 2D (Ingresa el numero 1)");
            System.Console.WriteLine("Distancia 3D (Ingresa el numero 2)");
            System.Console.WriteLine("");
            System.Console.Write("R= ");
            String eleccion = System.Console.ReadLine();
            int valor = Convert.ToInt32(eleccion); //valor del objeto
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            switch (valor)
            {
                case 1://Eleccion de Distacia 2D
                    //Captura de datos.
                    Console.WriteLine(" ---------------------- ");
                    Console.WriteLine("    Distacia de X Y");
                    Console.WriteLine(" ----------------------");
                    Console.WriteLine("");

                    Console.WriteLine(" Cordenadas A ");
                    Console.WriteLine(" --------------");
                    Console.Write(" Inserta el valor de x1: ");
                    double x1 = System.Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Inserta el valor de y1: ");
                    double y1 = System.Convert.ToDouble(Console.ReadLine());
                    //Creamos  el objeto utilizando el segundo constructor
                    Distancia2D objPuntoA = new Distancia2D(x1, y1);

                    Console.WriteLine(" Cordenadas B ");
                    Console.WriteLine(" --------------");
                    Console.Write(" Inserta el valor de x2: ");
                    double x2 = System.Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Inserta el valor de y2: ");
                    double y2 = System.Convert.ToDouble(Console.ReadLine());
                    //Creamos  el objeto utilizando el segundo constructor
                    Distancia2D objPuntoB = new Distancia2D(x2, y2);

                    //Resultado
                    Console.WriteLine("");
                    Console.WriteLine(" RESULTADO");
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" La distacia es:" + (objPuntoB.ResultadoDistaciaXY(objPuntoA)));
                    Console.WriteLine(" ---------------------");
                    Console.Read();
                    break;


                case 2://Eleccion de Distacia 3D
                    //Captura de datos.
                    Console.WriteLine(" ---------------------- ");
                    Console.WriteLine("    Distacia de X Y Z");
                    Console.WriteLine(" ----------------------");
                    Console.WriteLine("");

                    Console.WriteLine(" Cordenadas A ");
                    Console.WriteLine(" ---------------------");
                    Console.Write(" Inserta el valor de x1: ");
                    double X1 = System.Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Inserta el valor de y1: ");
                    double Y1 = System.Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Inserta el valor de z1: ");
                    double Z1 = System.Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    //Creamos  el objeto utilizando el segundo constructor
                    Distancia3D objPuntoA2 = new Distancia3D(X1, Y1, Z1);

                    Console.WriteLine(" Cordenadas B ");
                    Console.WriteLine(" ---------------------");
                    Console.Write(" Inserta el valor de x2: ");
                    double X2 = System.Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Inserta el valor de y2: ");
                    double Y2 = System.Convert.ToDouble(Console.ReadLine());
                    Console.Write(" Inserta el valor de z2: ");
                    double Z2 = System.Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    //Creamos  el objeto utilizando el segundo constructor
                    Distancia3D objPuntoB2 = new Distancia3D(X2, Y2, Z2);

                    //Resultado
                    Console.WriteLine("");
                    Console.WriteLine(" RESULTADO");
                    Console.WriteLine(" ------------------");
                    Console.WriteLine(" La distacia es:" + (objPuntoB2.ResultadoDistaciaXY(objPuntoA2)));
                    Console.WriteLine(" ------------------");
                    Console.Read();
                    break;
                  

                default:
                    System.Console.WriteLine("Eleccion no validad");
                    break;
            }


            
        }
    }
}
