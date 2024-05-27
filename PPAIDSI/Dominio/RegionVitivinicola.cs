namespace PPAIDSI.Dominio
{
    public class RegionVitivinicola
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private Provincia provincia { get; set; }

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