using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPersonal_IT701
{
    class ProgramaPersonaHerencia
    {
        static void Mainx(string[] args)
        {
            //Captura de datos del objeto
            System.Console.WriteLine("¿Que tipo de onjeto quieres generar? ");
            System.Console.WriteLine("1.-Persona");
            System.Console.WriteLine("2.-Alumno");
            System.Console.WriteLine("3.-Profesor");
            String eleccion = System.Console.ReadLine();
            int valor = Convert.ToInt32(eleccion); //valor del objeto
            System.Console.WriteLine("--------------------------------------");


            switch (valor)
            {
                case 1://Eleccion de Objeto Persona
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
                    System.Console.WriteLine("Edad: " + objPersona.CalcularEdad());
                    System.Console.Read();//Instruccion para detener la pantalla
                    break;


                case 2://Eleccion de Objeto Alumno
                    //Captura de datos del objeto
                    System.Console.Write("Clave: ");
                    int clave2 = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Write("Nombre: ");
                    String nombre2 = System.Console.ReadLine();
                    System.Console.Write("Direccion: ");
                    string direccion2 = System.Console.ReadLine();
                    System.Console.Write("Telefono: ");
                    string telefono2 = System.Console.ReadLine();
                    System.Console.Write("E-mail: ");
                    string email2 = System.Console.ReadLine();
                    System.Console.Write("Fecha de Nacimineto (dd/mm/aaaa): ");
                    DateTime fechaNacimineto2 = Convert.ToDateTime(System.Console.ReadLine());
                    //**********Capturar datos de Alumno
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("------------------------- ");
                    System.Console.WriteLine(" Ingresar Calificaciones");
                    System.Console.WriteLine("------------------------- ");
                    System.Console.WriteLine("Calificacion 1: ");
                    int calificacion1 = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Calificacion 2: ");
                    int calificacion2 = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Calificacion 3: ");
                    int calificacion3 = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("--------------------------------------");

                    //Creamos un objeto de la clase Alumno.
                    Alumno objAlumno = new Alumno(clave2, nombre2, direccion2, telefono2, email2, fechaNacimineto2,
                        calificacion1, calificacion2, calificacion3);

                    //Mostrando los datos del objeto en pantalla
                    System.Console.WriteLine("");
                    System.Console.WriteLine("------------------------");
                    System.Console.WriteLine("Datos del objeto alumno");
                    System.Console.WriteLine("------------------------");
                    System.Console.WriteLine("Clave: " + objAlumno.Clave);
                    System.Console.WriteLine("Nombre: " + objAlumno.Nombre);
                    System.Console.WriteLine("Direccion: " + objAlumno.Direccion);
                    System.Console.WriteLine("Telefono: " + objAlumno.Telefono);
                    System.Console.WriteLine("E-mail: " + objAlumno.Email);
                    System.Console.WriteLine("Fecha de Nacimiento: " + objAlumno.FechaNacimineto.ToShortDateString());
                    System.Console.WriteLine("Edad: " + objAlumno.CalcularEdad());
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Boleta de Calificaciones");
                    System.Console.WriteLine("------------------------");
                    System.Console.WriteLine("Calificacion 1: " + objAlumno.Calificacion1);
                    System.Console.WriteLine("Calificacion 2: " + objAlumno.Calificacion2);
                    System.Console.WriteLine("Calificacion 3: " + objAlumno.Calificacion3);
                    System.Console.WriteLine("Promedio: " + objAlumno.CalcularPromedio());
                    System.Console.WriteLine("------------------------");
                    System.Console.Read();//Instruccion para detener la pantalla
                    break;

                case 3:
                    //Captura de datos del objeto
                    System.Console.WriteLine("Clave: ");
                    int clave3 = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Nombre: ");
                    String nombre3 = System.Console.ReadLine();
                    System.Console.WriteLine("Direccion: ");
                    string direccion3 = System.Console.ReadLine();
                    System.Console.WriteLine("Telefono: ");
                    string telefono3 = System.Console.ReadLine();
                    System.Console.WriteLine("E-mail: ");
                    string email3 = System.Console.ReadLine();
                    System.Console.WriteLine("Fecha de Nacimineto (dd/mm/aaaa): ");
                    DateTime fechaNacimineto3 = Convert.ToDateTime(System.Console.ReadLine());
                    //**********Capturar datos de Profesor
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("------------------ ");
                    System.Console.WriteLine(" Ingresar NOMINA");
                    System.Console.WriteLine("------------------ ");
                    System.Console.WriteLine("Pago por Hora:");
                    int pagoHora = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Horas trabajadas: ");
                    int numHoras = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("--------------------------------------");

                    //Creamos un objeto de la clase Profesor.
                    Profesor objProfesor = new Profesor(clave3, nombre3, direccion3, telefono3, email3, fechaNacimineto3,
                        pagoHora, numHoras);

                    //Mostrando los datos del objeto en pantalla
                    System.Console.WriteLine("");
                    System.Console.WriteLine("------------------------");
                    System.Console.WriteLine("Datos del objeto alumno");
                    System.Console.WriteLine("------------------------");
                    System.Console.WriteLine("Clave: " + objProfesor.Clave);
                    System.Console.WriteLine("Nombre: " + objProfesor.Nombre);
                    System.Console.WriteLine("Direccion: " + objProfesor.Direccion);
                    System.Console.WriteLine("Telefono: " + objProfesor.Telefono);
                    System.Console.WriteLine("E-mail: " + objProfesor.Email);
                    System.Console.WriteLine("Fecha de Nacimiento: " + objProfesor.FechaNacimineto.ToShortDateString());
                    System.Console.WriteLine("Edad: " + objProfesor.CalcularEdad());
                    System.Console.WriteLine("");
                    System.Console.WriteLine("----- Sueldo (NOMIMA) ----");
                    System.Console.WriteLine("------------------------");
                    System.Console.WriteLine("Pago por hora: " + objProfesor.PagoHora);
                    System.Console.WriteLine("Horas trabajadas: " + objProfesor.NumHoras);
                    System.Console.WriteLine("Total: " + objProfesor.CalcularPagoTotal());
                    System.Console.WriteLine("------------------------");
                    System.Console.Read();//Instruccion para detener la pantalla
                    break;
                default:
                    System.Console.WriteLine("Eleccion no validad");
                    break;
            }








           
        }
    }
}
