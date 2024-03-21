using System;
using System.Collections.Generic;
using System.Text;

namespace InpuestoAutomovil
{
    class VenderAutomovil
    {
        //Atributos de la clase.
        private string marca;
        private double costo;
        //private string pais;
        

        //Constructores
        public VenderAutomovil() { }
        public VenderAutomovil(string marca, double costo)
        {
            this.marca = marca;
            this.costo = costo;
            //this.pais = pais;
            
        }

        //Propiedades get y set
        public string Marca { get => marca; set => marca = value; }
        public double Costo { get => costo; set => costo = value; }
        //public string Pais { get => pais; set => pais = value; }


        //Metodos
        public void TickeAlemania() {
            double iva = 0;
            iva = costo + (costo * .20);
            Console.WriteLine("");
            Console.WriteLine(" ---------- Ticket ----------");
            Console.WriteLine("     Marca:  " + marca);
            Console.WriteLine("     Precio: "+ costo);
            Console.WriteLine("     IVA:     20%");
            Console.WriteLine("     Total:  "+ iva);
        }

        public void TickeJapon()
        {
            double iva = 0;
            iva = costo + (costo * .30);
            Console.WriteLine("");
            Console.WriteLine(" ---------- Ticket ----------");
            Console.WriteLine("     Marca:  " + marca);
            Console.WriteLine("     Precio: " + costo);
            Console.WriteLine("     IVA:     30%");
            Console.WriteLine("     Total:  " + iva);
        }
        public void TickeItalia()
        {
            double iva = 0;
            iva = costo + (costo * .15);
            Console.WriteLine("");
            Console.WriteLine(" ---------- Ticket ----------");
            Console.WriteLine("     Marca:  " + marca);
            Console.WriteLine("     Precio: " + costo);
            Console.WriteLine("     IVA:     15%");
            Console.WriteLine("     Total:  " + iva);
        }

        public void TickeUSA()
        {
            double iva = 0;
            iva = costo + (costo * .08);
            Console.WriteLine("");
            Console.WriteLine(" ---------- Ticket ----------");
            Console.WriteLine("     Marca:  " + marca);
            Console.WriteLine("     Precio: " + costo);
            Console.WriteLine("     IVA:      8%");
            Console.WriteLine("     Total:  " + iva);
        }



    }
}
