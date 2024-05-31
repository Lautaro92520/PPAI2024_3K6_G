namespace PPAIDSI.Dominio
{
    public class Provincia
    {
        private string nombre { get; set; }
        private Pais pais { get; set; }

        public Provincia() { }
        public Provincia(string nombre, Pais pais)
        { 
            this.nombre = nombre;
            this.pais = pais; 
        }

        public string getPais()
        {
            return this.pais.getNombre();
        }
    }
}