using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPizzeria
{
    class Pizza
    {
        //Atributos de la clase.
        private string nombre;
        private string dirrecion;
        private string telefono;
        private int tamPizza;
        private string tamPizzatxt;
        private int ingrePizza;
        private string ingrePizzatxt;
        private int numPizza;
        private int totalPizza;

        //Constructores
   
        public Pizza(string nombre, string dirrecion, string telefono, int tamPizza, string tamPizzatxt, int ingrePizza, string ingrePizzatxt, int numPizza, int totalPizza)
        {
            this.nombre = nombre;
            this.dirrecion = dirrecion;
            this.telefono = telefono;
            this.tamPizza = tamPizza;
            this.tamPizzatxt = tamPizzatxt;
            this.ingrePizza = ingrePizza;
            this.ingrePizzatxt = ingrePizzatxt;
            this.numPizza = numPizza;
            this.totalPizza = totalPizza;
        }

        //Propiedades GET y SET
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dirrecion { get => dirrecion; set => dirrecion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int TamPizza { get => tamPizza; set => tamPizza = value; }
        public string TamPizzatxt { get => tamPizzatxt; set => tamPizzatxt = value; }
        public int IngrePizza { get => ingrePizza; set => ingrePizza = value; }
        public string IngrePizzatxt { get => ingrePizzatxt; set => ingrePizzatxt = value; }
        public int NumPizza { get => numPizza; set => numPizza = value; }
        public int TotalPizza { get => totalPizza; set => totalPizza = value; }

        //Redifinimos el metodo ToString
        public override string ToString()
        {
            return nombre + " - " + numPizza +" pizzas "+"- Total de Venta es: "+totalPizza;
        }
    }
}
