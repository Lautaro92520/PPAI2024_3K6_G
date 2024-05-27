﻿using System;
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
        private int notaDeCataBodega { get; set; }
        private int precioARS { get; set; }
        private List<Varietal> varietales { get; set; }
        private List<Reseña> reseñas { get; set; }
        private Bodega bodega { get; set; }

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

        public int getPrecio()
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
            string descripciones = "";
            foreach (Varietal v in this.varietales)
            {
                string str = v.getDescripcion();
                descripciones += str + ", ";
            }
            return descripciones;
        }
    }
}
