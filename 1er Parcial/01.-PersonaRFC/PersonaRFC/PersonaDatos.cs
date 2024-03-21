using System;
using System.Collections.Generic;
using System.Text;

namespace PersonaRFC
{
    class PersonaDatos
    {
        //Atributos de la clase.
        private string nombre;
        private string apePat;
        private string apeMat;
        private DateTime fecha;

        //Constructor por omision
        public PersonaDatos() { }

        //Constructor definido por el programador
        public PersonaDatos(string nombre, string apePat, string apeMat, DateTime fecha)
        {
            this.nombre = nombre;
            this.apePat = apePat;
            this.apeMat = apeMat;
            this.fecha = fecha;


        }

        //Propiedades GET y SET.
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApePat { get => apePat; set => apePat = value; }
        public string ApeMat { get => apeMat; set => apeMat = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        //Metodos.
        public void MostrarRFC()
        {
            string PersonaRFC;

            String conversion = Convert.ToString(fecha);
            string subapeP = apePat.Substring(0, 2);
            string subapeM = apeMat.Substring(0, 1);
            string subnombre = nombre.Substring(0, 1);
            string subfecha1 = conversion.Substring(0, 2);
            string subfecha2 = conversion.Substring(3, 2);
            string subfecha3 = conversion.Substring(6, 2);

            PersonaRFC= subapeP + subapeM + subnombre + subfecha3 + subfecha2 + subfecha1;
            Console.WriteLine(" Tu RFC es: " + PersonaRFC);
        }

        public void Edad()
        {
            int edad;
            edad= DateTime.Today.AddTicks(-fecha.Ticks).Year - 1;
            Console.WriteLine(" Tu edad es: " + edad);
        }
    }
}
