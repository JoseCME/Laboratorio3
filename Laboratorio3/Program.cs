List<string> estudiantes = new List<string>();
List<double> calificaciones = new List<double>();
int opcion;

//esta funcion es para mostrar el menu
void MostrarMenu()
{
    Console.WriteLine("\nMenú de opciones:");
    Console.WriteLine("1. Agregar estudiante");
    Console.WriteLine("2. Mostrar lista de estudiantes");
    Console.WriteLine("3. Calcular promedio de calificaciones");
    Console.WriteLine("4. Mostrar calificación más alta");
    Console.WriteLine("5. Salir");
    Console.Write("Ingrese el número de la opción deseada: ");
}
//esta funcion es para agregar un estudiante
void AgregarEstudiante()
{
    Console.Write("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();
    Console.Write("Ingrese la calificación del estudiante: ");
    double calificacion;
    try
    {
        calificacion = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        return;
    }
    estudiantes.Add(nombre);
    calificaciones.Add(calificacion);
    Console.WriteLine("Estudiante agregado correctamente.");
}
//esta funcion es para mostrar la lista de estudiantes
void MOSTRARLISTAESTUDIANTES()
{
    if (estudiantes.Count == 0)
    {
        Console.WriteLine("No hay estudiantes registrados.");
    }
    else
    {
        Console.WriteLine("\nLista de estudiantes:");
        for (int i = 0; i < estudiantes.Count; i++)
        {
            Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
        }
    }

}
//esta funcion es para calcular el promedio de las calificaciones
void Calcularpromedio()
{


    if (calificaciones.Count == 0)
    {
        Console.WriteLine("No hay calificaciones registradas.");
    }
    else
    {
        double suma = 0;
        foreach (double calificacion in calificaciones)
        {
            suma += calificacion;
        }
        double promedio = suma / calificaciones.Count;
        Console.WriteLine($"El promedio de calificaciones es: {promedio}");
    }
}
//esta funcion es para mostrar la calificacion mas alta
void MaxCalificacion()
{
    if (calificaciones.Count == 0)
    {
        Console.WriteLine("No hay calificaciones registradas.");
    }
    else
    {
        double maxCalificacion = calificaciones[0];
        string estudianteMax = estudiantes[0];
        for (int i = 1; i < calificaciones.Count; i++)
        {
            if (calificaciones[i] > maxCalificacion)
            {
                maxCalificacion = calificaciones[i];
                estudianteMax = estudiantes[i];
            }
        }
        Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");

    }
}

while (true)
    {
    Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");
    MostrarMenu();

    try
    {
        opcion = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        continue;
    }
    
    switch (opcion)
        {
            case 1:
                AgregarEstudiante();

                break;
            case 2:
                MOSTRARLISTAESTUDIANTES();
                break;

            case 3:
                Calcularpromedio();
                break;
            case 4:
                MaxCalificacion();
                break;
            case 5:
                Console.WriteLine("Saliendo del sistema...");
                return;

            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
              
        }
    }
    
    
   

       