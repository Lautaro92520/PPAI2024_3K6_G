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
        private List<(Vino, double)> _vinosConPromedio = new List<(Vino, double)>();   
        private List<List<object>> _datosVinos = new List<List<object>>();
        private List<(Vino, double)> _vinosConPromedioOrdenados;

        private IEstrategiaReseñas _estrategia;
        private bool _excel;

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
            int val = validarPeriodo(desde, hasta);
            if (val == 1)
            {
                _fechaDesde = desde;
                _fechaHasta = hasta;
                _ventana.solicitarTipoReseña();
            }
            else
            {
                _ventana.solicitarFechaDesdeHasta();
            }
        }

        public void tomarSeleccionSommelier()
        {
            crearEstrategia();
            _ventana.solicitarFormaVisualizacion();
        }

        private void crearEstrategia()
        {
            _estrategia = new EstrategiaSommelier();
        }

        public void TomarSeleccionExcel()
        {
            _excel = true;
            _ventana.solicitarConfirmacion();
        }

        private int validarPeriodo(DateTime desde, DateTime hasta)
        {
            int val = 1;
            if (desde > hasta)
            {
                MessageBox.Show("Las fechas ingresadas no son validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                val = 0;
            }
            return val;
        }

        public void tomarConfirmacion()
        {
            buscarVinos();
            ordenarSegunPromedio();
            buscarDatosVinos(_vinosConPromedioOrdenados);
            InterfazExcel.exportarExcel(_datosVinos);
            _ventana.mostrarExcel();
            finCU();
        }

        private void buscarVinos()
        {
            double puntaje = 0;
            List<Vino> vinos = CapaAuxiliar.GetVinoByFilter("");
            foreach(Vino vino in vinos)
            {
                puntaje = vino.calcularPuntaje(_fechaDesde, _fechaHasta, _estrategia);
                if (puntaje > 0)
                {
                    _vinosConPromedio.Add((vino, puntaje));
                }
            }
        }

        private void finCU()
        {
            MessageBox.Show("El CU ha finalizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }

        private void buscarDatosVinos(List<(Vino, double)> vinosConPromedios)
        {
            List<Pais> paises = CapaAuxiliar.GetPaises();
            List<List<object>> lista = new List<List<object>>();
            foreach (var I in vinosConPromedios)
            {
                string nombre = I.Item1.getNombre();
                double precio = I.Item1.getPrecio();
                Bodega bodega = I.Item1.getBodega();
                string bodegaN = bodega.getNombre();
                RegionVitivinicola region = I.Item1.getRegion();
                string regionN = region.getNombre();
                Pais pais = new Pais();
                
                foreach (Pais p in paises)
                {
                    if (p.esTuRegion(regionN))
                    {
                        pais = p;
                    }
                }      

                string paisN = pais.getNombre();
                string varietal = I.Item1.getDescripcionVarietales();
                List<object> list = new List<object> { nombre, I.Item2, precio, bodegaN, regionN, paisN, varietal };
                lista.Add(list);
            }
            _datosVinos = lista;
        }

        private void ordenarSegunPromedio()
        {
            _vinosConPromedioOrdenados = _vinosConPromedio.OrderByDescending(v => v.Item2).ToList();
        }
    }
}
