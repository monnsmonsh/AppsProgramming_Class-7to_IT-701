using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class ProgramaPersona
    {
        static void Mainx(string[] args){
            //Creamos un objeto de la clase Persona.
            Persona objPersona = new Persona();

            //Asignamos valores al objeto mediante las propiedades SET
            objPersona.Clave = 100; //Asignado el valor a clave
            objPersona.Nombre = "Martin Monserrat Rodriguez Cortez"; //Asignado el valor a nombre
            objPersona.Direccion = "Aguascalientes 137"; //Asignado el valor a direccion
            objPersona.Telefono = "477-XXX-3750"; //Asignado el valor a telefono
            objPersona.Email = "ejemplo.mk@gmail.com"; //Asignado el valor a email
            objPersona.FechaNacimineto = Convert.ToDateTime("00/00/2000"); //Asignado el valor a fecha

            //Mostrando los datos del objeto en pantalla
            System.Console.WriteLine("Datos del objeto persona");
            System.Console.WriteLine("Clave: "+objPersona.Clave);
            System.Console.WriteLine("Nombre: " + objPersona.Nombre);
            System.Console.WriteLine("Direccion: " + objPersona.Direccion);
            System.Console.WriteLine("Telefono: " + objPersona.Telefono);
            System.Console.WriteLine("E-mail: " + objPersona.Email);
            System.Console.WriteLine("Fecha de Nacimiento: " + objPersona.FechaNacimineto.ToShortDateString());
            System.Console.Read();//Instruccion para detener la pantalla
        }
    }
}
