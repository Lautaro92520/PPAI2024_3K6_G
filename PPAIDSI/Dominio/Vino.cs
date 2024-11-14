using PPAIDSI.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSI.Dominio
{
    public class Vino
    {
        private int añada { get; set; }
        private Image imagenEtiqueta { get; set; }
        private string nombre { get; set; }
        private string notaDeCataBodega { get; set; }
        private float precioARS { get; set; }
        private List<Varietal> varietales { get; set; }
        private List<Reseña> reseñas { get; set; }
        private Bodega bodega { get; set; }
        private Enofilo enofilo { get; set; }

        public Vino(string nombre, int anada, string nota, float precio, Bodega bodega, List<Reseña> res, List<Varietal> varietales)
        {
            this.nombre = nombre;
            this.añada = anada;
            this.notaDeCataBodega = nota;
            this.precioARS = precio;
            this.bodega = bodega;
            this.reseñas = res;
            this.varietales = varietales;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getPrecio()
        {
            return this.precioARS;
        }

        public Bodega getBodega()
        {
            return this.bodega;
        }

        public RegionVitivinicola getRegion()
        {
            return this.bodega.getRegion();
        }

        public string getDescripcionVarietales()
        {
            bool primero = true;
            string descripciones = "";
            foreach (Varietal v in this.varietales)
            {
                if (primero != true)
                {
                    descripciones += ", ";
                }
                descripciones += v.getDescripcion();
                primero = false;
            }
            return descripciones;
        }

        public double calcularPuntaje(DateTime fechaDesde, DateTime fechaHasta, IEstrategiaReseñas estrategia)
        {
            return estrategia.calcularPuntaje(fechaDesde, fechaHasta, this.reseñas);
        }
    }
}
