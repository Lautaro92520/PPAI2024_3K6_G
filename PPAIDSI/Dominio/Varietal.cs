namespace PPAIDSI.Dominio
{
    public class Varietal
    {
        private string descripcion { get; set; }
        private int porcentajeComposicion { get; set; }
        private TipoUva tipoUva { get; set; }

        public Varietal() { }
        public Varietal(string descripcion, int porcentajeComposicion, TipoUva tipoUva)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
            this.tipoUva = tipoUva;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}