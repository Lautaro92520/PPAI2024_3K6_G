using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Dominio
{
    public class Bodega
    {
        private string coordenadasUbicacion {  get; set; }
        private string descripcion { get; set; }
        private string historia { get; set; }
        private string nombre { get; set; }
        private DateTime periodoActualizacion { get; set; }
        private RegionVitivinicola region { get; set; }

        public Bodega() { }

        public Bodega(string coordenadasUbicacion, string descripcion, string historia, string nombre, DateTime periodoActualizacion, RegionVitivinicola region)
        {
            this.coordenadasUbicacion = coordenadasUbicacion;
            this.descripcion = descripcion;
            this.historia = historia;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;
            this.region = region;
        }

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
