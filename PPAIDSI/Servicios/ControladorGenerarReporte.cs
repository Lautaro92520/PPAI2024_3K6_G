using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Servicios
{
    public class ControladorGenerarReporte
    {
        private VentanaGenerarRanking _ventana;
        private int paso;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private bool _sommelier;
        private bool _excel;
        private List<Vino> _vinosConReseña;
        private List<double> _promediosVinos;
        private List<List<object>> _datosVinos;

        public ControladorGenerarReporte(VentanaGenerarRanking ventana)
        {
            _ventana = ventana;
        }

        public void generarRanking()
        {
            _ventana.solicitarFechaDesdeHasta();
        }

        public void TomarFechaDesdeHasta(DateTime desde, DateTime hasta)
        {
            validarPeriodo(desde, hasta);
            _fechaDesde = desde;
            _fechaHasta = hasta;
            _ventana.solicitarTipoReseña();
        }

        public void tomarSeleccionSommelier()
        {
            _sommelier = true;
            _ventana.solicitarFormaVisualizacion();
        }

        public void TomarSeleccionExcel()
        {
            _excel = true;
            _ventana.solicitarConfirmacion();
        }

        private void validarPeriodo(DateTime desde, DateTime hasta)
        {
            if (desde > hasta)
            {
                MessageBox.Show("Las fechas ingresadas no son validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        public void tomarConfirmacion()
        {
            buscarVinos(_fechaDesde, _fechaHasta);
            calcularPromedio();
            List<Vino> vinosOrdenados = ordenarSegunPromedio(_vinosConReseña, _promediosVinos);
            _datosVinos = buscarDatosVinos(vinosOrdenados);
        }

        private List<List<object>> buscarDatosVinos(List<Vino> vinosOrdenados)
        {
            List<List<object>> lista = new List<List<object>>();
            foreach (Vino v in vinosOrdenados)
            {
                string nombre = v.getNombre();
                double puntaje = v.pu
                double precio = v.getPrecio();
                List<string> nombres = v.getBodega();
                string varietal = v.getDescripcionVarietales();
                List<object> list = new List<object> { nombre, precio, nombres[0], nombres[1], nombres[2], varietal };
                lista.Add(list);
            }
            return lista;
        }

        private List<Vino> ordenarSegunPromedio(List<Vino> vinos, List<double> puntajes)
        {
            var vinosConPuntajes = vinos.Zip(puntajes, (vino, puntaje) => new {Vino = vino, Puntaje = puntaje}).ToList();
            var vinosOrdenadosPorPuntaje = vinosConPuntajes.OrderBy(vp => vp.Vino).ToList();
            return vinosOrdenadosPorPuntaje.Select(vp => vp.Vino).ToList();
        }

        private void calcularPromedio()
        {
            foreach (Vino v in _vinosConReseña)
            {
                double pro = v.obtenerPromedio(_fechaDesde, _fechaHasta);
                _promediosVinos.Add(pro);
            }
        }

        private void buscarVinos(DateTime desde, DateTime hasta)
        {
            List<Vino> vinos = new List<Vino>(); //HelperDB
            foreach (Vino v in vinos)
            {
                if (v.tieneReseñaSommelier(desde, hasta))
                {
                    _vinosConReseña.Add(v);
                }
            }
        }
    }
}
