using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Dominio
{
    public class Bodega
    {
        private int coordenadasUbicacion {  get; set; }
        private string descripcion { get; set; }
        private string historia { get; set; }
        private string nombre { get; set; }
        private DateTime periodoActualizacion { get; set; }
        private RegionVitivinicola region { get; set; }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getRegion()
        {
            return this.region.getNombre();
        }

        public string getPais()
        {
            return this.region.getPais();
        }
    }
}
