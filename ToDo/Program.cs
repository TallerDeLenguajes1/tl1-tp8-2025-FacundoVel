using EspacioTarea;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();


int id = 1;
Random random = new Random();

int opcion;

do
{
    Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Generar tareas aleatorias");
    Console.WriteLine("2. Ver tareas pendientes");
    Console.WriteLine("3. Ver tareas realizadas");
    Console.WriteLine("4. Marcar tarea como realizada");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    string? inputOpcion = Console.ReadLine();
    bool valido = int.TryParse(inputOpcion, out opcion);

    if(!valido)
    {
        Console.WriteLine("Por favor ingrese una opcion valida");
    }

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese cuántas tareas quiere generar: ");
            string? inputCantidad = Console.ReadLine();
            if (int.TryParse(inputCantidad, out int cantidad) && cantidad > 0)
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    string descripcion = $"Tarea {tareasPendientes.Count + tareasRealizadas.Count + 1}";
                    int duracion = random.Next(10, 101);
                    Tarea nueva = new Tarea(tareasPendientes.Count + tareasRealizadas.Count + 1, descripcion, duracion);
                    tareasPendientes.Add(nueva);
                }
                Console.WriteLine($"{cantidad} tareas generadas exitosamente.");
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
            break;

        case 2:
            Console.WriteLine("\n--- TAREAS PENDIENTES ---");
            if (tareasPendientes.Count == 0)
            {
                Console.WriteLine("No hay tareas pendientes.");
            }
            else
            {
                foreach (var t in tareasPendientes)
                    t.Mostrar();
            }
            break;

        case 3:
            Console.WriteLine("\n--- TAREAS REALIZADAS ---");
            if (tareasRealizadas.Count == 0)
            {
                Console.WriteLine("No hay tareas realizadas.");
            }
            else
            {
                foreach (var t in tareasRealizadas)
                    t.Mostrar();
            }
            break;

        case 4:
            if (tareasPendientes.Count == 0)
            {
                Console.WriteLine("No hay tareas pendientes para marcar como realizadas.");
                break;
            }

            Console.Write("Ingrese el ID de la tarea a marcar como realizada: ");
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out  id))
            {
                Tarea? tarea = tareasPendientes.Find(t => t.TareaID == id);
                if (tarea != null)
                {
                    tareasRealizadas.Add(tarea);
                    tareasPendientes.Remove(tarea);
                    Console.WriteLine($"Tarea {id} marcada como realizada.");
                }
                else
                {
                    Console.WriteLine("No se encontró una tarea con ese ID.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            break;

        case 0:
            Console.WriteLine("Sliendo del sistema..");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}while (opcion != 0);




