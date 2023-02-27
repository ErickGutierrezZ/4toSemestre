// See https://aka.ms/new-console-template for more information
//Hacer un programa que lea el nombre, edad y sexo de 5 personas, el programa mostrará en pantalla los siguientes resultados:
//Promedio de edades de mujeres
//Cual es el hombre mayor y menor de edad
//Cuales de las mujeres son menores de edad.
//Obligatorio utilizar listas
/*hacer un programa que lea nombre edad y sexo de 5 personas el programa mostrara en pantalla los siguientes resultados 1-.promedio de edades de mujeres 2-.cual es el 
 * mayor y menor de edad 3-. cuales de las mujeres son menores de edad.
 obligatorio usar listas*/


/*using System;
using System.Collections.Generic;
string nombre;
int calificacion;
List<List<string>> alumnos = new List<List<string>>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Ingrese el nombre del alumno " + (i + 1));
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la calificación " + " del alumno " + nombre);
    calificacion = Convert.ToInt32(Console.ReadLine());
   

    List<string> alumno = new List<string>();
    alumno.Add(nombre);
    alumno.Add(calificacion.ToString());

}
                Console.WriteLine("Lista de alumnos y sus calificaciones:");
                
               // foreach (List<string> alumno in alumnos)
                //{
                foreach (var i in alumno)
                {
                    Console.WriteLine(String.Join(", ", i));
                }
    
                Console.ReadLine();
        */

            using System;
            using System.Collections.Generic;

            List<List<string>> alumnos = new List<List<string>>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno " + (i + 1));
                string nombre = Console.ReadLine();

                
    
                List<string> calificaciones = new List<string>();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese la calificación " + (j + 1) + " del alumno " + nombre);
                    string calificacion = Console.ReadLine();
                    calificaciones.Add(calificacion);
                }





                List<string> alumno = new List<string>();
                alumno.Add(nombre);
                alumno.AddRange(calificaciones);
                
                alumnos.Add(alumno);
            }



            Console.WriteLine("Lista de alumnos y sus calificaciones:");
            foreach (List<string> i in alumnos)
            {
                Console.WriteLine(String.Join(", ", i));
            }
            Console.ReadLine();
        

















using System;
using System.Collections.Generic;
bool ban = true;
string res;
int ina;
while (true)
{
    List<List<string>> alumnos = new List<List<string>>();

    for (int j = 0; ban == true; j++)
    {
        Console.WriteLine("Ingrese el nombre del alumno ");
        string nombre = Console.ReadLine();


        List<string> calificaciones = new List<string>();

        Console.WriteLine("Ingrese la calificación " + " del alumno " + nombre);
        string calificacion = Console.ReadLine();
        calificaciones.Add(calificacion);


        List<string> correos = new List<string>();

        Console.WriteLine("Ingrese el correo " + " del alumno " + nombre);
        string correo = Console.ReadLine();
        correos.Add(correo);


        List<string> materias = new List<string>();

        Console.WriteLine("Ingrese la materia " + " del alumno " + nombre);
        string materia = Console.ReadLine();
        materias.Add(materia);

        List<string> estatus = new List<string>();

        Console.WriteLine("Ingrese el estatus " + " del alumno " + nombre);
        string estatu = Console.ReadLine();
        estatus.Add(estatu);




        List<string> alumno = new List<string>();
        alumno.Add(nombre);
        alumno.AddRange(calificaciones);
        alumno.AddRange(correos);
        alumno.AddRange(materias);
        alumno.AddRange(estatus);

        alumnos.Add(alumno);





        Console.WriteLine("Desea escribir otro alumno? s/n ");
        res = Console.ReadLine();




        if (res == "n")
        {
            ban = false;
            //}
            Console.WriteLine("Lista de alumnos y sus calificaciones:");
            foreach (List<string> i in alumnos)
            {

                Console.WriteLine(String.Join(", ", i + ));

            }
            Console.ReadLine();

        }

        else
        {
            ban = true;
        }
    }
}