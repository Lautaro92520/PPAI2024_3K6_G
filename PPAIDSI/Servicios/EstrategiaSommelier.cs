using PPAIDSI.Datos;
using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Servicios
{
    public class EstrategiaSommelier : IEstrategiaReseñas
    {

        public List<(Vino, double)> buscarVinos(DateTime fechaD, DateTime fechaH)
        {
            List<Vino> vinos = buscarVinosConReseña(fechaD, fechaH);      
            return calcularCalificacion(vinos, fechaD, fechaH);
        }

        private List<Vino> buscarVinosConReseña(DateTime fechaD, DateTime fechaH)
        {
            List<Vino> vinosConReseña = new List<Vino>();

            List<Vino> vinos = CapaAuxiliar.GetVinoByFilter("");

            foreach (Vino v in vinos)
            {
                if (v.tieneReseñaSommelier(fechaD, fechaH))
                {
                    vinosConReseña.Add(v);
                }
            }

            if (vinosConReseña.Count == 0)
            {
                MessageBox.Show("No hay vinos con reseñas de sommelier en las fechas especificadas. El programa se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            return vinosConReseña;
        }

        public List<(Vino, double)> calcularCalificacion(List<Vino> vinos, DateTime fechaD, DateTime fechaH)
        {
            List<(Vino, double)> vinosConPromedio = new List<(Vino, double)>();
            List<double> promedios = new List<double>();
            
            foreach (Vino v in vinos)
            {
                double pro = v.obtenerPromedio(fechaD, fechaH);
                promedios.Add(pro);
            }

            for (int i = 0; i < vinos.Count(); i++)
            {
                vinosConPromedio.Add((vinos[i], promedios[i]));
            }

            return vinosConPromedio;
        }
    }
}
