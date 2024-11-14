using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Dominio
{
    public class Enofilo
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private Image imagenPerfil { get; set; }
        private List<Siguiendo> seguidos { get; set; }

        public List<Siguiendo> getSeguidos()
        {
             return seguidos;
        }
    }
}
