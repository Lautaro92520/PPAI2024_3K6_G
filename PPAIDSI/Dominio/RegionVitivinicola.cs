namespace PPAIDSI.Dominio
{
    public class RegionVitivinicola
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private Provincia provincia { get; set; }

        public RegionVitivinicola() { }

        public RegionVitivinicola(string nombre, string descripcion, Provincia provincia)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.provincia = provincia;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getPais()
        {
            return this.provincia.getPais();
        }
    }
}