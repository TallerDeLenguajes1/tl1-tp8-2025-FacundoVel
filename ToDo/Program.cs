using EspacioTarea;

List<Tarea> tareasPendientes = new List<Tarea>();


int id = 1;
Random random = new Random();

Console.WriteLine("Ingrese cantidad de tareas a generar: ");
string? input = Console.ReadLine();
int.TryParse(input, out int cantidadTareas);

if(cantidadTareas > 0)
{
    for(int i = 0; i < cantidadTareas; i++)
    {
        Console.WriteLine($"\nTarea {i + 1}: ");
        string descripcion = $"descripcion de tarea al azar numero {i + 1}";
        int duracion = random.Next(10, 101);
        Tarea nuevaTarea = new Tarea(i+1, descripcion, duracion);
        tareasPendientes.Add(nuevaTarea);
    }
}
else
{
    Console.WriteLine("No se ingreso una cantidad valida de tareas.");
}

Console.WriteLine("\nTareas Pendientes: ");
foreach (Tarea t in tareasPendientes)
{
    t.Mostrar();
}

