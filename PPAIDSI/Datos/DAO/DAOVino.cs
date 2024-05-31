using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.VisualBasic;
using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClosedXML.Excel.XLPredefinedFormat;
using SystemDateTime = System.DateTime;

namespace PPAIDSI.Datos.DAO
{
    public class DAOVino : IDAOVino
    {
        public List<Vino> GetVinoByFilter(string nombre)
        {
            List<Vino> lista = new List<Vino>();
            string query = "SELECT * FROM Vino WHERE 1=1";
            if (!string.IsNullOrEmpty(nombre))
            {
                query += " AND Nombre Like '%" + nombre + "%'";
            }

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Nombre", nombre));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string nom = row["nombre"].ToString();
                string nota = row["nota_cata_bodega"].ToString();
                int anada = int.Parse(row["anada"].ToString());
                float precio = float.Parse(row["precio_ars"].ToString());
                Bodega bodega = GetBodegaById((int)row["id_bodega"]);
                List<Reseña> reseñas = GetResenasByIdVino((int)row["Id"]);
                List<Varietal> varietales = GetVarietalesByIdVino((int)row["Id"]);
                Vino vino = new Vino(nom, anada, nota, precio, bodega, reseñas, varietales);
                lista.Add(vino);
            }

            return lista;
        }

        public List<Varietal> GetVarietalesByIdVino(int id)
        {
            List<Varietal> varietales = new List<Varietal>();
            string query = "SELECT * FROM Varietal WHERE id_vino Like '%" + id + "%'";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Id_Vino", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string desc = row["descripcion"].ToString();
                int por = int.Parse(row["porcentaje_composicion"].ToString());
                TipoUva tipoUva = GetTipoUvaById((int)row["tipo_uva"]);
                Varietal var = new Varietal(desc, por, tipoUva);
                varietales.Add(var);
            }
            return varietales;
        }

        public TipoUva GetTipoUvaById(int id)
        {
            TipoUva tipoUva = new TipoUva();
            string query = "SELECT * FROM TipoUva WHERE id = " + id;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string desc = row["descripcion"].ToString();
                string nombre = row["nombre"].ToString();
                TipoUva uva = new TipoUva(nombre, desc);
                tipoUva = uva;
            }
            return tipoUva;
        }

        public Bodega GetBodegaById(int id)
        {
            Bodega bodega = new Bodega();
            string query = "SELECT * FROM Bodega WHERE id = " + id;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string coor = row["coordenadas_ubicacion"].ToString();
                string desc = row["descripcion"].ToString();
                string historia = row["historia"].ToString();
                string nombre = row["nombre"].ToString();
                SystemDateTime periodo = SystemDateTime.Parse(row["periodo_actualizacion"].ToString());
                RegionVitivinicola region = GetRegionById((int)row["id_region"]);
                Bodega bode = new Bodega(coor, desc, historia, nombre, periodo, region);
                bodega = bode;
            }
            return bodega;
        }

        public RegionVitivinicola GetRegionById(int id)
        {
            RegionVitivinicola region = new RegionVitivinicola();
            string query = "SELECT * FROM RegionVitivinicola WHERE id = " + id;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string desc = row["descripcion"].ToString();
                string nombre = row["nombre"].ToString();
                Provincia prov = GetProvinciaById((int)row["id_provincia"]);
                RegionVitivinicola reg = new RegionVitivinicola(nombre, desc, prov);
                region = reg;
            }
            return region;
        }

        public Provincia GetProvinciaById(int id)
        {
            Provincia provincia = new Provincia();
            string query = "SELECT * FROM Provincia WHERE id = " + id;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string nombre = row["nombre"].ToString();
                Pais pais = GetPaisById((int)row["id_pais"]);
                Provincia prov = new Provincia(nombre, pais);
                provincia = prov;
            }
            return provincia;
        }

        public Pais GetPaisById(int id)
        {
            Pais pais = new Pais();
            string query = "SELECT * FROM Pais WHERE id = " + id;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                string nombre = row["nombre"].ToString();
                Pais oPais = new Pais(nombre);
                pais = oPais;
            }
            return pais;
        }

        public List<Reseña> GetResenasByIdVino(int id)
        {
            List<Reseña> reseñas = new List<Reseña>();
            string query = "SELECT * FROM Resena WHERE id_vino Like '%" + id + "%'";  

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Id_Vino", id));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                int idR = int.Parse(row["Id"].ToString());
                string comentario = row["comentario"].ToString();
                bool es_premium = (bool)row["es_premium"];
                SystemDateTime fecha = SystemDateTime.Parse(row["fecha_reseña"].ToString());
                int puntaje = (int)row["puntaje"];
                Sommelier sommelier = GetSommelierByID(idR);
                Reseña res = new Reseña(comentario, es_premium, fecha, puntaje, sommelier);
                reseñas.Add(res);
            }
            return reseñas;
        }

        private Sommelier GetSommelierByID(int idR)
        {
            Sommelier sommelier = new Sommelier(); 
            string query = "SELECT * FROM Sommelier WHERE id = " + idR;

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id", idR));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                SystemDateTime fechaVal = SystemDateTime.Parse(row["fecha_validacion"].ToString());
                string nombre = row["nombre"].ToString();
                string nota = row["nota_presentacion"].ToString();
                Sommelier somme = new Sommelier(nombre, nota, fechaVal);
                sommelier = somme;
            }
            return sommelier;
        }
    }
}
