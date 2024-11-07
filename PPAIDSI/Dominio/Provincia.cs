
namespace PPAIDSI.Dominio
{
    public class Provincia
    {
        private string nombre { get; set; }
        private List<RegionVitivinicola> regiones { get; set; }

        public Provincia() { }
        public Provincia(string nombre, List<RegionVitivinicola> regiones)
        { 
            this.nombre = nombre;
            this.regiones = regiones; 
        }

        public bool esTuRegion(string regionN)
        {
            foreach (RegionVitivinicola region in regiones)
            {
                if (region.getNombre() == regionN) {  return true; }
            }
            return false;
        }
    }
}