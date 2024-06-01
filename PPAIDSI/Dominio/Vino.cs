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

        public bool tieneReseñaSommelier(DateTime desde, DateTime hasta)
        {
            foreach (Reseña r in this.reseñas)
            {
               if (r.sosDePeriodo(desde, hasta))
               {
                    if (r.sosDeSommelier())
                    {
                        return true;
                    }
               }
            }
            return false;
        }

        public double obtenerPromedio(DateTime desde, DateTime hasta)
        {
            float puntaje = 0;
            int cantidad = 0;
            foreach (Reseña r in this.reseñas)
            {
                if (r.sosDePeriodo(desde, hasta))
                {
                    if (r.sosDeSommelier())
                    {
                        int nota = r.getPuntaje();
                        puntaje += nota;
                        cantidad ++;
                    }
                }                      
            }
            return Math.Round(puntaje / cantidad, 1); 
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public double getPrecio()
        {
            return this.precioARS;
        }

        public List<string> getBodega()
        {
            string nombre = this.bodega.getNombre();
            string region = this.bodega.getRegion();
            string pais = this.bodega.getPais();
            List<string> list = new List<string> { nombre, region, pais };
            return list;
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
    }
}
