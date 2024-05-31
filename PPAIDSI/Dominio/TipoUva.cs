namespace PPAIDSI.Dominio
{
    public class TipoUva
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        public TipoUva() { }
        public TipoUva(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}