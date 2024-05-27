namespace PPAIDSI.Dominio
{
    public class Provincia
    {
        private string nombre { get; set; }
        private Pais pais { get; set; }

        public string getPais()
        {
            return this.pais.getNombre();
        }
    }
}