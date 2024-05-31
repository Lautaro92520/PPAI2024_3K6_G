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

        public Pais() { }
        public Pais(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
    }
}
