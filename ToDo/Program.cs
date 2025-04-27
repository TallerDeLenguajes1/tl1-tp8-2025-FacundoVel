using EspacioTarea

int n = 0, id = 0, duracion = 0; 

Console.WriteLine("Ingrese cantidad de Tareas a realizar: ");
if((int.TryParse(Console.ReadLine(),out n)) && n > 0)
{
    for (int i = 0; i < n; i++)
    {
        int _tareaID = id++;
        Console.WriteLine("Ingrese la descripcion de la tarea: ");
        string _descripcion = Console.ReadLine();
        Console.WriteLine("Ingrese la duracion de la tarea: ");
        int _duracion = int.Parse(Console.Readline(), out duracion);
        Tarea.add(_tareaID, _descripcion, _duracion);
    }
}
else{
    Console.WriteLine("Ingrese un numero valido");
}