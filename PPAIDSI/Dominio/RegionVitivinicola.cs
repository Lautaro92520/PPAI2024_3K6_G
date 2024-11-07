using System.Drawing.Text;

namespace PPAIDSI.Dominio
{
    public class RegionVitivinicola
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }    

        public RegionVitivinicola() { }

        public RegionVitivinicola(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string getNombre()
        {
            return this.nombre;
        }

    }
}