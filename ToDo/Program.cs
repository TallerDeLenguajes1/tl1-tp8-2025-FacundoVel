using EspacioTarea

int n = 0;
Console.WriteLine("Ingrese cantidad de Tareas a realizar: ");
if((int.TryParse(Console.ReadLine(),out n)) && n >= 0)
{
    for (int i = 0; i < n; i++)
    {
        tarea.add()
    }
}
else{
    Console.WriteLine("Ingrese un numero valido");
}