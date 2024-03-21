using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaPersonal
{
    class Agenda:Persona
    {
        //Atributos de la clase.
        private Persona[] arrPersona = new Persona[100];
        private Persona objPersona = new Persona();
        int cont = 0;

        //Constructor por omision
        public Agenda(){}
        //Constructor definido por el programador
        public Agenda(int clave, string nombre, string direccion, string telefono, string correo, DateTime fechaNac, int cont)
            : base(clave, nombre, direccion, telefono, correo, fechaNac)
        {
            this.cont = cont;
        }

        //Propiedades GET y SET.
        public int Cont { get => cont; set => cont = value; }
        
        //Metodos,
        public void CapturarPersona()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(" Clave: ");
                Console.Write("  R= ");
                int clave = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Nombre: ");
                Console.Write("  R= ");
                String nombre = Console.ReadLine();
                Console.WriteLine(" Direccion: ");
                Console.Write("  R= ");
                String direccion = Console.ReadLine();
                Console.WriteLine(" Telefono: ");
                Console.Write("  R= ");
                String telefono = Console.ReadLine();
                Console.WriteLine(" Correo: ");
                Console.Write("  R= ");
                String correo = Console.ReadLine();
                Console.WriteLine(" Fecha de Nacimiento /DD/MM/AAAA: ");
                Console.Write("  R= ");
                DateTime fechaNac = Convert.ToDateTime(Console.ReadLine());
                objPersona = new Persona(clave, nombre, direccion, telefono, correo, fechaNac);
                arrPersona[cont] = objPersona;
            }
            cont++;
        }

        public void MostrarAgenda()
        {
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine();
                Console.WriteLine("  Clave: " + arrPersona[i].Clave);
                Console.WriteLine("  Nombre: " + arrPersona[i].Nombre);
                Console.WriteLine("  Direccion: " + arrPersona[i].Direccion);
                Console.WriteLine("  Telefono: " + arrPersona[i].Telefono);
                Console.WriteLine("  Correo: " + arrPersona[i].Correo);
                Console.WriteLine("  Fecha de Nacimiento: " + arrPersona[i].FechaNac.ToShortDateString());
            }
        }
        public void BuscarContacto(int x)
        {
            Console.WriteLine(" Buscar: ");
            Console.Write("  R= ");
            /*int buscar = Convert.ToInt32(Console.ReadLine());
            int i= buscar;
            if (buscar == i)
            {
                Console.WriteLine();
                Console.WriteLine("  Clave: " + arrPersona[i].Clave);
                Console.WriteLine("  Nombre: " + arrPersona[i].Nombre);
                Console.WriteLine("  Direccion: " + arrPersona[i].Direccion);
                Console.WriteLine("  Telefono: " + arrPersona[i].Telefono);
                Console.WriteLine("  Correo: " + arrPersona[i].Correo);
                Console.WriteLine("  Fecha de Nacimiento: " + arrPersona[i].FechaNac.ToShortDateString());
            }*/


                
            
        }
    }
}
