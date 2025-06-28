using EspacioTarea;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();


int id = 1;
Random random = new Random();

Console.WriteLine("Ingrese cantidad de tareas a generar: ");
string? input = Console.ReadLine();
int.TryParse(input, out int cantidadTareas);

if(cantidadTareas > 0)
{
    for(int i = 0; i < cantidadTareas; i++)
    {
        Console.WriteLine($"Tarea {i + 1} ");
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

string? respuesta;

do
{
    Console.WriteLine("\nIngrese el ID de la tarea realizada o 'N' para finalizar: ");
    respuesta = Console.ReadLine();
    
    if(int.TryParse(respuesta, out int numeroID))
    {
        Tarea? tarea = tareasPendientes.Find(t => t.TareaID == numeroID);
        if(tarea != null)
        {
            tareasPendientes.Remove(tarea);
            tareasRealizadas.Add(tarea);
            Console.WriteLine($"la Tarea {numeroID} ha sido marcada como realizada");
        }
        else
        {
            Console.WriteLine("Tare no encontrada");
        }
    }
}while(respuesta.ToUpper() != "N");

Console.WriteLine("\n-- TAREAS PENDIENTES --");
foreach (var t in tareasPendientes)
{
    t.Mostrar();    
}

Console.WriteLine("\n-- TAREAS REALIZADAS --");
foreach (var t in tareasRealizadas)
{
    t.Mostrar();
} 
