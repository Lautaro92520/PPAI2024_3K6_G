using DocumentFormat.OpenXml.CustomProperties;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPAIDSI.Datos
{
    class HelperDB
    {
        private static HelperDB instance;
        private SqlConnection cnn;

        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public static HelperDB GetInstance()
        {
            if (instance == null)
                instance = new HelperDB();
            return instance;
        }

        public int EjecutarSQL(string strSql, List<Parametro> lst)
        {
            int rafc = 0;
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;

            foreach (Parametro p in lst)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            rafc = cmd.ExecuteNonQuery();
            cnn.Close();

            return rafc;
        }

        public List<Vino> GetVinos()
        {
            List<Vino> lista = new List<Vino>();

            string query = "SELECT * FROM Vino";

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cnn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string nombre = dr["nombre"].ToString();
                    int anada = (int)dr["anada"];
                    int nota = (int)dr["nota_cata_bodega"];
                    double precio = (double)dr["precio_ars"];
                    Bodega bodega = new Bodega();
                    Sommelier sommelier = new Sommelier();
                    List<Reseña> reseñas = GetReseñas((int)dr["Id"]);
                    Vino vino = new Vino(nombre, anada, nota, precio, bodega, sommelier, reseñas);
                    lista.Add(vino);
                }
                cnn.Close();
            }
            return lista;
        }

        private List<Reseña> GetReseñas(int id)
        {
            List<Reseña> reseñas = new List<Reseña>();
            using (cnn) 
            {
                cnn.Open();

                var cmd = new SqlCommand("SELECT * FROM Reseñas WHERE id_vino = @id", cnn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = cmd.ExecuteReader();
                using(dr)
                {
                    while (dr.Read())
                    {
                        string comentario = dr["comentario"].ToString();
                        int es_premium = (int)dr["es_premium"];
                        DateTime fecha = DateTime.Parse(dr["fecha_reseña"].ToString());
                        int puntaje = (int)dr["puntaje"];
                        Reseña res = new Reseña(comentario, es_premium, fecha, puntaje);
                        reseñas.Add(res);
                    }  
                }
            }
            return reseñas;
        }
    }
}
