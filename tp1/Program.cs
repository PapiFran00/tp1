// 1)

using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

string nombre = "";
float suma = 0;
float promedio = 0;
float calificacion= 0;
string calificaciones = "";

    Console.WriteLine("Ingresar nombre de estudiante");
    nombre = Console.ReadLine();

while (nombre == "")
{
    Console.WriteLine("Tienes que ingresar un nombre valido, porfavor ingrese un nombre");
    nombre= Console.ReadLine();
}

Console.WriteLine("¿Cuantas calificaciones tiene el estudiante? Recuerde tiene que ser de 1 a 5");
int cantidadCalificaciones = int.Parse(Console.ReadLine());

while (cantidadCalificaciones < 1 ||cantidadCalificaciones > 5)
{
    Console.WriteLine("Cantidad invalida, Recuerde tiene que ser de 1 a 5");
     cantidadCalificaciones = int.Parse(Console.ReadLine());
}

for ( int i = 1; i <= cantidadCalificaciones; i++ )
{
    Console.WriteLine("Ingrese la calificacion, recuerde es de 1 a 10");
     calificacion= int.Parse(Console.ReadLine());
    


    while (calificacion <1 || calificacion > 10)
    {
        Console.WriteLine("Calificacion invalida, recuerde que tiene que ser de 1 al 10");
        calificacion = int.Parse(Console.ReadLine());
    }
    suma = suma + calificacion;
}
promedio = suma / cantidadCalificaciones;

if (promedio >= 9)
{
    calificaciones = "Excelente";
}

else if (promedio >= 7)
{
    calificaciones = "Bueno";
}

else if (promedio >= 6)

{ calificaciones = "Regular"; }

else { calificaciones = "Reprobado"; }



Console.WriteLine($"El alumno {nombre}");
Console.WriteLine($"El promedio es {promedio}");
Console.WriteLine($"La nota final es {calificaciones}");








