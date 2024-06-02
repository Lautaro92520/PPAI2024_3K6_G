using PPAIDSI.Datos;
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
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private bool _sommelier;
        private bool _excel;
        private List<Vino> _vinosConReseña = new List<Vino>();
        private List<double> _promediosVinos = new List<double>();
        private List<List<object>> _datosVinos = new List<List<object>>();
        private List<Vino> _vinosOrdenados = new List<Vino>();
        private List<double> _puntajesOrdenados = new List<double>();

        private CapaAuxiliar capaAuxiliar;

        public ControladorGenerarReporte(VentanaGenerarRanking ventana)
        {
            _ventana = ventana;
            capaAuxiliar = new CapaAuxiliar();
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
            ordenarSegunPromedio(_vinosConReseña, _promediosVinos);
            buscarDatosVinos(_vinosOrdenados, _puntajesOrdenados);
            InterfazExcel.exportarExcel(_datosVinos);
            _ventana.mostrarExcel();
        }

        private void buscarDatosVinos(List<Vino> vinosOrdenados, List<double> puntajes)
        {
            int i = 0;
            List<List<object>> lista = new List<List<object>>();
            foreach (Vino v in vinosOrdenados)
            {
                string nombre = v.getNombre();
                double precio = v.getPrecio();
                List<string> nombres = v.getBodega();
                string varietal = v.getDescripcionVarietales();
                List<object> list = new List<object> { nombre, puntajes[i], precio, nombres[0], nombres[1], nombres[2], varietal };
                lista.Add(list);
                i++;
            }
            _datosVinos = lista;
        }

        private void ordenarSegunPromedio(List<Vino> vinos, List<double> puntajes)
        {
            List<int> indices = Enumerable.Range(0, vinos.Count).ToList();

            indices.Sort((i, j) => puntajes[j].CompareTo(puntajes[i]));

            _vinosOrdenados = indices.Select(i => vinos[i]).ToList();
            _puntajesOrdenados = indices.Select(i => puntajes[i]).ToList();
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
            List<Vino> vinos = capaAuxiliar.GetVinoByFilter("");
            foreach (Vino v in vinos)
            {
                if (v.tieneReseñaSommelier(desde, hasta))
                {
                    _vinosConReseña.Add(v);
                }                      
            }

            if (_vinosConReseña.Count == 0)
            {
                MessageBox.Show("No hay vinos con reseñas de sommelier en las fechas especificadas. El programa se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }   
    }
}
