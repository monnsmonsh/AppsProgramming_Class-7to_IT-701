using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Disco
    {
        //Atrivutos de la clase.
        private int idDisco;
        private string titulo;
        private string artista;
        private int numPistas;
        private DateTime fechaLanzamiento;
        private double precio;


        //Constructores
        public Disco() { }
        public Disco(int idDisco, string titulo, string artista, int numPistas, DateTime fechaLanzamineto, double precio)
        {
            this.idDisco = idDisco;
            this.titulo = titulo;
            this.artista = artista;
            this.numPistas = numPistas;
            this.fechaLanzamiento = fechaLanzamineto;
            this.precio = precio;
        }
        public Disco(string titulo, string artista, int numPistas, DateTime fechaLanzamineto, double precio)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.numPistas = numPistas;
            this.fechaLanzamiento = fechaLanzamineto;
            this.precio = precio;
        }


        public int IdDisco { get => idDisco; set => idDisco = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public int NumPistas { get => numPistas; set => numPistas = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public double Precio { get => precio; set => precio = value; }

        //Metodos
        public override string ToString()
        {
            return artista + " - " + titulo;
        }







    }
}
