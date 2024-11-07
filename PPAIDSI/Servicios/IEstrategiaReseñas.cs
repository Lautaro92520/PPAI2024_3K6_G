using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Servicios
{
    public interface IEstrategiaReseñas
    {
        public List<(Vino, double)> buscarVinos(DateTime fechaD, DateTime fechaH);
    }
}
