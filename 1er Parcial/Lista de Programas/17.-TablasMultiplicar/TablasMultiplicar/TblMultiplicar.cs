using System;
using System.Collections.Generic;
using System.Text;

namespace TablasMultiplicar
{
    class TblMultiplicar
    {
        //Atributos de la clase.
        public int x;
        public int y;
        public int z; 


        //Metodos.
        public void CalcularTabla()
        {
            string tabla="";
            z = 0;
            x = 0;
            y = 0;
            for (int i = 0; i < 11; i++)
            {
                y = 0;
                Console.WriteLine(" Tabla del " + x);
                for (int j = 0; j < 10; j++)
                {
                    z = x * y;
                    Console.WriteLine(" "+ x + "x" + y + "=" + z);
                    y++;

                }
                x++;
            }
        }
    }
}
