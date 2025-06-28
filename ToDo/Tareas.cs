namespace EspacioTarea
{
    public class Tarea
    {
        private int _tareaID;
        private string _descripcion;
        private int _duracion;

        public Tarea(int id, string desc, int dur)
        {
            _tareaID = id;
            _descripcion = desc;
            Duracion = dur;
        }

        public int TareaID { get => _tareaID; set => _tareaID = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Duracion
        {
            get => _duracion;
            set{
                 if (value >= 10 && value <=100)
                 {
                    _duracion = value;
                 }
                 else
                 {
                    Console.WriteLine("La duración debe estar entre 10 y 100 minutos.");
                 }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine($"ID: {TareaID} | Descripción: {Descripcion} | Duración: {Duracion}");
        }

    }  
}


