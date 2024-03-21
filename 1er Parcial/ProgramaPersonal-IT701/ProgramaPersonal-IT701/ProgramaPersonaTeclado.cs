using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class ProgramaPersonaTeclado{
        static void Mainx(string[] args){

            //Creamos un objeto de la clase Persona.
            Persona objPersona = new Persona();

            //Asignamos valores al objeto mediante las propiedades SET
            System.Console.WriteLine("Clave: ");
            objPersona.Clave = Convert.ToInt32(System.Console.ReadLine()); //Asignado el valor a clave
            System.Console.WriteLine("Nombre: ");
            objPersona.Nombre = System.Console.ReadLine(); //Asignado el valor a nombre
            System.Console.WriteLine("Direccion: ");
            objPersona.Direccion = System.Console.ReadLine();  //Asignado el valor a direccion
            System.Console.WriteLine("Telefono: ");
            objPersona.Telefono = System.Console.ReadLine(); //Asignado el valor a telefono
            System.Console.WriteLine("E-mail: ");
            objPersona.Email = System.Console.ReadLine(); //Asignado el valor a email
            System.Console.WriteLine("Fecha de Nacimineto (dd/mm/aaaa): ");
            objPersona.FechaNacimineto = Convert.ToDateTime(System.Console.ReadLine()); //Asignado el valor a fecha

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
