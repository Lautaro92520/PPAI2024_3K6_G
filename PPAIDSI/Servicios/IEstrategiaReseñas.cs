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
        public double calcularPuntaje(DateTime fechaD, DateTime fechaH, List<Reseña> reseñas);
    }
}
