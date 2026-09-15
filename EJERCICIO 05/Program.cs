Console.WriteLine("EJERCICIO_5");
Console.WriteLine("CÁLCULO DEL PROMEDIO DE CINCO CALIFICACIONES CICLO FOR"); // Nombre del ejercicio
Console.WriteLine();

//--------------------------------------------------------------------
// Entradas

double suma = 0; // Variable para almacenar la suma de las calificaciones

for (int numero = 1; numero <= 5; numero++)
{
    Console.Write($"Ingrese la calificación {numero}: ");

    double calificacion = Convert.ToDouble(Console.ReadLine());

    suma = suma + calificacion;
}

//--------------------------------------------------------------------
// Operaciones

double promedio = suma / 5.0; // Variable donde guardamos la operación

//--------------------------------------------------------------------
// Salidas

Console.WriteLine();
Console.WriteLine($"El promedio de las cinco calificaciones es: {promedio:F2}");

// "$" se utiliza para insertar variables dentro de un texto

if (promedio >= 90)
{
    Console.WriteLine("Felicidades Alumno Aprobado");
    Console.WriteLine("Excelente");
}
else if (promedio >= 80)
{
    Console.WriteLine("Felicidades Alumno Aprobado");
    Console.WriteLine("Alumno Bueno");
}
else if (promedio >= 70)
{
    Console.WriteLine("Felicidades Alumno Aprobado");
    Console.WriteLine("Alumno Regular");
}
else if (promedio >= 60)
{
    Console.WriteLine("Alumno Reprobado, Sigue Intentándolo");
    Console.WriteLine("Alumno Requiere Apoyo");
}
else if (promedio >= 10)
{
    Console.WriteLine("Alumno Reprobado, Sigue Intentándolo");
    Console.WriteLine("Alumno Deficiente");
}
else
{
    Console.WriteLine("Alumno Reprobado, Sigue Intentándolo");
    Console.WriteLine("Baja Definitiva");
}

Console.WriteLine ();