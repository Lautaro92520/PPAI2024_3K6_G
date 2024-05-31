using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Dominio
{
    public class Sommelier
    {
        private string nombre { get; set; }
        private string notaPresentacion { get; set; }
        private DateTime fechaValidacion { get; set; }

        public Sommelier() { }

        public Sommelier(string nombre, string nota, DateTime fecha)
        {
            this.nombre = nombre;
            this.notaPresentacion = nota;
            this.fechaValidacion = fecha;
        }
    }
}
