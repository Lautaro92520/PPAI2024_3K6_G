using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Dominio
{
    public class Pais
    {
        private string nombre { get; set; }
        private List<Provincia> provincias { get; set; }

        public Pais() { }
        public Pais(string nombre, List<Provincia> provincias)
        {
            this.nombre = nombre;
            this.provincias = provincias;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public bool esTuRegion(string regionN)
        {
            foreach (Provincia provincia in provincias)
            {
                if (provincia.esTuRegion(regionN))
                {
                    return true; 
                }
            }
            return false;
        }
    }
}
