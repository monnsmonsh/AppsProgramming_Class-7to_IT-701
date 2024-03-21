using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularPotencia
{
    class OperacionExponente
    {
        //Atributos de la clase.
        Boolean isPositivo = true;
        double numero;
        double exponente;
        double resultado = 1;

        //Constructores
        public OperacionExponente() { }
        public OperacionExponente(double numero, double exponente)
        {
            this.numero = numero;
            this.exponente = exponente;
        }

        //Propiedades GET y SET
        public bool IsPositivo { get => isPositivo; set => isPositivo = value; }
        public double Numero { get => numero; set => numero = value; }
        public double Exponente { get => exponente; set => exponente = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        //Metodos.
        public String realizarOperacion()
        {
            if (Convert.ToString(exponente).Substring(0, 1) == "-")
            {
                exponente = float.Parse(Convert.ToString(exponente).Remove(0, 1));
                isPositivo = false;
            }

            if (isPositivo)
            {
                for (int i = 0; i < exponente; i++)
                {
                    resultado = resultado * numero;
                }
                return ("El Resultado es: " + resultado);
            }
            else
            {
                for (int i = 0; i < exponente; i++)
                {
                    resultado = resultado * numero;
                }
                resultado = 1 / resultado;
                return ("El Resultado es: " + resultado);
            }

            
        }
    }
}
