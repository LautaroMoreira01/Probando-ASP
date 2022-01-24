
    public class persona
    {
        private string nombre;
        private string apellido;
        public persona(string nombre, string apellido)
        {
        this.nombre = nombre;
        this.apellido = apellido;
        }

        public override string ToString()
        {
        return nombre + " " + apellido;
        }

    }
