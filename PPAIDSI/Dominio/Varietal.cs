namespace PPAIDSI.Dominio
{
    public class Varietal
    {
        private string descripcion { get; set; }
        private int porcentajeComposicion { get; set; }
        private TipoUva tipoUva { get; set; }

        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}