using EspacioTarea;

List<Tarea> tareasPendientes = new List<Tarea>();

int n = 0;
int id = 1;

Console.WriteLine("Ingrese cantidad de tareas a Realizar: ");
string? input = Console.ReadLine();
int.TryParse(input, out int cantidadTareas);

if(cantidadTareas > 0)
{
    for(int i = 0; i < cantidadTareas; i++)
    {
        Console.WriteLine($"\Tarea {i + 1}: ");
        Console.WriteLine("Descripcion de la tarea: ");
        string? descripcion = Console.ReadLine();

        Console.WriteLine("Duracion (10-100): ");
        string? duracionInput = Console.ReadLine();
        int.TryParse(duracionInput, out int duracionNumero);

        if(duracionNumero >=10 && duracionNumero <= 100)
        {
            Tarea nuevaTarea = new Tarea(id++, descripcion, duracion);
            tareasPendientes.Add(nuevaTarea);
        }
        else
        {
            Console.WriteLine("Duracion invalida.");
        }
    }
}