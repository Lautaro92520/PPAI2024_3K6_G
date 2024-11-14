using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Servicios
{
    public class EstrategiaAmigos : IEstrategiaReseñas
    {
        public double calcularPuntaje(DateTime fechaD, DateTime fechaH, List<Reseña> reseñas)
        {
            int puntaje = 0;
            int cantidad = 0;

            foreach (Reseña res in reseñas)
            {
                if (res.sosDePeriodo(fechaD, fechaH))
                {
                    if (res.sosDeEnofilo())
                    {
                        Enofilo enofilo = res.getEnofilo();
                        List<Siguiendo> seguidos = enofilo.getSeguidos(); 
                        foreach (Siguiendo seguido in seguidos)
                        {
                            if(seguido.sosDeAmigo())
                            {
                                int nota = res.getPuntaje();
                                puntaje += nota;
                                cantidad++;
                            }
                        }
                    }
                }
            }

            if (cantidad == 0)
            {
                return 0;
            }

            return calcularPromedio(puntaje, cantidad);
        }

        public double calcularPromedio(int puntaje, int cantidad)
        {
            return Math.Round((double)puntaje / cantidad, 1);
        }
    }
}
