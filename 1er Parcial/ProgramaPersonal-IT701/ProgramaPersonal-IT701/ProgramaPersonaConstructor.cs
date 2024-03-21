using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class ProgramaPersonaConstructor
    {
        static void Mainx(string[] args)
        {
            //Captura de datos del objeto
            System.Console.WriteLine("Clave: ");
            int clave = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Nombre: ");
            String nombre = System.Console.ReadLine();
            System.Console.WriteLine("Direccion: ");
            string direccion = System.Console.ReadLine();
            System.Console.WriteLine("Telefono: ");
            string telefono = System.Console.ReadLine();
            System.Console.WriteLine("E-mail: ");
            string email = System.Console.ReadLine();
            System.Console.WriteLine("Fecha de Nacimineto (dd/mm/aaaa): ");
            DateTime fechaNacimineto = Convert.ToDateTime(System.Console.ReadLine());


            //Creamos un objeto de la clase Persona.
            Persona objPersona = new Persona(clave, nombre, direccion, telefono, email, fechaNacimineto);



            //Mostrando los datos del objeto en pantalla
            System.Console.WriteLine("");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Datos del objeto persona");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Clave: " + objPersona.Clave);
            System.Console.WriteLine("Nombre: " + objPersona.Nombre);
            System.Console.WriteLine("Direccion: " + objPersona.Direccion);
            System.Console.WriteLine("Telefono: " + objPersona.Telefono);
            System.Console.WriteLine("E-mail: " + objPersona.Email);
            System.Console.WriteLine("Fecha de Nacimiento: " + objPersona.FechaNacimineto.ToShortDateString());
            System.Console.Read();//Instruccion para detener la pantalla
        }
    }
}
