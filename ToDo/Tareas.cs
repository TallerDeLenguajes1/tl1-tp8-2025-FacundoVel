namespace EspacioTarea
{
    public class Tarea
    {
        private int _tareaID;
        private string _descripcion;
        private int _duracion;

        public int TareaID { get => _tareaID; set => _tareaID = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Duracion { get => _duracion; 
            set {
                if(value >=10 && value <= 100)
                {
                    _duracion = value;
                    } 
                }
    }  
}
