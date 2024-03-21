using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasObjetos
{
    class Disco
    {
        //Atributos de la clase.
        private string titulo;
        private string artista;
        private int numPistas;
        private DateTime fechaLanzamiento;
        private double precio;

        //Constructores.
        public Disco() { }
        public Disco(string titulo, string artista, int numPistas, DateTime fechaLanzamiento, double precio)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.numPistas = numPistas;
            this.fechaLanzamiento = fechaLanzamiento;
            this.precio = precio;
        }

        //Propiedades GET y SET.
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public int NumPistas { get => numPistas; set => numPistas = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public double Precio { get => precio; set => precio = value; }

        //Redifinimos el metodo ToString
        public override string ToString()
        {
            return artista + " - " +titulo;
        }

    }
}
